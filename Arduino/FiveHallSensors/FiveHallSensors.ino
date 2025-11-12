const int buttonPin_1 = 5; // ben
const int buttonPin_2 = 6; // danielle
const int buttonPin_3 = 7; //johnny
const int buttonPin_4 = 8; // khoury
const int buttonPin_5 = 9; // rebecca

int buttonVal_1 = 1;
int buttonVal_2 = 1;
int buttonVal_3 = 1;
int buttonVal_4 = 1;
int buttonVal_5 = 1;

int buttonVal_1_Old = 1;
int buttonVal_2_Old = 1;
int buttonVal_3_Old = 1;
int buttonVal_4_Old = 1;
int buttonVal_5_Old = 1;

String active_buttons = "";
int lastPressed;

void setup() {
  Serial.begin(9600);
  pinMode(buttonPin_1, INPUT);
  pinMode(buttonPin_2, INPUT);

  pinMode(buttonPin_3, INPUT);
  pinMode(buttonPin_4, INPUT);
  pinMode(buttonPin_5, INPUT);
}

void loop() {
  buttonVal_1 = digitalRead(buttonPin_1);
  buttonVal_2 = digitalRead(buttonPin_2);
  buttonVal_3 = digitalRead(buttonPin_3);
  buttonVal_4 = digitalRead(buttonPin_4);
  buttonVal_5 = digitalRead(buttonPin_5);

  if (buttonVal_1_Old == 0 && buttonVal_1 == 1) {  // object is picked up
    active_buttons += '1';
  } else if (buttonVal_1_Old == 1 && buttonVal_1 == 0) {  // object is placed down
    String active_buttons_new = "";
    for (int i = 0; i < active_buttons.length(); i = i + 1) {
      if (active_buttons[i] != '1') {
        active_buttons_new += active_buttons[i];
      }
    }
    active_buttons = active_buttons_new;
  }

  if (buttonVal_2_Old == 0 && buttonVal_2 == 1) {
    active_buttons += '2';
  } else if (buttonVal_2_Old == 1 && buttonVal_2 == 0) {  // object is placed down
    String active_buttons_new = "";
    for (int i = 0; i < active_buttons.length(); i = i + 1) {
      if (active_buttons[i] != '2') {
        active_buttons_new += active_buttons[i];
      }
    }
    active_buttons = active_buttons_new;
  }



  if (buttonVal_3_Old == 0 && buttonVal_3 == 1) {
    active_buttons += '3';
  } else if (buttonVal_3_Old == 1 && buttonVal_3 == 0) {  // object is placed down
    String active_buttons_new = "";
    for (int i = 0; i < active_buttons.length(); i = i + 1) {
      if (active_buttons[i] != '3') {
        active_buttons_new += active_buttons[i];
      }
    }
    active_buttons = active_buttons_new;
  }

  if (buttonVal_4_Old == 0 && buttonVal_4 == 1) {
    active_buttons += '4';
  } else if (buttonVal_4_Old == 1 && buttonVal_4 == 0) {  // object is placed down
    String active_buttons_new = "";
    for (int i = 0; i < active_buttons.length(); i = i + 1) {
      if (active_buttons[i] != '4') {
        active_buttons_new += active_buttons[i];
      }
    }
    active_buttons = active_buttons_new;
  }

  if (buttonVal_5_Old == 0 && buttonVal_5 == 1) {
    active_buttons += '5';
  } else if (buttonVal_5_Old == 1 && buttonVal_5 == 0) {  // object is placed down
    String active_buttons_new = "";
    for (int i = 0; i < active_buttons.length(); i = i + 1) {
      if (active_buttons[i] != '5') {
        active_buttons_new += active_buttons[i];
      }
    }
    active_buttons = active_buttons_new;
  }

  buttonVal_1_Old = buttonVal_1;
  buttonVal_2_Old = buttonVal_2;
  buttonVal_3_Old = buttonVal_3;
  buttonVal_4_Old = buttonVal_4;
  buttonVal_5_Old = buttonVal_5;

  // if (active_buttons.length() > 0) {
  //   lastPressed = active_buttons[active_buttons.length() - 1];
  // } else {
  //   lastPressed = 0;
  // }
  // Serial.print(active_buttons);
  // Serial.print("     length:");
  // Serial.print(active_buttons.length());
  // Serial.print("     lastpressed:");
  // Serial.print((char)lastPressed);
  // Serial.print("     first:");
  // Serial.println(active_buttons[0]);

if (active_buttons.length() > 0) {
  lastPressed = active_buttons[active_buttons.length() - 1];
  Serial.println((char)lastPressed);
} else {
  Serial.println("0");
}
//Serial.println(active_buttons);
delay(100);
}
