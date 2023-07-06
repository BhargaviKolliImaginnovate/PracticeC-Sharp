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
}