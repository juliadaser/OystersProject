const int buttonPin_1 = 5;
const int buttonPin_2 = 6;
const int buttonPin_3 = 7;
const int buttonPin_4 = 8;
const int buttonPin_5 = 9;

int buttonVal_1;
int buttonVal_2;
int buttonVal_3;
int buttonVal_4;
int buttonVal_5;

int buttonVal_1_Old;
int buttonVal_2_Old;
int buttonVal_3_Old;
int buttonVal_4_Old;
int buttonVal_5_Old;

void setup() {
  Serial.begin(9600);
  pinMode(buttonPin_1, INPUT_PULLUP);
  pinMode(buttonPin_2, INPUT_PULLUP);

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

  if (buttonVal_1_Old == 1 && buttonVal_1 == 0){
    Serial.println("0");
  };

  if (buttonVal_2_Old == 1 && buttonVal_2 == 0){
    Serial.println("1");
  };

  if (buttonVal_3_Old == 1 && buttonVal_3 == 0){
    Serial.println("2");
  };

  if (buttonVal_4_Old == 1 && buttonVal_4 == 0){
    Serial.println("3");
  };

  if (buttonVal_5_Old == 1 && buttonVal_5 == 0){
    Serial.println("4");
  };

  buttonVal_1_Old = buttonVal_1;
  buttonVal_2_Old = buttonVal_2;
  buttonVal_3_Old = buttonVal_3;
  buttonVal_4_Old = buttonVal_4;
  buttonVal_5_Old = buttonVal_5;

  delay(100);
}
