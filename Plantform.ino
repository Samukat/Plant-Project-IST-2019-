#include <dht.h>

//Sensor
#define dht_apin A0

dht DHT;

const int MoistRead = A0;

//Write
const int TempWrite = 12;
const int MoistWrite = 7;
const int UVWrite = 13;

//Booleans
bool IsWaiting = false;
int VTC = 0; //T = 0, M = 1, L = 2
char StoredData[6];
int counter = 0;


//VTC
float TempAim;
float MoistAim;
float UVLevels;

void setup() {
  // put your setup code here, to run once:
  pinMode(MoistRead, INPUT);
  
  pinMode(TempWrite, OUTPUT);
  pinMode(MoistWrite, OUTPUT);
  pinMode(UVWrite, OUTPUT);
  Serial.begin(9600);
  delay(1500);
}
void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available())  
  {  
    char data=Serial.read();
    if (strlen(StoredData) != 0 && !IsWaiting) {
      if (VTC == 0) {TempAim = atof(StoredData);}
      if (VTC == 1) {MoistAim = atof(StoredData);}
      if (VTC == 2) {UVLevels = (atof(StoredData)*255);}
      memset(data, 0, sizeof(data));
    }
    if (data == ':') {
      counter = 0;
      IsWaiting = !IsWaiting;
    }
    if (IsWaiting && data == 'T') {
      VTC = 0;
    }
    if (IsWaiting && data == 'M') {
      VTC = 1;
    }
    if (IsWaiting && data == 'L') {
      VTC = 2;
    }
    if (((data > 47 && data < 58) || data == 46) && IsWaiting) {
      StoredData[counter] = data;
      counter+=1;
    }
  }
  //UV
  analogWrite(UVWrite, UVLevels);
  //Temp
  if (DHT.read11(dht_apin) > TempAim) {
    digitalWrite(TempWrite, LOW);
  }
  else {digitalWrite(TempWrite, HIGH);}
  
  //Moist
  if (analogRead(MoistRead) < MoistAim) {
    digitalWrite(MoistWrite, HIGH);
  }
  else {digitalWrite(MoistWrite, LOW);}
  //End of feedback loop

  //Sending
  //Serial.write(';'+String(dht.temperature())+','+String(MoistRead)+';');
  Serial.print(TempAim + " and " + DHT.read11(dht_apin));
}
