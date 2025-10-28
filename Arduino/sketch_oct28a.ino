const int buttonPin_1 = 5;
const int buttonPin_2 = 6;
const int buttonPin_3 = 7;
const int buttonPin_4 = 8;
const int buttonPin_5 = 9;

int buttonVal_1;
Filter your search...
Type:

All






int buttonVal_2;
int buttonVal_3;
int buttonVal_4;
int buttonVal_5;

void setup() {
  Serial.begin(9600);
  pinMode(buttonPin_1, INPUT_PULLUP);
  pinMode(buttonPin_2, INPUT_PULLUP);
Filter your search...
Type:

All





  pinMode(buttonPin_3, INPUT_PULLUP);
  pinMode(buttonPin_4, INPUT_PULLUP);
  pinMode(buttonPin_5, INPUT_PULLUP);

}

void loop() {
  buttonVal_1 = digitalRead(buttonPin_1);
  buttonVal_2 = digitalRead(buttonPin_2);
  buttonVal_3 = digitalRead(buttonPin_3);
  buttonVal_4 = digitalRead(buttonPin_4);
  buttonVal_5 = digitalRead(buttonPin_5);

  Serial.print(buttonVal_1);
  Serial.print(buttonVal_2);
  Serial.print(buttonVal_3);
  Serial.print(buttonVal_4);
  Serial.println(buttonVal_5);
  delay(100);
}
