using System;
namespace workspace{
    class MyString{

        public static void Main(string[]args){
            string sentance="this is just a word";
            Console.WriteLine($"string length : {sentance.Length}");
            Console.WriteLine($"string Contains : {sentance.Contains("is")}");
            Console.WriteLine($"string Index : {sentance.IndexOf("a")}");
            Console.WriteLine($"string remove : {sentance.Remove(10,6)}");
            Console.WriteLine($"string Insert : {sentance.Insert (13,"only")}");
            Console.WriteLine($"string replace : {sentance.Replace("word","awesome")}");
            Console.WriteLine($"string uppercase : {sentance.ToUpper()} ");
            Console.WriteLine($"string lowercase : {sentance.ToLower()} ");
            Console.WriteLine($"string trim : {sentance.Trim()} ");
            Console.WriteLine($"string PadLeft : {sentance.PadLeft(20,'.')} ");
            Console.WriteLine($"string padright : {sentance.PadRight(20,'.')} ");


            string newString= String.Format("{0} saw a {1} {2} in the {3}","joey","rabbit","eating","field");
            Console.WriteLine(newString +"\n");




        

        }
    }
}