int led = 13;

void setup()
{

  /* add setup code here */
  Serial.begin(9600);
	pinMode(led, OUTPUT);
	
}

void loop()
{

  /* add main program code here */
	if (Serial.available()) {
		  int c = Serial.read();
		if (c == '1') {
			digitalWrite(led, HIGH);
     delay(1000);
		}
		else if (c == '0') {
			digitalWrite(led, LOW);
      delay(1000);
		}
	}
}
