using System;
using System.Collections;
using System.Collections.Generic;
namespace collections{
    class Stackex{
    static void Main(string[]args){
        Stack stack=new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);



Console.WriteLine(stack.ToString());

Console.WriteLine("peek 1 : {0}",stack.Peek());
Console.WriteLine("pop 1 : {0}",stack.Pop());
Console.WriteLine("contains 1 : {0}",stack.Contains(3));
    object[] numArray = stack.ToArray();

    Console.WriteLine(String.Join(",",numArray));

    foreach(object o in numArray){
        Console.WriteLine($"Stack: {o}");
    }

    }
}
}