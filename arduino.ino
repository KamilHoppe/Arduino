#include <dht.h>
#define trigPin 11
#define echoPin 12
#define dht_apin A2 // Analog Pin sensor is connected to
dht DHT;
 
 void setup(){
 
  Serial.begin(9600);
  pinMode(trigPin, OUTPUT); //Pin, do ktĂłrego podĹ‚Ä…czymy trig jako wyjĹ›cie
  pinMode(echoPin, INPUT); //a echo, jako wejĹ›cie
  delay(500);//Delay to let system boot
 
}
 
void loop(){
 
  //Start of Program 
 


 long czas, dystans;
 
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
 
  czas = pulseIn(echoPin, HIGH);
  dystans = czas / 58;

  Serial.print(dystans);
  Serial.print(",");
  DHT.read11(dht_apin);
  Serial.print(DHT.temperature); 
  Serial.println();
   
  

   
 
  delay(500);
 
  
 
}

