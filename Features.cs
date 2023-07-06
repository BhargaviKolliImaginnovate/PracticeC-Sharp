    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Features{
        class Features{
            delegate double Sum(double d);
            public static void Main(string[]args){

//lambda
                Sum dd= x => x*2;
                Console.WriteLine($"8*2={dd(8)}");


//where

                List<int> numList = new List<int>{1,2,3,4,5};
                var evenList= numList.Where(a=>a%2==0).ToList();
                foreach (var j in evenList){
                    Console.WriteLine(j);
                }


                var rangeList=numList.Where(x=>x>2||x<9).ToList();
                foreach(var r in rangeList) Console.WriteLine(r);
                

                List<int> flipList=new List<int>();
                int i=0;
                Random random=new Random();
                while(i<100){
                    flipList.Add(random.Next(1,3));
                    i++;
                }

                Console.WriteLine("Heads: {0}",flipList.Where(a=>a==1).ToList().Count);
                Console.WriteLine("Tails: {0}",flipList.Where(a=>a==2).ToList().Count);

                List<string> nameList=new List<string>{"asha","bharu","aruna","priyu"};
                var sNameList= nameList.Where(x=>x.StartsWith("a"));
                foreach(var m in sNameList)
                Console.WriteLine(m);


//select
                var oneTo10=new List<int>();
                oneTo10.AddRange(Enumerable.Range(1,10));
                var squares=oneTo10.Select(x=>x*x);
                foreach(var s in squares)
                Console.WriteLine(s);    

//Zip
                var listOne=new List<int>(new int[] {1,3,5,7,9});
                var listtwo=new List<int>(new int[] {1,3,5,7,9});
                var sumList=listOne.Zip(listtwo,(x,y)=>x+y).ToList();
                foreach(var item in sumList)
                Console.WriteLine(item);


//Aggregate
                var listThree = new List<int>(new int[] {1,2,3,4,5});
                var listFour = new List<int>(new int[] {4});

                Console.WriteLine("listThree : {0}",listThree.Aggregate((a,b)=>a+b));      

//Average
                Console.WriteLine("Average: {0}", listThree.AsQueryable().Average());    

//All
                Console.WriteLine("All > 3 : {0}",listThree.All(x=>x>3));   

//Any
                Console.WriteLine("Any > 3 :{0}",listThree.Any(x=>x>3));

//Distinct    
                Console.WriteLine("Distinct : {0}",string.Join(",", listOne.Distinct()));            

//Except
                Console.WriteLine("Except  : {0}",string.Join(",",listThree.Except(listFour)));  

//Intersect
                Console.WriteLine("Intersect : {0}",string.Join(",",listThree.Intersect(listFour)));                          
                }
        }
    }