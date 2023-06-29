using System;
namespace names{
    class Identity{
      public static void Main(string[]args){
            string name1="asha";
            string name2="bharu";


    
            Console.WriteLine(name1.length);
            Console.WriteLine(name2.ToUpper());
            Console.WriteLine(name1+name2);
            string name3=string.Concat(name1,name2);
            string name4=name1.Replace("asha","AshaHemalatha"); 



string greeting = "      Hello World!       ";
Console.WriteLine($"***{greeting}***");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
      }
    }
}