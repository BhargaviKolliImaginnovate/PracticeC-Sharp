using System;
namespace DateTimeAndTimespan{
    class DateTimeAndTimespan{
static void Main(string[]args){
        DateTime dateTime=new DateTime(1998,04,05);
        Console.WriteLine("Day of  the week : {0}",dateTime.DayOfWeek);
        dateTime=dateTime.AddDays(18);
        dateTime=dateTime.AddYears(2);
        dateTime.AddMonths(8);
        Console.WriteLine("New Date :{0}",dateTime.Date);
        TimeSpan timeSpan=new TimeSpan(12,30,0);
        timeSpan = timeSpan.Subtract(new TimeSpan(0,15,0));
        Console.WriteLine("New Time : {0}",timeSpan.ToString());
    }
    }
}