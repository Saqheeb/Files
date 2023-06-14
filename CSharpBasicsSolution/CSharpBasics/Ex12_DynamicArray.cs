using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DynamicArray
{
    int[] buffer = new int[10];

    public int this[int index]
    {
        get { return buffer[index]; }
        set { this.buffer[index] = value; }
    }

}

namespace CSharpBasics
{

    public class Ex12_DynamicArray
    {
        public static void Main(string[] args)
        {
            DynamicArray dynArray = new DynamicArray();

            dynArray[0] = 10;
            int item = dynArray[0];
            Console.WriteLine( item);
        }
    }
}
