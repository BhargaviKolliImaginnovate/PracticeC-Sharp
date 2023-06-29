using System;

namespace varTypes
{

class program
{


static void Main(string[]args)
{

//variables
 
 int a=10;
 string name="bharu";
 char c='A';
 double d=10.23;
 bool b=true;
 float f=10.23f;


 


  Console.WriteLine(c);
  Console.WriteLine(d);
  Console.WriteLine(b);
  Console.WriteLine(f);

 
 int num;
 num=12;
 num=23; //num is now 23
 
 Console.WriteLine(num);
 
 //Constants
 
 const char ch='b';
 //ch='c';   //Error will come..
 Console.WriteLine(ch);
 
 //Display Variables   (+) sign
  Console.WriteLine(name +" "  +a);  

  //Multiple variables
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);


}

}

}