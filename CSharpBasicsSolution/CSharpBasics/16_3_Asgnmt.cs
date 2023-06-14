using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasics
{
    internal class _16_3_Asgnmt
    {
        static void Main(string[] args)
        {

            //Problem 1:
            /*Console.WriteLine("Enter the number of values to be entered: ");
            int num = Convert.ToInt32(Console.ReadLine()); 

            int[] val = new int[num];
            oddEven(val);*/


            //Problem 2:
            //mathCalc();


            //Problem 3:
            arrayDisplay();


            //problem 4
            /*Console.WriteLine("Enter the date in dd,mm,yyyy format!!!");
            int d  = Convert.ToInt32(Console.ReadLine()); 
            int m  = Convert.ToInt32(Console.ReadLine()); 
            int y  = Convert.ToInt32(Console.ReadLine());
            if (date(d, m, y) == true)
                Console.WriteLine("Valid Date!!!");
            else Console.WriteLine("Invalid Date!!!");*/
        }

        private static void arrayDisplay()
        {

        }

        private static void oddEven(int[] val)
        {
            int i = 0;
            int j = 0;

            int[] even = new int[val.Length];
            int[] odd = new int[val.Length];
            foreach (var num in val)
            {

                if (num % 2 == 0)
                    even[i] = num;
                else 
                    even[j] = num;
                
            }

            Console.WriteLine("Even numebers: ");
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Even numebers: ");
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
        }

        private static void mathCalc()
        {
            while (true)
            {
                Console.WriteLine("Enter the 2 operands for computing: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select the choice for operation to be done:" +
                    "a.Additon\nb.Subtraction\nc.Multiplication\nd.Division");

                char choice = Convert.ToChar(Console.ReadLine());

                if(choice == 'a')
                    Console.WriteLine($"The sum of two is: { a + b}");
                if(choice == 'b')
                    Console.WriteLine($"The difference of two is: { a - b}");
                if (choice == 'c')
                    Console.WriteLine($"The product of two is: {a * b}");
                if (choice == 'd')
                    Console.WriteLine($"The division of two is: {a / b}");


                Console.WriteLine("Press 1 for exit or anyother to continue");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                    break;
            }
        }

        private static bool date(int d, int m, int y)
        {
            int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mdays;
            //year
            if (y < 2000 || y > 2018) 
                return false;
            
            //month
            if(m<1 ||  m>12) 
                return false;
            else
            {
                if (m == 2)
                {
                    if (m % 400 == 0)
                        if (m % 100 != 0)
                            mdays = 29;
                    if (m % 4 == 0)
                        mdays = 29;
                    else
                        mdays = 28;
                }
            }
            
            //day
            if(d <1 || d > month[m-1]) 
                return false;

            return true;

        }
    }
}
