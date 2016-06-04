class copterdrive
{
public:
	copterdrive(int pin);
	int getMax();
	int getMin();
	int getPwd();
	void setMax(int m);
	void setMin(int m);
	void setpwR(int pr);
	void setpwD(int pwd);
private:
	int max;
	int min;
	int curr_pwd;
	int pin;
};