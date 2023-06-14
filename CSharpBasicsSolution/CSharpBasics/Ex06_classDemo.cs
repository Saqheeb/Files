using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Employee
    {
        int empId;
        string empName;
        string empAddress;
        int empCtc;
        int empBaseSalary;

        public Employee(int id, string name, string address, int ctc) { 
            empId = id;
            empName = name;
            empAddress = address;   
            empCtc = ctc;
            empBaseSalary = getBase();
        }


        public int getId() { return empId; }
        public string getName() { return empName; }   
        
        public string getAddress() { return empAddress; }
        public static double[] salary;
        public int getBase() {
            calcSalary(empCtc, empBaseSalary);
            return (int)salary[1];   
        }

        public void calcSalary(int empCtc, int empBaseSalary)
        {
            salary[0] = empCtc;

            salary[1] = (int)(empCtc - (0.15 * empCtc));
            salary[1] = (empCtc - (0.15 * empCtc));
        }
    }

    

    internal class Ex06_classDemo
    {
        
        static void Main(string[] args)
        {

        }
    }
}
