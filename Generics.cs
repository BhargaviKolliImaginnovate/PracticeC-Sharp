using System;
using System.Collections.Generic;

namespace Generics{
    class Animal{
     public  string Name{get; set;}
     public Animal(string name ="no name"){
        Name=name;
     }
     public static void getSum<T>(ref T num1, ref T num2){
        double dd1=Convert.ToDouble(num1);
        double dd2=Convert.ToDouble(num2);

        Console.WriteLine($"{dd1} + {dd2} = {dd1+dd2}");

     }

        }

        public class test{
            public static void Main(string[]args){
             List<Animal>animals=new List<Animal>();

                List<int> list=new List<int>();
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
    
               

                animals.Add(new Animal(){Name= "jonny"});

                animals.Add(new Animal(){Name = "blacky"});

                animals.Add(new Animal(){Name = "lucky"});

                animals.Add(new Animal(){Name = "sweety"});

                animals.Insert(5,new Animal(){Name = "browny"});
                // animals.RemoveAt(5);
                Console.WriteLine("number of animals : {0}", animals.Count);

                foreach(Animal a in animals){
                    Console.WriteLine(a.Name);
                }

                // int x=5, y=9;
                // Animal.getSum<int>(ref x, ref y);
                
                // string strx="5", stry="9";
                // Animal.getSum<string>(ref strx, ref stry);
                


            }
        }
    }
