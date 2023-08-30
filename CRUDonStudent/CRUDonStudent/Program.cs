using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            StudentCRUD crud = new StudentCRUD();
            do
            {
                Console.WriteLine("1.Student List");
                Console.WriteLine("2.Get Student By ID");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Student");
                Console.WriteLine("5.Delete student data");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        List<Student> list = crud.GetStudents();
                        Console.WriteLine("Id\t Name\t Age\t Grade");
                        foreach(Student student in list)
                        {
                            Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Age}\t{student.Grade}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the student id");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Student s=crud.GetStudentById(id);
                        Console.WriteLine("Id\t Name\t Age\t Garde");
                        Console.WriteLine($"{s.Id}\t{s.Name}\t {s.Age}\t{s.Grade}");

                        break;
                    case 3:
                        Student s1 = new Student();
                        Console.WriteLine("Enter student id");
                        s1.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        s1.Name=Console.ReadLine();
                        Console.WriteLine("Enter student age");
                        s1.Age=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student Grade");
                        s1.Grade=Console.ReadLine();
                        crud.AddStudent(s1);
                        Console.WriteLine("Student Added");

                        break;
                    case 4:
                        Student s2= new Student();
                        Console.WriteLine("Enter student id");
                        s2.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        s2.Name=Console.ReadLine();
                        Console.WriteLine("Enter student age");
                        s2.Age=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student grade");
                        s2.Grade=Console.ReadLine();
                        crud.UpdateStudent(s2);
                        Console.WriteLine("Student added");

                        break;
                    case 5:
                        Console.WriteLine("Enter student id");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(id2);
                        Console.WriteLine($"{id2} student deleted...");

                        break;

                }
                Console.WriteLine("Press 0 for continue");
                no=Convert.ToInt32(Console.ReadLine());

            } while (no == 0);
        }
    }
}
