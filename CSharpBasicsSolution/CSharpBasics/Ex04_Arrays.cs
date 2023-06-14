using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex04_Arrays
    {
        static void Main(string[] args)
        {
            //cartDisplay();
            //nultiDimentionalArray();
            jaggedArray();
        }

        private static void jaggedArray()
        {
            int[][] school = new int[4][];

            school[0] = new int[] { 1, 2, 3, 4 };
            school[1] = new int[] { 13, 22, 13, 54 };
            school[2] = new int[] { 17, 21, 31, 42, 45, 67 };
            school[3] = new int[] { 9, 29, 33, 42, 57, 29, 38, 46, 59, 61 };

            for (int i = 0; i < school.Length; i++)
            {
                Console.WriteLine("Student score in classroom no: " + i);

                foreach (var score in school[i])
                {
                    Console.Write(score + " ");
                    Console.WriteLine();
                }
            }

        }

        private static void nultiDimentionalArray()
        {
            int[,] data = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            Console.WriteLine("The number of dimensions in the array is: " + data.Rank);
            Console.WriteLine("The length of th 1st dimension is: " + data.GetLength(0));
            Console.WriteLine("The length of th 2nd dimension is: " + data.GetLength(1));

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void cartDisplay()
        {
            Console.WriteLine("Enter the size of cart: ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] cart = new string[size];

            Console.WriteLine("Enter the items to be added to cart: ");

            for(int i = 0; i < size; i++)
            {
                cart[i] = Console.ReadLine();
            }


            Console.WriteLine("\n\nItems in your cart are:");
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }
        }

    }
}
