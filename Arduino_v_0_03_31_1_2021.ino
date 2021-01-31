
// Teploměr a vlhkoměr DHT11/22
#include "DHT.h"  // připojení knihovny DHT
#define pinDHT 53 // nastavení čísla pinu s připojeným DHT senzorem
#define typDHT11 DHT11 // definování typu čidla DHT 11
DHT mojeDHT(pinDHT, typDHT11); // inicializace DHT senzoru s nastaveným pinem a typem senzoru

float tep; // teplota
float vlh; // vlhkost

// Kody SVETLA prichazejici z Mistie
    // 
    //  0 - SvetloLustrPracovna - OFF
    //  1 - SvetloLustrPracovna - ON
    //  2 - SvetloLustrCHodba - OFF
    //  3 - SvetloLustrCHodba - ON
    //  4 - SvetloLustrWC - OFF
    //  5 - SvetloLustrWC - ON
    //  6 - SvetloLustrKoupelna - OFF
    //  7 - SvetloLustrKoupelna - ON
    //  8 - SvetloLustrKuchyn - OFF
    //  9 - SvetloLustrKuchyn - ON
    //  a - SvetloLustrObyvak - OFF
    //  b - SvetloLustrObyvak - ON
    //  c - SvetloLustrLoznice - OFF
    //  d - SvetloLustrLoznice - ON

          // ------------------------
    
    //  e - SvetloLampaLoznice - OFF
    //  f - SvetloLampaLoznice - ON
    //  g - SvetloLampaObyvak - OFF
    //  h - SvetloLampaObyvak - ON   
    //  i - SvetloLedKuchyn - OFF
    //  j - SvetloLedKuchyn - ON    
    //  k - SvetloDekoraceLoznice - OFF
    //  l - SvetloDekoraceLoznice - ON
    //  m - SvetloDekoraceObyvak - OFF
    //  n - SvetloDekoraceObyvak - ON    
    //  o - SvetloDekoracePracovna - OFF
    //  p - SvetloDekoracePracovna - ON
    
    //  q - LustrPracovna - ON/OFF
    //  r - LustrChodba - ON/OFF
    //  s - LustrWc - ON/OFF
    //  t - LustrKoupelna - ON/OFF
    //  u - LustrKuchyn - ON/OFF
    //  v - LustrObyvak - ON/OFF
    //  w - LustrLoznice - ON/OFF
    
    //  x - LedKuchyn - ON/OFF
    //  y - LampaObyvak - ON/OFF
    //  z - LampaLoznice - ON/OFF


    // A - DekoracePracovna - ON/OFF
    // B - DekoraceObyvak - ON/OFF  
    // C - DekoraceLoznice - ON/OFF  
    // D - 






// VYPINACE

int vypinacPracovnaStrop = 22;
int vypinacChodbaStrop = 23;
int vypinacWcStrop = 24;
int vypinacKoupelnaStrop = 25;
int vypinacObyvakStrop = 26;
int vypinacKuchynStrop = 27;
int vypinacLozniceStrop = 28;

// RELE

int relePracovnaStrop = 29;
int releChodbaStrop = 30;
int releWCStrop = 31;
int releKoupelnaStrop = 32;
int releObyvakStrop = 33;
int releKuchynStrop = 34;
int releLozniceStrop = 35;

// BOOLS

bool svetloObyvakStrop = false;
bool svetloKuchynStrop = false;
bool svetloChodbaStrop = false;
bool svetloWCStrop = false;
bool svetloKoupelnaStrop = false;
bool svetloPracovnaStrop = false;
bool svetloLozniceStrop = false;

bool PIRChodbaAktivni = false;

// PIR CIDLA

int MagnetDvereChodba = 46;
int PIRChodba = 47;
int PIRPracovna = 48;
int PIRObyvak = 49;


// Hodnoty

int timerPohyb = 0;
int timerTeplota = 0;

char ZpravaMistie;

void setup() {
  Serial.begin(9600); // komunikace přes sériovou linku rychlostí 9600 baud

  // Teploměr, vlhkoměr
  mojeDHT.begin(); // zapnutí komunikace s teploměrem DHT
  
  // Vypinac
  pinMode(vypinacPracovnaStrop, INPUT_PULLUP); // PULLUP - aktivace rezistoru
  pinMode(vypinacChodbaStrop, INPUT_PULLUP);
  pinMode(vypinacWcStrop, INPUT_PULLUP);
  pinMode(vypinacKoupelnaStrop, INPUT_PULLUP);
  pinMode(vypinacKuchynStrop, INPUT_PULLUP);
  pinMode(vypinacObyvakStrop, INPUT_PULLUP);
  pinMode(vypinacLozniceStrop, INPUT_PULLUP);

  // RELE
  pinMode(relePracovnaStrop, OUTPUT);
  pinMode(releChodbaStrop, OUTPUT);
  pinMode(releWCStrop, OUTPUT);
  pinMode(releKoupelnaStrop, OUTPUT);
  pinMode(releKuchynStrop, OUTPUT);
  pinMode(releObyvakStrop, OUTPUT);
  pinMode(releLozniceStrop, OUTPUT);

  // PIR a MAGNET CIDLA
  pinMode(MagnetDvereChodba, INPUT_PULLUP);
  pinMode(PIRChodba, INPUT_PULLUP);

  digitalWrite(relePracovnaStrop, HIGH);    
  digitalWrite(releChodbaStrop, HIGH);
  digitalWrite(releWCStrop, HIGH);
  digitalWrite(releKoupelnaStrop, HIGH);  
  digitalWrite(releKuchynStrop, HIGH);   
  digitalWrite(releObyvakStrop, HIGH);  
  digitalWrite(releLozniceStrop, HIGH);

}

// VOID SVETLA    VOID SVETLA

void SvetlaVypinac(){

  // Pracovna
  if(digitalRead(vypinacPracovnaStrop) == 0)
  {
    SvetloPracovnaStropAuto();
  }

  // Chodba
  if(digitalRead(vypinacChodbaStrop) == 0)
  {
    SvetloChodbaStropAuto();
  }

  // WC
  if(digitalRead(vypinacWcStrop) == 0)
  {
    SvetloWcStropAuto();
  }

  // Koupelna
  if(digitalRead(vypinacKoupelnaStrop) == 0)
  {
    SvetloKoupelnaStropAuto();
  }

  // Kuchyn
  if(digitalRead(vypinacKuchynStrop) == 0)
  {
    SvetloKuchynStropAuto();
  }

  // Obyvak
  if(digitalRead(vypinacObyvakStrop) == 0)
  {
    SvetloObyvakStropAuto();
  }

  // Loznice
  if(digitalRead(vypinacLozniceStrop) == 0)
  {
    SvetloLozniceStropAuto();
  }
}

void CteniMistie(){

  if(Serial.available() > 0){
    
  ZpravaMistie = Serial.read();
  
  switch(ZpravaMistie){
     case '0':
      digitalWrite(relePracovnaStrop, HIGH);
      svetloPracovnaStrop = false;
      break;
     case '1':
      digitalWrite(relePracovnaStrop, LOW);
      svetloPracovnaStrop = true;
      break;
     case '2':
      digitalWrite(releChodbaStrop, HIGH);
      svetloChodbaStrop = false;
      break;
     case '3':
      digitalWrite(releChodbaStrop, LOW);
      svetloChodbaStrop = true;
      break;
     case '4':
      digitalWrite(releWCStrop, HIGH);
      svetloWCStrop = false;
      break;
     case '5':
      digitalWrite(releWCStrop, LOW);
      svetloWCStrop = true;
      break;
     case '6':
      digitalWrite(releKoupelnaStrop, HIGH);
      svetloKoupelnaStrop = false;
      break;
     case '7':
      digitalWrite(releKoupelnaStrop, LOW);
      svetloKoupelnaStrop = true;
      break;
     case '8':
      digitalWrite(releKuchynStrop, HIGH);
      svetloKuchynStrop = false;
      break;
     case '9':
      digitalWrite(releKuchynStrop, LOW);
      svetloKuchynStrop = true;
      break;
     case 'a':
      digitalWrite(releObyvakStrop, HIGH);
      svetloObyvakStrop = false;
      break;
     case 'b':
      digitalWrite(releObyvakStrop, LOW);
      svetloObyvakStrop = true;
      break;
     case 'c':
      digitalWrite(releLozniceStrop, HIGH);
      svetloLozniceStrop = false;
      break;
     case 'd':
      digitalWrite(releLozniceStrop, LOW);
      svetloLozniceStrop = true;
      break;
     case 'q':
      SvetloPracovnaStropAuto();
      break;
     case 'r':
      SvetloChodbaStropAuto();
      break;
     case 's':
      SvetloWcStropAuto();
      break;
     case 't':
      SvetloKoupelnaStropAuto();
      break;
     case 'u':
      SvetloKuchynStropAuto();
      break;
     case 'v':
      SvetloObyvakStropAuto();
      break;
     case 'w':
      SvetloLozniceStropAuto();
      break;
    }
  }
}


// VOID PIR CIDLA

void PIRCidla(){

  if(!PIRChodbaAktivni){
    
    // MagnetDvere
    if(digitalRead(MagnetDvereChodba) == 1)
    {
     Serial.println("pmagnet"); // aktivováno Magnetické čidlo Dveře
      PIRChodbaAktivni = true;
    } 

     PIR Chodba
    if(digitalRead(PIRChodba) == 1)
    {
     Serial.println("pchodba"); // aktivováno PIR čidlo chodba
      PIRChodbaAktivni = true;
    }    
  }
  else{
    timerPohyb++;
    if(timerPohyb == 100){
      timerPohyb = 0;
      PIRChodbaAktivni = false;
    }
  }
}

// METODY PRO VYPINAC a Mistie singl povely svetel

void SvetloPracovnaStropAuto(){
  
  if(svetloPracovnaStrop == false)
    {
      Serial.println("svetloPracovnaStrop Rozsvicuji");
      digitalWrite(relePracovnaStrop, LOW);
      svetloPracovnaStrop = true;
    }
    else
    {
      Serial.println("svetloPracovnaStrop Zhasínám");
      digitalWrite(relePracovnaStrop, HIGH);
      svetloPracovnaStrop = false;
    }
    delay(400);  
}
void SvetloChodbaStropAuto(){
  if(svetloChodbaStrop == false)
    {
      Serial.println("svetloChodbaStrop Rozsvicuji");
      digitalWrite(releChodbaStrop, LOW);
      svetloChodbaStrop = true;
    }
    else
    {
      Serial.println("svetloChodbaStrop Zhasínám");
      digitalWrite(releChodbaStrop, HIGH);
      svetloChodbaStrop = false;
    }
    delay(400);  
}
void SvetloWcStropAuto(){
  if(svetloWCStrop == false)
    {
      Serial.println("svetloWCStrop Rozsvicuji");
      digitalWrite(releWCStrop, LOW);
      svetloWCStrop = true;
    }
    else
    {
      Serial.println("svetloWCStrop Zhasínám");
      digitalWrite(releWCStrop, HIGH);
      svetloWCStrop = false;
    }
    delay(400);  
}
void SvetloKoupelnaStropAuto(){
  if(svetloKoupelnaStrop == false)
    {
      Serial.println("svetloKoupelnaStrop Rozsvicuji");
      digitalWrite(releKoupelnaStrop, LOW);
      svetloKoupelnaStrop = true;
    }
    else
    {
      Serial.println("svetloKoupelnaStrop Zhasínám");
      digitalWrite(releKoupelnaStrop, HIGH);
      svetloKoupelnaStrop = false;
    }
    delay(400);  
}
void SvetloKuchynStropAuto(){
  if(svetloKuchynStrop == false)
    {
      Serial.println("svetloKuchynStrop Rozsvicuji");
      digitalWrite(releKuchynStrop, LOW);
      svetloKuchynStrop = true;
    }
    else
    {
      Serial.println("svetloKuchynStrop Zhasínám");
      digitalWrite(releKuchynStrop, HIGH);
      svetloKuchynStrop = false;
    }
    delay(400);  
}
void SvetloObyvakStropAuto(){
  if(svetloObyvakStrop == false)
    {
      Serial.println("svetloObyvakStrop Rozsvicuji");
      digitalWrite(releObyvakStrop, LOW);
      svetloObyvakStrop = true;
    }
    else
    {
      Serial.println("svetloObyvakStrop Zhasínám");
      digitalWrite(releObyvakStrop, HIGH);
      svetloObyvakStrop = false;
    }
    delay(400);  
}
void SvetloLozniceStropAuto(){
  if(svetloLozniceStrop == false)
    {
      Serial.println("svetloLozniceStrop Rozsvicuji");
      digitalWrite(releLozniceStrop, LOW);
      svetloLozniceStrop = true;
    }
    else
    {
      Serial.println("svetloLozniceStrop Zhasínám");
      digitalWrite(releLozniceStrop, HIGH);
      svetloLozniceStrop = false;
    }
    delay(400);  
}

void Teplomer(){
  
  if(timerTeplota == 250){
    tep = mojeDHT.readTemperature();
    vlh = mojeDHT.readHumidity();
    // kontrola, jestli jsou načtené hodnoty čísla pomocí funkce isnan
    if (isnan(tep) || isnan(vlh)) {
     // při chybném čtení vypiš hlášku
      Serial.println("Chyba při čtení z DHT senzoru!");
    } else {
      // pokud jsou hodnoty v pořádku, vypiš je po sériové lince
      Serial.print("t"+String(tep));
      Serial.println("v"+String(vlh));
  }
   timerTeplota = 0;
    
  }else{
    timerTeplota++;
  }
}



void loop() {
  
  SvetlaVypinac();
  CteniMistie();
  PIRCidla();
  Teplomer();
  delay(20);

}
