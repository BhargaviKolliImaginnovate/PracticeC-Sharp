using System;
namespace Practice{
    class Methods{

        static string personName(string name){
            Console.WriteLine(name);
            return "name";
        }
        static void myMethod(){
            Console.WriteLine("Executed");
        }


        static int addNumbers(int a, int b){
            return a+b;
        }
        //overloading
        static int addNumbers(int x, float y){
            Console.WriteLine(x+y);
            return 0;
        }
       

        //out parameter

        static void multiple(int x, out int sol ){

            sol=x*2;

        }

        //pass By Reference
        static void swap(ref int num1, ref int num2){
         int   temp=num1;
         num1=num2;
         num2=temp;

        
        }

       

        static void Main(string[]args){
            myMethod();
            Console.WriteLine(addNumbers(2,4));
            personName("bharu");
            addNumbers(2,2.3f);

            int sol;
            multiple(15,out sol);
            Console.WriteLine("13*3={0}",sol);


            int num3=10;
            int num4=20;

            Console.WriteLine("Before swap: num1: {0}  \n   num2: {1}",num3,num4);
            swap(ref num3 , ref num4);

        }
    }
}