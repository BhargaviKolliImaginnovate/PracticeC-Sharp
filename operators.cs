using System;

namespace MyApplication
{
  class Operators
  {
    static void Main(string[] args)
    {

     //Arithmatic (+,-,*,/,%,++,--)
      int x = 100 + 50; 
      Console.WriteLine(x);  

      //Assignment (=,+=,-=,*=,/=,%=,&=,|=,^=,>>=,<<=)
      int y = 10;
      y += 5;
      Console.WriteLine(y);  

      //Comparison (==,!=,>,<,>=,<=)
      int a=10,b=20;
      Console.WriteLine(a<b);

      //Logical (&&,||,!)
      Console.WriteLine(a<b && x>y);
     }
  }
}
