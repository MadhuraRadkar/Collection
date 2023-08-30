using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            EmployeeCRUD crud = new EmployeeCRUD();
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Employee List");
                Console.WriteLine("2. Get Employee By Id");
                Console.WriteLine("3. Add Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Employee> list = crud.GetEmployee();
                        Console.WriteLine("EmpId\tName\t Salary\t Department");
                        foreach(Employee employee in list)
                        {
                            Console.WriteLine($"{employee.EmpId}\t{employee.Name}\t{employee.Salary}\t {employee.Department}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Employee id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee e = crud.GetEmployeeByEmpId(id);
                        Console.WriteLine("EmpId \t Name \t Salary\t Department");
                        Console.WriteLine($"{e.EmpId} \t{e.Name}\t{e.Salary }\t{e.Department}");
                        break;
                    case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee id");
                        e1.EmpId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department");
                        e1.Department = Console.ReadLine();
                        crud.AddEmployee(e1);
                        Console.WriteLine("Employee added....");
                        break;
                    case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter employee id");
                        e2.EmpId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter employee salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department");
                        e2.Department = Console.ReadLine();
                        crud.UpdateEmployee(e2);
                        Console.WriteLine("product updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter the employee id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployeeData(id2);
                        Console.WriteLine($"{id2} Employee data deleted..");
                        break;
                }

                Console.WriteLine("Press 1 for continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);

        }

    }
}

