using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    enum DayOfWeek { Sun=1, Mon, Tue, Wed, Thu, Fri, Sat };
    internal class Ex03_Enums
    {
        static void Main(string[] args)
        {
            DayOfWeek weekEnd = DayOfWeek.Sun;
            Console.WriteLine("THe WeekEnd is " + weekEnd);
            Console.WriteLine("THe integer value of weekEnd is: " + (int)weekEnd);

            Console.WriteLine("Enter the Start day of your Week from the list below: \n\n");
            var list = Enum.GetValues(typeof(DayOfWeek));      

            foreach (var item in list) { Console.WriteLine(item); }

            DayOfWeek startDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),Console.ReadLine());

            Console.WriteLine("The selected day is: " + startDay);


            //Method 2
            
        }
    }
}
