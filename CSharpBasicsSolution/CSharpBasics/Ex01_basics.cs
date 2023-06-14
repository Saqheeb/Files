using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasics
{
    internal class Ex01_basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Saqheeb Mohammed");
            Console.WriteLine("How does it feel to be an employee of Fidelity National Financial India - Application Data Managment");
            Console.WriteLine("Enter your name and age: ");

            var inputName = Console.ReadLine();
            var age= Console.ReadLine();

            String[] name = inputName.Split(' ');
            
            Console.WriteLine($"Your name is {name[1]}\nYour age is {age}" );
        }
    }
}
