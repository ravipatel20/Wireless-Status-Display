/*
  LiquidCrystal Library - Serial Input
 Demonstrates the use a 16x2 LCD display.  The LiquidCrystal
 library works with all LCD displays that are compatible with the
 Hitachi HD44780 driver. There are many of them out there, and you
 can usually tell them by the 16-pin interface.

 This sketch displays text sent over the serial port
 (e.g. from the Serial Monitor) on an attached LCD.

 The circuit:
 * LCD RS pin to digital pin 12
 * LCD Enable pin to digital pin 11
 * LCD D4 pin to digital pin 5
 * LCD D5 pin to digital pin 4
 * LCD D6 pin to digital pin 3
 * LCD D7 pin to digital pin 2
 * LCD R/W pin to ground
 * 10K resistor:
 * ends to +5V and ground
 * wiper to LCD VO pin (pin 3)

 Library originally added 18 Apr 2008
 by David A. Mellis
 library modified 5 Jul 2009
 by Limor Fried (http://www.ladyada.net)
 example added 9 Jul 2009
 by Tom Igoe
 modified 22 Nov 2010
 by Tom Igoe

 This example code is in the public domain.

 http://arduino.cc/en/Tutorial/LiquidCrystalSerial
 */

// include the library code:
#include <LiquidCrystal.h>

// initialize the library with the numbers of the interface pins
//LiquidCrystal lcd(10, 11, 12, 2, 3, 4, 5, 6, 7, 8, 9);
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
void setup() 
{
  pinMode(13,OUTPUT);
  digitalWrite(13, HIGH);
  // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  // initialize the serial communications:
  Serial.begin(115200);
  
}

String ch;
String ch2;
String ch3;
String ch4;

int len,i1=0;
int flag=0;
int f=0;

void normal_lec()
{
    if(flag==1)
    {      
        i1=0;
        while(i1 < 3)
        {        
          //lcd.clear();          
          lcd.setCursor(0, 0);
          lcd.print(ch);
          if(i1==0)
            delay(1000);
          
          if(ch=="-----Attention!-----")
          {
            lcd.print(ch);
            lcd.setCursor(0, 1);
            lcd.print(ch2);
          } 
          else
          {
            lcd.setCursor(5, 1);
            lcd.print(ch2);            
          }
               
          for(int pos = 0; pos < 44; pos++) 
          {
          // scroll one position left:
            lcd.scrollDisplayLeft();
            // wait a bit:
            delay(200);
          }
          i1++;
        }
        lcd.clear();
        flag=0;
     }
}

void loop()
{ 
    ch="";
    ch2="";
    lcd.clear();
  // when characters arrive over the serial port...
    while (Serial.available() && flag==0)
    {
      flag=1;
    // wait a bit for the entire message to arrive
      delay(1000);
      lcd.clear();
      ch=Serial.readStringUntil('$');
      ch2=Serial.readStringUntil('#');
      normal_lec();     
      //delay(1000);
    }
    
    lcd.clear();
   while (!Serial.available() && flag==0)
   {
     lcd.clear();
     lcd.setCursor(0, 0);
     lcd.print("einfochips Training & Research Academy");
                
     for(int pos = 0; pos < 67; pos++) 
     {
       // scroll one position left:
       lcd.scrollDisplayLeft();
       // wait a bit:
       delay(200);
     }
     
   }  
}
