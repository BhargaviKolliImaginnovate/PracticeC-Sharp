using System;
using System.Globalization;
using System.Text;

namespace builders{
    class Builder{
        public static void Main(string[]args){

            StringBuilder sb1=new StringBuilder("Random Test  ");
            StringBuilder sb2=new StringBuilder("This text is more important  ");

            Console.WriteLine("capacity: {0} ",sb1.Capacity);
            Console.WriteLine("length: {0} ",sb2.Length);

            sb2.AppendLine("\n more important ");
            CultureInfo enUS=CultureInfo.CreateSpecificCulture("en-US");

            string bestCust="Bob smith";
            sb2.AppendFormat(enUS," Best Customer: {0}",bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text","character");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random text");
            Console.WriteLine(sb1.Equals(sb2));
            sb2.Insert(11," thats greate working bee");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11,7);
            Console.WriteLine(sb2.ToString());



        }
    }
}