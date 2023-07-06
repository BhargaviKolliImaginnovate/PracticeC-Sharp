using System;
namespace ArraysExample{

    class ArraysExample{
        public static void Main(string[]args){
            int[] nums=new int[2];
            nums[1]=10;
            Console.WriteLine(nums[1]);

            // string[] users = {"boby","rachel","ross"};

            // var emp= new [] {"swathi","ramesh","sai"};

            Object[] randomValues={"bharu",12.34,7};
            Console.WriteLine(randomValues[1].GetType() +"," +randomValues.Length);

            int[] a=new int[5];
            for(int i=0; i<5;i++){
               Console.ReadLine();
            }
            for(int i=0; i<5; i++){
                Console.WriteLine(a[i]);
            }

        }
    }

}