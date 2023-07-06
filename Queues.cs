using System;
using System.Collections;
using System.Collections.Generic;

namespace collections{
    class Queueex{

        public static void Main(string[]args){
            Queue queue=new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("1 in queue : {0}",queue.Contains(1));
            Console.WriteLine("Remove : {0}",queue.Dequeue());
            Console.WriteLine("peek 1 : {0}",queue.Peek());

            object[] numArray =queue.ToArray();
            Console.WriteLine(string.Join("",numArray));
             
             foreach (object o in queue){
                Console.WriteLine($"Queue : {o}");
             }



queue.Clear();


        }
    }
}