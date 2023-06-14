using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasics
{
    internal class MyConsole
    {
        public static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();  
        }
        public static int getNumber(string number)
        {
            return int.Parse(Console.ReadLine());
        }
        public static long getDouble(string question)
        {
            Console.WriteLine(question);
            return long.Parse(Console.ReadLine());
        }
        public DateTime getDate(string date)
        {
            Console.WriteLine("Enter the date in dd/mm/yyy format: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static long getLong(string longNumber)
        {
            return long.Parse(Console.ReadLine());
        }
    }
}
