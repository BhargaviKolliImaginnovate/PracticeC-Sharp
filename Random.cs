using System;

namespace Randomex{
    class Randomex{
        public static void Main(string[]args){
            Random random= new Random();
            int secreateNumebr=random.Next(1,11);
            int numberGussed =0;
            Console.WriteLine("Randam Number : ", secreateNumebr);

            do{
                Console.WriteLine("Enter a number between 1 to 10: ");
                numberGussed=Convert.ToInt32(Console.ReadLine());
            }while(secreateNumebr!=numberGussed);

            Console.WriteLine("hurreyy.... you gussed it..");
        }

    }
}