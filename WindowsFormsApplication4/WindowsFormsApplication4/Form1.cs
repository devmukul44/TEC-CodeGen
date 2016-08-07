using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEC_GUI_ledMatrix;
using WindowsFormsApplication4;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string start = @"
int main(void)
{
	DDRC =0xFF;
	DDRD =0xFF;
    // This program requires D Port connected to +ve end and C Port to negetive end.
  while(1)
 {
uint8_t x=255;

";
        string end = @"
       
          } // end of while1
       }";
        string[,] a = new string[,]
            {
            {"A", @"x=255;
while(x>0)
{   PORTC =  ~(1<<1);   PORTD = (1<<0);     _delay_ms(dl);
	PORTC  = ~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	PORTC  = ~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC  = ~(1<<1); 	PORTD = (1<<3); 	_delay_ms(dl);
	PORTC  = ~(1<<1); 	PORTD = (1<<4); 	_delay_ms(dl);
	PORTC  = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC  = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC  = ~(1<<2); 	PORTD = (1<<2);   	_delay_ms(dl);
	PORTC  = ~(1<<3); 	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC  = ~(1<<3); 	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<1); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<3); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<4); 	_delay_ms(dl);
	PORTC  = ~(1<<4); 	PORTD = (1<<5); 	_delay_ms(dl);
		--x;
}"

            },
	    {"B", @"x=255;
 while(x>0)
 {   PORTC = ~(1<<1);  PORTD = (1<<0);     _delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC  = ~(1<<1); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC  = ~(1<<4); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC  = ~(1<<2); 	PORTD = (1<<0);   	_delay_ms(dl);
	 PORTC  = ~(1<<2); 	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC  = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC  = ~(1<<3); 	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC  = ~(1<<3); 	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC  = ~(1<<3); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC  = ~(1<<4); 	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC  = ~(1<<4); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC  = ~(1<<4); 	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC  = ~(1<<4); 	PORTD = (1<<5); 	_delay_ms(dl);
	 	 --x;
 }"

        },
	    {"C", @"x=255;
 while(x>0)
 {   PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);  
	 PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl);     // C
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);    _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 --x;
   }

"},
 {"D",@"x=255;
while(x>0)
{   PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);
	PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl);     // D
	PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<1);    PORTD = (1<<3);    _delay_ms(dl);
	PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<5);  	PORTD = (1<<3); 	_delay_ms(dl);
	PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	--x;
}

"},
 {"E",@" x=255;
  while(x>0)
 {                                                               // E
	 PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);
	 PORTC = ~(1<<2); 	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);   PORTD = (1<<0);     _delay_ms(dl);
	 PORTC = ~(1<<4);	PORTD = (1<<0);	    _delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	 	 --x;}	 

"},
{"F",@" x=255;
while(x>0)
{                                         
	PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<3); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<4); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<3); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
--x;}


"},
{"G",@" x=255;
while(x>0)
{   PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);
	PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl); 
	PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	--x;
}

   "},
{"H",@" x=255;
	 while(x>0)
   	{   PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);              // H
	   	PORTC = ~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);    PORTD = (1<<2);     _delay_ms(dl);
	   	PORTC = ~(1<<1);	PORTD = (1<<3);	    _delay_ms(dl);
	   	PORTC = ~(1<<1); 	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	   	--x;
    }
       
       
       "},
{"I",@" x=255;
	 while(x>0)
   	{   PORTC = ~(1<<2);	PORTD = (1<<0);	    _delay_ms(dl);              // I
	   	PORTC = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);    PORTD = (1<<0);     _delay_ms(dl);
	   	PORTC = ~(1<<4);	PORTD = (1<<6);	    _delay_ms(dl);
	   	PORTC = ~(1<<3); 	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	   	--x;
    }      
        
        
        
         "},
{"J",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<1);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<2);	PORTD = (1<<0);	    _delay_ms(dl);              // J
	   	PORTC = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);	PORTD = (1<<6);	    _delay_ms(dl);
	   	PORTC = ~(1<<3); 	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	   	--x;
    }      
        
        
        
        "},
{"K",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<2);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<2);	PORTD = (1<<2);	    _delay_ms(dl);              // K
	   	PORTC = ~(1<<2); 	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);	PORTD = (1<<4);	    _delay_ms(dl);
	   	PORTC = ~(1<<2); 	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	   	--x;
    }         
        
        
        
      "},
{"L",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<2);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<2);	PORTD = (1<<2);	    _delay_ms(dl);              // L
	   	PORTC = ~(1<<2); 	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);	PORTD = (1<<4);	    _delay_ms(dl);
	   	PORTC = ~(1<<2); 	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
	   		   	   	--x;
    }         
      
      
        
      "},
{"M",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<1);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<1);	PORTD = (1<<2);	    _delay_ms(dl);              // M
	   	PORTC = ~(1<<1); 	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	   	PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<7);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	   	--x;
    }         
        
        
        
        "},
{"N",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<1);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<1);	PORTD = (1<<2);	    _delay_ms(dl);              // N
	   	PORTC = ~(1<<1); 	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	   	PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<6);  	PORTD = (1<<6); 	_delay_ms(dl);
	   
	   	   	--x;
    }       
       
       
        "},
{"O",@" x=255;
 while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl);     // O
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 	 --x;
   }

 "},
{"P",@" x=255;
		while(x>0)
		{                                                               // P
			PORTC = ~(1<<1);  	PORTD = (1<<0); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<1); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<2); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<3); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<4); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<5); 	_delay_ms(dl);
			PORTC = ~(1<<1);  	PORTD = (1<<6); 	_delay_ms(dl);
			PORTC = ~(1<<2);  	PORTD = (1<<3); 	_delay_ms(dl);
			PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
			PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
			PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
			PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
			PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
			PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
			PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
			
		--x;}
		
       
       
  "},
{"Q",@" x=255;     
    while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl);     // Q
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
     PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 	 --x;
   }
    
    
     "},
{"R",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
        PORTC = ~(1<<2);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<2);	PORTD = (1<<2);	    _delay_ms(dl);              // R
	   	PORTC = ~(1<<2); 	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);	PORTD = (1<<4);	    _delay_ms(dl);
	   	PORTC = ~(1<<2); 	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<2);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	   		   	
	   		   	   	--x;
    }         
    
    
     "},
{"S",@" x=255;
	 while(x>0)
   	{   
        PORTC = ~(1<<2);  	PORTD = (1<<1); 	_delay_ms(dl);
        PORTC = ~(1<<2);  	PORTD = (1<<4); 	_delay_ms(dl);
        PORTC = ~(1<<2);	PORTD = (1<<5);	    _delay_ms(dl);              // S
	   	PORTC = ~(1<<3); 	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);	PORTD = (1<<3);	    _delay_ms(dl);
	   	PORTC = ~(1<<3); 	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	   		   	
	   		   	   	--x;
    }         
    
    
      "},
{"T",@" x=255;
	 while(x>0)
   	{   PORTC = ~(1<<1);	PORTD = (1<<6);	    _delay_ms(dl);              // T
	   	PORTC = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);    PORTD = (1<<6);     _delay_ms(dl);
	   	PORTC = ~(1<<4);	PORTD = (1<<6);	    _delay_ms(dl);
	   	PORTC = ~(1<<5); 	PORTD = (1<<6); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<5); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<4); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<1); 	_delay_ms(dl);
	   	PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	   	   	--x;
    }

 "},
{"U",@" x=255;
 while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<1);	    _delay_ms(dl);     // U
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
     PORTC = ~(1<<1); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 --x;
   }
    
    
 
      "},
{"V",@" x=255;
 while(x>0)
 {     
	// V
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
     PORTC = ~(1<<1); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 --x;
   }
     
    
           "},
{"W",@"x=255;
 while(x>0)
 {     
	// W
	 PORTC  =~(1<<1); 	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC  =~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC  =~(1<<1); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<3);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<4);	    _delay_ms(dl);
	 PORTC = ~(1<<1); 	PORTD = (1<<5); 	_delay_ms(dl);
     PORTC = ~(1<<1); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<6);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<7);  	PORTD = (1<<5); 	_delay_ms(dl);
     PORTC = ~(1<<7);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 --x;
   }
    
   
        "},
{"X",@"x=255;
 while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);     // X
	 PORTC  =~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<5);     _delay_ms(dl);
	 PORTC = ~(1<<1);	PORTD = (1<<6);	    _delay_ms(dl);
	 PORTC = ~(1<<2); 	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<2); 	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<1); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 	 --x;
   }
   
   
           "},
{"Y",@" x=255;
 while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<5);	    _delay_ms(dl);     // Y
	 PORTC  =~(1<<1); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<2);   PORTD = (1<<4);     _delay_ms(dl);
	 PORTC = ~(1<<3);	PORTD = (1<<0);	    _delay_ms(dl);
	 PORTC = ~(1<<3); 	PORTD = (1<<1); 	_delay_ms(dl);
     	 PORTC = ~(1<<3); 	PORTD = (1<<2); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 	 	 --x;
   }
   

"},
{"Z",@"x=255;
 while(x>0)
 {     
	 PORTC = ~(1<<1);	PORTD = (1<<0);	    _delay_ms(dl);     // Z
	 PORTC  =~(1<<1); 	PORTD = (1<<1); 	_delay_ms(dl);
	 PORTC = ~(1<<1);   PORTD = (1<<6);     _delay_ms(dl);
	 PORTC = ~(1<<2);	PORTD = (1<<0);	    _delay_ms(dl);
	 PORTC = ~(1<<2); 	PORTD = (1<<2); 	_delay_ms(dl);
     PORTC = ~(1<<2); 	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<3); 	_delay_ms(dl);
	 PORTC = ~(1<<3);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<0); 	_delay_ms(dl);
	 PORTC = ~(1<<4);  	PORTD = (1<<4); 	_delay_ms(dl);
     PORTC = ~(1<<4);  	PORTD = (1<<6); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<0); 	_delay_ms(dl);
     PORTC = ~(1<<5);  	PORTD = (1<<5); 	_delay_ms(dl);
	 PORTC = ~(1<<5);  	PORTD = (1<<6); 	_delay_ms(dl);
	 	 	 --x;
   }
   
       
          "},
	    
            };

        public Form1()
        {
            //this.Load += Form1_Load;
            //Thread t = new Thread(new ThreadStart(SplashStart));
            //t.Start();
            //Thread.Sleep(999999);
            InitializeComponent();
        }
        /*public void SplashStart()
        {
            Application.Run(new Form3());
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            /*TEC_GUI_ledMatrix.Form2 myForm2 = new TEC_GUI_ledMatrix.Form2();
            myForm2.Show();

            TEC_GUI_ledMatrix.Form3 myForm3 = new TEC_GUI_ledMatrix.Form3();
            myForm3.Show();

            //this.Hide();
        */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                for (int i = 0; i < 26; i++)
                {
                    if (a[i, 0] == textBox1.Text)
                    {
                        richTextBox1.Text = start;
                        richTextBox1.Text = richTextBox1.Text + a[i, 1];
                        richTextBox1.Text = richTextBox1.Text + end;
                        //MessageBox.Show(a[i, 1]);
                    }
                }
                MessageBox.Show(richTextBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                char[] ch = (textBox2.Text).ToCharArray();
                //textBox3.Text = "";
                richTextBox1.Text =start;
                for (int i = 0; i < ch.Length; i++)
                {
                    for (int j = 0; j < 26; j++)
                    {

                        if (ch[i] == Convert.ToChar(a[j, 0]))
                        {
                            richTextBox1.Text = richTextBox1.Text + a[j, 1];
                            //MessageBox.Show(textBox3.Text);
                        }
                    }

                }
                richTextBox1.Text = richTextBox1.Text + end;
                richTextBox1.Enabled = false;
                MessageBox.Show(richTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index myForm2 = new index();
            myForm2.Show();
            this.Hide();
        }

        private void univeralGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
            this.Hide();
        }
    }
}
