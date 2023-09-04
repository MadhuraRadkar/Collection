using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class Employee
    {      // Impliment IComparer interface of generic collection with employee class.
        public string Name { get; set; }
        public double Salary { get; set; }
        public class CheckSalary:IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)  // x=e1,y=e2
            {
                if(x.Salary > y.Salary)
                {
                    return 1;
                }
                else if(x.Salary < y.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee { Name = "Suresh", Salary = 50000 };
                Employee e2 = new Employee { Name = "Priyanka", Salary = 50000 };

                CheckSalary c= new CheckSalary();

                int result=c.Compare(e1, e2);

                if(result == 1)
                {
                    Console.WriteLine("Suresh has more salary than Priyanka");
                }
                else if(result == -1)
                {
                    Console.WriteLine("Suresh has less salary than Priyanka");
                }
                else
                {
                    Console.WriteLine("Suresh & Priyanka both have same salary");
                }

            }
        }
    }
}
