#include "PID.h"
#include <Arduino.h>

PID::PID()
{
	last_err = 0.0;
	sum_err = 0.0;
	P = 0.2;
	I = 6.0;
	D = 0.01;
}

void PID::setK(float P0, float I0, float D0)
{
	last_err = 0.0;
	sum_err = 0.0;
	P = P0;
	I = I0;
	D = D0;
}
void PID::clearErr()
{
	last_err = 0.0;
	sum_err = 0.0;
}

float PID::step(float tar_val, float val, float dt)
{
	float err = tar_val - val;

	float derr = err - last_err;
	sum_err = sum_err+err;
	/*Serial.print("inPid: ");
	Serial.print(I);
	Serial.print('\t');
	Serial.print(sum_err);
	Serial.print('\t');
	Serial.print(dt);
	Serial.print('\t');
	Serial.print(err);
	Serial.print('\t');
	Serial.println(last_err);*/


	float res = P*err+I*dt*sum_err+D*(derr/dt);
	
	last_err = err;
	return res;

}