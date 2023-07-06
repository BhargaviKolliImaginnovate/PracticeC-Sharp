using System;
namespace Handling{

class ExceptionHandling{

static double DoDivision(double x, double y){
    if(y==0){
        throw new System.DivideByZeroException();
    }
    return x/y;
}
static void Main(string[]args){

double d1=5;
double d2=0;

try{
    Console.WriteLine("5/0={0}", DoDivision(d1,d2));
}
catch(DivideByZeroException ex){
    Console.WriteLine("you can't divide by zero ");
    Console.WriteLine(ex.GetType().Name); 
    Console.WriteLine(ex.Message);
}
catch(Exception ex){

Console.WriteLine("An error occured");
Console.WriteLine(ex.GetType().Name);
Console.WriteLine(ex.Message);

}
finally{
    Console.WriteLine("Cleaning up");
}

}
}
}