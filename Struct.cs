using System;
using Solution;
namespace Solution{

    public class ShapeMaths{

      public  static double getArea(string shape="" ,
      double length=0,
      double length2=0){

        if(string.Equals("Rectangle",shape,StringComparison.OrdinalIgnoreCase)){

          return length*length2;

        }

        else if(string.Equals("Triangle",shape,StringComparison.OrdinalIgnoreCase)){
           return length * (length2/2);
        }
        else if(string.Equals("Circle",shape,StringComparison.OrdinalIgnoreCase)){
          return Math.PI*Math.Pow(length,2);

        }
else{
  return -1;
}
      
      }
      
    }

    class ShapeMath{

public static void Main(string[]args){

Rectangle rectangle1;
rectangle1.length=200;
rectangle1.width=50;
Console.WriteLine(" Area  of rectangle : {0}", rectangle1.Area());

Rectangle rectangle2=new Rectangle(60,10);
rectangle2=rectangle1;
rectangle1.length=150;

Console.WriteLine(" Rectangle2 length : {0}",rectangle2.length);


// Console.WriteLine("Area of rectangle: {0}", ShapeMaths.getArea("Rectangle",6,4));

}

struct Rectangle
{
  public double length;
  public double width;

public Rectangle(double l =1, double w=3){ length=l;   width =w;}

public double Area(){
  return length*width;
}

}


   }
}
