#include <copterdrive.h>
#include <SoftwareSerial.h>
#include <ndof.h>
#include <PID.h>
#include <WiFly.h>

//general defines=====================================
#define NAME "D_Valk"
#define M_PI            3.14159265358979323846


//wi-fi defines========================================
#define SSID "mppoint"
#define KEY "12345678"
#define AUTH WIFLY_AUTH_WPA2_PSK
SoftwareSerial wiflyUart(5, 6);
WiFly wifly(&wiflyUart);

//drive defines========================================
int pinM1 = 3;
int pinM2 = 9;
int pinM3 = 10;
int pinM4 = 11;

copterdrive M1 = copterdrive(pinM1);
copterdrive M2 = copterdrive(pinM2);
copterdrive M3 = copterdrive(pinM3);
copterdrive M4 = copterdrive(pinM4);

int M1pwr = M1.getMin();
int M2pwr = M2.getMin();
int M3pwr = M3.getMin();
int M4pwr = M4.getMin();

//control defines======================================
PID pid_Yaw = PID();
PID pid_Pitch = PID();
PID pid_Roll = PID();

float  tar_Yaw = 0.0; 
float  tar_Pitch = 0.0;
float  tar_Roll = 0.0;
float  tar_Power = 0.0;

float  ang_Yaw; 
float  ang_Pitch;
float  ang_Roll;

float *angles;

void ALARM()
{
}

void setup() {
//general-init=========================================
  Serial.begin(115200); 
  Serial.println("START INITIALIZATION");
  initGyro(8,12);
//wifi-init============================================
  Serial.println("WIFI INIT");
  wiflyUart.begin(9600);
  delay(1000);
  wifly.reset(); // reset the shield
  delay(1000);
  wifly.sendCommand("set ip local 80\r"); // set the local comm port to 80
  delay(100);
  wifly.sendCommand("set comm remote *connection active*\r"); // do not send a default string when a connection opens
  delay(100);
  wifly.sendCommand("set comm open *open*\r"); // set the string or character that the wifi shield will output when a connection is opened "*"
  delay(100);
  wifly.sendCommand("set ip protocol 2\r"); // set TCP protocol
  delay(100);
  wifly.sendCommand("set ip dhcp 0\r"); // turn out dhcp
  delay(100);
  wifly.sendCommand("set ip address 192.168.173.2\r"); // static IP
  delay(100);
  wifly.sendCommand("set ip gateway 192.168.173.1\r"); 
  delay(100);
  wifly.sendCommand("set ip netmask 255.255.255.0\r"); 
  delay(100);
   Serial.println("START connect");
  if (wifly.join(SSID, KEY, AUTH)) {
  Serial.println("OK");
  } else {
  Serial.println("Failed");
  }
  
  wifly.sendCommand("open 192.168.173.1 80\r"); //connect to host
  delay(100);
  for (int i=0; i<63; i++)
  {
    Serial.print((char)wiflyUart.read());
  }
   Serial.println("CONTROL INIT");
//control init===================================
 
   pid_Yaw.setK(6,0.1,0.5);
   pid_Pitch.setK(6,0.1,0.5);
   pid_Roll.setK(6,0.1,0.5);


//driver init====================================
}


int i=0;
byte sz;
char cmd;

void exec_command(char com, byte* arg, float* angles)
{
   switch (com) {
    case 'p': //ping;      
            {
               ang_Yaw   = angles[0];
               ang_Pitch = angles[1];
               ang_Roll  = angles[2];
               pid_Yaw.clearErr();
               pid_Pitch.clearErr();
               pid_Roll.clearErr();
               break;
            }
    case 's':  //set PIDs      
            {
              pid_Yaw.setK(*((float*)&arg[0]),*((float*)&arg[4]),*((float*)&arg[8]));
              pid_Pitch.setK(*((float*)&arg[12]),*((float*)&arg[16]),*((float*)&arg[20]));
              pid_Roll.setK(*((float*)&arg[24]),*((float*)&arg[28]),*((float*)&arg[32]));
              Serial.print("setPID");
              Serial.print('\t');
              Serial.print(*((float*)&arg[24]));
              Serial.print('\t');
              Serial.print(*((float*)&arg[28]));
              Serial.print('\t');
              Serial.println(*((float*)&arg[32]));
              break;
            }
    case 'a':  //set angles      
            {
              tar_Yaw   = *((float*)&arg[0]);
              tar_Pitch = *((float*)&arg[4]);
              tar_Roll  = *((float*)&arg[8]);
              tar_Power = *((float*)&arg[12]);
              break;
            }
    case 'd':  //set motors      
            {
              M1pwr = *((int*)&arg[0]);
              M2pwr = *((int*)&arg[2]);
              M3pwr = *((int*)&arg[4]);
              M4pwr = *((int*)&arg[6]);
              
              M1.setpwD(M1pwr);
              M2.setpwD(M2pwr);
              M3.setpwD(M3pwr);
              M4.setpwD(M4pwr);
              break;
            }   
    default:
            {
              ALARM();
              break;
            }
  }
}

int lasttime = 3000;

void loop() 
{
 Serial.println("loop");
 char c = 'p';
 wiflyUart.listen();
 wifly.send((uint8_t*)&c,1,30);
 while(!wifly.available()){}
 
 if(wifly.available())
 {
    sz = wiflyUart.read();
    while (wifly.available()<(sz+1)){}
    cmd = wiflyUart.read();
    byte* arg = new byte[sz]; 
    
    wifly.receive((uint8_t*)arg, sz, 300);
    
    
    exec_command(cmd,arg,angles);
    delete(arg); 
 }
 angles = getAngles();
 
 if (millis()>3000)
 {
    int currtime = millis();
    float dt = (currtime-lasttime)/1000.0;
    if(dt<0){Serial.print("I am right!");}
    lasttime = currtime;
    
    float Y1 = pid_Yaw.step(tar_Yaw,ang_Yaw,dt);
    float P1 = pid_Pitch.step(tar_Pitch,ang_Pitch,dt);
    float R1 = pid_Roll.step(tar_Roll,ang_Roll,dt);

/*    Serial.print(ang_Yaw);
    Serial.print('\t');
    Serial.print(Y1);
    Serial.print('\t');
    Serial.print(ang_Pitch);
    Serial.print('\t');
    Serial.print(P1);
    Serial.print('\t');
    Serial.print(ang_Roll);
    Serial.print('\t');
    Serial.print(R1);
    Serial.print('\t');
    Serial.print("dt=");
    Serial.println(dt);*/


    Serial.print(M1pwr);
    Serial.print('\t');
    Serial.print(M2pwr);
    Serial.print('\t');
    Serial.print(M3pwr);
    Serial.print('\t');
    Serial.println(M4pwr);
 }
 
 

}
