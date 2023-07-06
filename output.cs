using System;
namespace MyCode{

    class Output{
static void Main(string[] args){

Console.WriteLine("Biggest Integer value: {0}", int.MaxValue);
Console.WriteLine("smallest Integer value: {0}", int.MinValue);

Console.WriteLine("Biggest Long value: {0}", long.MaxValue);
Console.WriteLine("smallest Long value: {0}", long.MinValue);

decimal decPiVal=3.1415926535897932384626433832M;
decimal decBigNum=3.00000000000000000000000000011M;
Console.WriteLine("Dec : PI + bigNum = {0}", decPiVal+decBigNum);

Console.WriteLine("Biggest decimal value: {0}", decimal.MaxValue);
Console.WriteLine("smallest decimal value: {0}", decimal.MinValue);


    Console.Write(" its working! ");
    Console.Write("..Hi,I am write..");
}

    }
}