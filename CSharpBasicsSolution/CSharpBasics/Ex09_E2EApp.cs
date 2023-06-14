using CSharpBasics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasics.Entities;


namespace CSharpBasics
{

    namespace Entities
    {   
        class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeEmail { get; set; }
            public long EmployeePhone { get; set; }
            public int EmployeeSalary { get; set; }
        }

    }

    namespace Repository
    {
        class EmployeeRepo
        {
            private Employee[] employees;
            

            private Employee copy(Employee copy)
            {
                var emp = new Employee();
                emp.EmployeeId = copy.EmployeeId;
                emp.EmployeeName = copy.EmployeeName;   
                emp.EmployeeEmail = copy.EmployeeEmail; 
                emp.EmployeePhone = copy.EmployeePhone;
                emp.EmployeeSalary = copy.EmployeeSalary;   
                return emp;
            }

            public EmployeeRepo(int size)
            {
                employees = new Employee[size];
                employees[0] = new Employee { EmployeeEmail = "test1@gmail.com", EmployeeId = 111, EmployeeName = "Phaniraj", EmployeePhone = 9945205684, EmployeeSalary = 56000 };
                employees[1] = new Employee { EmployeeEmail = "test2@gmail.com", EmployeeId = 112, EmployeeName = "Ramesh", EmployeePhone = 9449184401, EmployeeSalary = 46000 };
            }

            public EmployeeRepo() : this(0) //calls constructor in line 29.This is default constructor.
            {

            }


            public void addNewEmployee(Employee emp)
            {
                for(int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] == null)
                    {
                        employees[i] = copy(emp);
                        return;
                    }
                }
                Console.WriteLine("No more employees cna be added!!!");
            }

            public Employee[] getAllEmployees()
            {
                return employees;
            }

            public void updateEmployee(Employee emp)
            {
                //Iterate thru the array...
                for (int i = 0; i < employees.Length; i++)
                {
                    //Find the matching Emp based on Id.
                    if ((employees[i] != null) && (employees[i].EmployeeId == emp.EmployeeId))
                    {
                        employees[i] = copy(emp);
                        return;//exit the function and no further iteration is required. 
                    }
                }
                Console.WriteLine("No record was found to update");
            }

            public void deleteEmployee(int id)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if ((employees[i] != null) && (employees[i].EmployeeId == id))
                    {
                        employees[i] = null;//We dont have delete operator, so set to null
                        return;
                    }
                }
                Console.WriteLine("No Matching Record found to delete");
            }

            public Employee[] GetAllEmployees()
            {
                Employee[] array = new Employee[0];
                foreach (var emp in employees)
                {
                    if (emp != null)
                    {
                        var temp = (Employee[])array.Clone();
                        if (temp.Length == 0)
                        {
                            array = new Employee[1];//Only for the first element...
                            array[0] = emp;
                        }
                        else
                        {
                            array = new Employee[temp.Length + 1];
                            Array.Copy(temp, array, temp.Length);
                            array[array.Length - 1] = emp;
                        }
                    }
                }
                return array;
            }
        }
    }

    internal class Ex09_E2EApp
    {

        const string MENU = " ------------EMPLOYEE MANAGEMENT--------------" +
                "\r\n1.ADD A NEW EMPLOYEE\r\n" +
                "2.DISPLAY EMPLOYEE DETAILS\r\n" +
                "3.EDIT EMPLOYEE DETAILS\r\n" +
                "4.DELETE THE EMPLOYEE\r\n--------------------------------------------- ";

        static EmployeeRepo repo = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of Employees of this Organization");
            int size = int.Parse(Console.ReadLine());

            repo = new EmployeeRepo(size);
            bool processing = true;
            do
            {
                Console.WriteLine(MENU);
                int choice = MyConsole.getNumber(MENU);
                processing = processMenu(choice);
            } while (processing);
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingNewEmployee();
                    return true;
                case 2:
                    displayAllEmployees();
                    return true;
                case 3:
                    editEmployee();
                    return true;
                case 4:
                    deleteEmployee();
                    return true;
                default:
                    return false;
            }
        }

        private static void deleteEmployee()
        {
            //throw new NotImplementedException();
            int empId = MyConsole.getNumber("Enter the EmployeeID of the employee to be updated: ");
            
        }

        private static void editEmployee()
        {
            throw new NotImplementedException();
        }

        private static void displayAllEmployees()
        {
            Employee[] records = repo.GetAllEmployees();
            foreach (var emp in records)
            {
                displayRecord(emp);
            }
        }

        private static void displayRecord(Employee emp)
        {
            Console.WriteLine($"Here are the details: \nThe Name:{emp.EmployeeName}\nThe Email Address: {emp.EmployeeEmail}\nThe Contact No: {emp.EmployeePhone}\nThe Salary: {emp.EmployeeSalary}\nThe Employee ID: {emp.EmployeeId}");
        }

        private static void addingNewEmployee()
        {
            var emp = new Employee();
            emp.EmployeeId = MyConsole.getNumber("Enter the Id");
            emp.EmployeeName = MyConsole.getString("Enter the Name of the Employee");
            emp.EmployeeEmail = MyConsole.getString("Enter the Email Address of the Employee");
            emp.EmployeePhone = MyConsole.getLong("Enter the Contact no of the Employee");
            emp.EmployeeSalary = MyConsole.getNumber("Enter the Salary of the Employee");
            repo.addNewEmployee(emp);
            Console.WriteLine("Employee added successfully");
        }

    }
}
