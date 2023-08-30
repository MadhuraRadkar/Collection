using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonEmployee
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
    public class EmployeeCRUD
    {
        private List<Employee> employeelist;
        public EmployeeCRUD()
        {
            employeelist = new List<Employee>()
            {
                new Employee{EmpId=101,Name="Sandesh",Salary=25000,Department ="sales"},
                new Employee {EmpId=102,Name="Kedar",Salary =30000,Department ="Finance"}
            };

        }
        public List<Employee> GetEmployee()
        {
            return employeelist;
        }
        public Employee GetEmployeeByEmpId(int empid)
        {
         
            Employee employee = new Employee();
            foreach (Employee e in employeelist)
            {
                if (e.EmpId == empid)
                {
                    employee = e;
                    break;
                }
            }
            return employee;
        }
        public void AddEmployee(Employee e)
        {
            employeelist.Add(e);
        }
        public void UpdateEmployee(Employee e)
        {
            foreach (Employee item in employeelist)
            {
                if (item.EmpId == e.EmpId)
                {
                    item.Name = e.Name;
                    item.Salary = e.Salary;
                    item.Department = e.Department;
                    break;

                }
            }
        }
        public void DeleteEmployeeData(int id)
        {
            foreach (Employee item in employeelist)
            {
                if (item.EmpId == id)
                {
                    employeelist.Remove(item);
                    break;
                }
            }

        }
    }
}