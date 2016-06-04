#include <Arduino.h>
#include "copterdrive.h"


copterdrive::copterdrive(int p)
{
	pin = p;
    max = 255;
    min = 88;
	curr_pwd = min;

	pinMode(pin, OUTPUT);
	analogWrite(pin,curr_pwd);
};

int copterdrive::getMax()
{
	return max;
};
int copterdrive::getMin()
{
	return min;
};
int copterdrive::getPwd()
{
	return curr_pwd;
};

void copterdrive::setpwD(int pwd)
{
	if((pwd>=min)&&(pwd<=max))
	{
		 curr_pwd = pwd;
		 analogWrite(pin,curr_pwd);
	}
};