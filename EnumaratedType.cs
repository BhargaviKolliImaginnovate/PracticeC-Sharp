using System;
namespace Car{
    class Car{

        static void carColor(ColorCar cc){

            Console.WriteLine("the car is painted with {0} color with code {1}", cc , (int)cc);

        }
            enum ColorCar : byte{
                Red=0,
                Green,
                Blue,
                Yellow
            }
            
        public static void Main(string[]args){
 
       ColorCar car=ColorCar.Yellow;
          carColor (car);

        }
    }
}