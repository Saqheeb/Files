using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex05_dynamicArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Data_type to be stored in the array: ");
            Type dataType = Type.GetType(Console.ReadLine()) ;

            Array arr = Array.CreateInstance(dataType, size) ;

            Console.WriteLine("Enter the values for the array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value for the position {i} of the dataType {dataType.Name}");
                //var input = Console.ReadLine();
                arr.SetValue(Convert.ChangeType(Console.ReadLine(), dataType),i);
            }

            Console.WriteLine("All the values are: ");
            foreach ( var item in arr )
            {
                Console.WriteLine(item);
            }

        }
    }
}
