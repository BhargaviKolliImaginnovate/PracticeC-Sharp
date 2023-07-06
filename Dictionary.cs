using System;
using System.Collections.Generic;
namespace collections{
    class Dictionaries{
        static void Main(string[]args){
            Dictionary<int,string>superheroes=new Dictionary<int, string>();
            superheroes.Add(1,"joey");
            superheroes.Add(2,"ross");
            superheroes.Add(3,"rachel");
            superheroes.Add(4,"monika");
            superheroes.Add(5,"chandler");
            superheroes.Add(6,"pheobe");

            superheroes.Remove(2);

            Console.WriteLine("count : {0}",superheroes.Count);
            Console.WriteLine("joey : {0}",superheroes.ContainsKey(8));

            superheroes.TryGetValue(1,out string test);
            Console.WriteLine($"joey : {test}");
             

             foreach(KeyValuePair<int,string> item in superheroes){
                Console.WriteLine("{0} : {1}", item.Key, item.Value);

             }

             superheroes.Clear();
        
        }

    }
}