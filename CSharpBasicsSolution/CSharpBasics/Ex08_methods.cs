using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    class SampleClass
    {
        public void funcName(string name)
        {
            Console.WriteLine($"Your name is: {name} (static Method)");
            staticFuncName("Saqheeb from instance methid");
        }
        public static void staticFuncName(string name)
        {
            Console.WriteLine($"your name in is: {name} (static Method)");
        }

        public void modifyOperation(ref int ival)
        {
            Console.WriteLine("The input value is: " + ival);
            ival = ival + 11 * 199 / 13;
            Console.WriteLine("After operation the value is: "+ ival);
        }

        public void mathOperation(int val1, int val2, ref long addVal,ref long subVal, ref double divVal)
        {
            addVal = val1 + val2;
            subVal = val1 - val2;

            if(val2 != 0) { 
                divVal = divVal / val2;
            }
        }

        public void squareOperation(int val, out double sqr, out double sqrRoot)
        {
            sqr = val * val;
            sqrRoot = Math.Sqrt(val);
        }

        public int multipleArgsAddition(params int[] values) {
            int res=0;
            foreach (int val in values)
            {
                res += val;
            }
            return res;
        }
    }
    internal class Ex08_methods
    {
        static void Main(string[] args)
        {
            SampleClass obj = new SampleClass();
            /* obj.funcName("Saqheeb");
             SampleClass.staticFuncName("Saqheeb");

             int val = 150;
             obj.modifyOperation(ref val);

             Console.WriteLine("After modification function has been execute the val of variable is: "+ val);

             long addVal = 0;
             long subVal = 0;
             double divVal = 0;

             Console.WriteLine("THe values of the variables before execution of the method: "+addVal + " T_T " + subVal);
             obj.mathOperation(15,20,ref addVal,ref subVal,ref divVal);

             Console.WriteLine("The values of the variables after execution of the method: "+addVal+ " T_T "+subVal+ " T_T " + divVal);



             double sqr, sqrRoot;

             obj.squareOperation(49, out sqr, out sqrRoot);

             Console.WriteLine($"The values of the variable after opertation are:\n squareOfValue: {sqr} \n squareRootOfValue {sqrRoot}  \n");


            Console.WriteLine("The additon of all the values: "+obj.multipleArgsAddition(5, 10));
            Console.WriteLine("The additon of all the values: "+obj.multipleArgsAddition(5, 10, 15, 20));
            Console.WriteLine("The additon of all the values: "+obj.multipleArgsAddition(5, 10, 15, 20, 25, 30));*/




        }
    }
}
