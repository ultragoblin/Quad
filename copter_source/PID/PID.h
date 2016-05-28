class PID
{
	public:
		PID();
		float step(float tar_val, float val, float dt);
		void setK(float P0, float I0, float D0);
		void clearErr();
	private:
		float last_err;
		float sum_err;
		float curr_val;
		float P;
		float I;
		float D;

};