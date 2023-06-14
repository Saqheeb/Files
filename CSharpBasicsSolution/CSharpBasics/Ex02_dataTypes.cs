using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex02_dataTypes
    {
        static void Main(string[] args)
        {
            //inputAndDisplay();
            //displayRange();
            //dataConvertion();
            //dateTimeExamples();
            //getDateAndDisplay();
            //getTimeAndDisplay();
            test();
        }

        private static void getTimeAndDisplay()
        {
            Console.WriteLine("Enter the Time of Arrival as hh:mm:ss");

            DateTime time = DateTime.Parse(Console.ReadLine()); 
            Console.WriteLine("The time entered is: "+time.ToLongTimeString());   
        }

        private static void getDateAndDisplay()
        {
            Console.WriteLine("Enter the date of join in the format of dd-MM-yyyy");
            DateTime doJ = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The date of join is: " + doJ.ToLongDateString());
        }

        private static void dateTimeExamples()
        {
            var date = DateTime.Now;

            Console.WriteLine("The current date and time is: " + date);
            Console.WriteLine("The current Year is: " + date.Year);
            Console.WriteLine("The current month is: " + date.Month);
            Console.WriteLine("The current day is: " + date.Day);
            Console.WriteLine("The long Date format: " + date.ToLongDateString());
            Console.WriteLine("The Short Date format: " + date.ToShortDateString());
            Console.WriteLine("The Custom Date format: " + date.ToString("dd-MM-yy"));
            Console.WriteLine("The Custom Date format: " + date.ToString("dd-MMM-yyy"));
            Console.WriteLine("The Custom Date format: " + date.ToString("d-MMM-yyyy"));
            Console.WriteLine("The Custom Date format: " + date.ToString("d-MMMM-yyyyy"));
            Console.WriteLine("The Custom Date format: " + date.ToString("dddd-MMMM-yyyyy"));
        }

        private static void dataConvertion()
        {
            int iVal = 25;
            float fVal = iVal;

            iVal = (int)fVal;

            Console.WriteLine(fVal);
            Console.WriteLine(iVal);

        }

        private static void displayRange()
        {
            Console.WriteLine($"Range of sByte is: {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"Range of short is: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"Range of int is: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Range of long is: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"Range of ubyte is: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"Range of ushort is: {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"Range of uint is: {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"Range of ulong is: {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"Range of float is: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Range of double is: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Range of decimal is: {decimal.MinValue} to {decimal.MaxValue}");
        }

        static void inputAndDisplay()
        {
            Console.WriteLine("Enter your Name:");
            string inputName = Console.ReadLine();
            string[] name = inputName.Split(' ');

            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Organisation name:");
            string orgName = Console.ReadLine();

            Console.WriteLine($"Mr.{name[1]} is of age {age} and works in {orgName}");
            Console.WriteLine($"\nWith this information we assume that he was bron in the year {DateTime.Now.Year - (age)}");
        }

        static void test()
        {
            var currDate = DateTime.Now;
            var currDateString = currDate.ToString();
            string[] currdateArr = currDateString.Split(' ');
            //Console.WriteLine(string.Join(",", currdateArr));----> 3 / 21 / 2023,4:16:06,PM
            string[] dateArr = currdateArr[0].Split('/');
            Console.WriteLine(string.Join("/", dateArr));
            string date = string.Join("/", dateArr);
            string[] timeArr = currdateArr[1].Split(':');
            Console.WriteLine(string.Join(":", timeArr));
            string time = string.Join(":", timeArr);
            Console.WriteLine(currdateArr.Length);
            Console.WriteLine(date);
            Console.WriteLine(time);
        }
    }
}
