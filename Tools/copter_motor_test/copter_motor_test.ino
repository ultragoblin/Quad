

int ch;
int cur_val=160;
int max = 160;
int min = 88;
void setup() {
  Serial.begin(9600);
  pinMode(11, OUTPUT);
}

void loop() {
  if (Serial.available() > 0) {
    // get incoming byte:
    ch = Serial.read();
    
    if (ch == 45 && cur_val > min){
      cur_val--;
      Serial.println(String(cur_val));
    }
    else if (ch == 43 && cur_val < max){
      cur_val++;
      Serial.println(String(cur_val));
    }
    else if (ch == 32){
      cur_val = min;
      Serial.println(String(cur_val));
    }
  }
  analogWrite(11,cur_val);
}
