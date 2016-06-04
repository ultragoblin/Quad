#include <Arduino.h>


bool can_ping = true;

uint8_t * arg = new uint8_t[12];

SoftwareSerial softSerial(7,8);

void initGyro(int tx, int rx)
{
	softSerial.initNew(tx,rx);
	softSerial.begin(19200);
	//can_ping = true;
}

float temp[3];

float* getAngles()
{
	softSerial.listen();
/*	Serial.println("WE ARE GOT ANGLES");
	
	Serial.print("canping:");
	Serial.println(can_ping);*/
	if(can_ping)
	{
	//	Serial.println("WE PING");
        softSerial.write('p');
        can_ping = false;
	}
	while (softSerial.available()<12)
	{
		//Serial.println(softSerial.available());
	}
    if(softSerial.available()>=12)
    {
	//	Serial.println("canping0");
        for (int i=0; i<12; i++)
        {
           arg[i] = softSerial.read();
	//	   Serial.print("canping ");
	//	   Serial.println(i);
        }
	//	Serial.println("we get angles");
		temp[0] = *((float*)&arg[0]);

		temp[1] = *((float*)&arg[4]);

		temp[2] = *((float*)&arg[8]);
	//	Serial.print("canping2:");
	 //   Serial.println(can_ping);
		can_ping = true;

	}

	return temp;
}
