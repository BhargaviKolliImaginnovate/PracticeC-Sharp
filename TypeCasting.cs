using System;
namespace casting{
    class TypeCasting{
        static void Main(string[]args){

            /*  **Implicit Casting**
    char -> int -> long -> float -> double   */

            int num=8;
            double d=num;      // Automatic casting: int to double
                Console.WriteLine(d);


                /* Explicit Casting**
                double -> float -> long -> int -> char */

                double d1=12.34d;
                int num1=(int)d1;

                Console.WriteLine(num1);
        }
    }
}