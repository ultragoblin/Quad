#include <Servo.h>


Servo mot1;

void setup() {
  Serial.begin(115200); 
  // put your setup code here, to run once:
  Serial.println("hf");
mot1.attach(5);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  mot1.write(120);
/*for(int i=0; i<130; i+=50)
{
  Serial.println(i);
  mot1.write(i);
  delay(100);
}

for (int i=50; i>-1; i-=50)
{
  Serial.println(i);
  mot1.write(i);
  delay(100);
}
*/
}
