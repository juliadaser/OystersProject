int hallPin1 = 7;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(hallPin1, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println(digitalRead(hallPin1));
  delay(200);
}
