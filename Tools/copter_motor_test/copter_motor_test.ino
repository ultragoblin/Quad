
String str;
int ch;
int cur_val=160;
int max = 160;
int min = 88;
void setup() {
  Serial.setTimeout(10000);
  Serial.begin(9600);
  pinMode(11, OUTPUT);
}

void loop() {
  if (Serial.available() > 0) {
    // get incoming byte:
    ch = Serial.read();
    
    if (ch == 45 && cur_val > min){  // "-" dec throttle
      cur_val--;
      Serial.println(String(cur_val));
    }
    else if (ch == 43 && cur_val < max){  // "+" inc throttle
      cur_val++;
      Serial.println(String(cur_val));
    }
    else if (ch == 32){  // "Space" zero throttle
      cur_val = min;
      Serial.println(String(cur_val));
    }
    else if (ch == 99){  // "c" configure
      analogWrite(11,0);

      Serial.println("Input min val:");
      str = Serial.readStringUntil(13);
      min = str.toInt();
      Serial.println(min);
      
      Serial.println("Input max val:");
      str = Serial.readStringUntil(13);
      max = str.toInt();
      Serial.println(max);

      Serial.println("Input init val:");
      str = Serial.readStringUntil(13);
      cur_val = str.toInt();
      Serial.println(cur_val);
    }
  }
  analogWrite(11,cur_val);
}
