using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsPorperties
{
    class Employee
    {
        int empId;
        string empName;
        string empAddress;
        int empSalary;

        public int employeeId
        {
            get { return empId; }
            set { empId = value; }
        }
        
        public string employeeName
        {
            get { return empName; }
            set { empName = value; }
        }
        
        public string employeeAddress
        {
            get { return empAddress; }
            set { empAddress = value; }
        }
        
        public int employeeSalary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }
    }

    


    internal class Ex07_classProperties
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter the value for employee ID: ");
            emp.employeeId = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value for employee Name: ");
            emp.employeeName = Console.ReadLine();
            
            Console.WriteLine("Enter the value for employee Address: ");
            emp.employeeAddress = Console.ReadLine();

            Console.WriteLine("Enter the value for employee Salary: ");
            emp.employeeSalary = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Employee's Name with Employee ID {emp.employeeId} is {emp.employeeName}. He/She resides in {emp.employeeAddress} " +
                $"and receives a salary of {emp.employeeSalary}");
        }
    }
}
