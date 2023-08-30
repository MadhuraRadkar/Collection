using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonStudent
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        
    }
    public class StudentCRUD
    {
        private List<Student> studentlist;
        public StudentCRUD()
        {
            studentlist = new List<Student>()
            {
                new Student {Id=1,Name="Rohan",Age=14,Grade="A"},
                new Student {Id=2,Name="Priti",Age=15,Grade="A+"},
                new Student {Id=3,Name="Raj",Age=16,Grade="B"}
            };
        }
        public List<Student> GetStudents()
        {
            return studentlist;
        }
        public Student GetStudentById(int id)
        {
            Student student = new Student();
            foreach(Student s in studentlist)
            {
                if(s.Id == id)
                {
                    student = s;
                    break;
                }
            }
            return student;
        }
        public void AddStudent(Student s)
        {
            studentlist.Add(s);
        }
        public void UpdateStudent(Student s)
        {
            foreach(Student item in studentlist)
            {
                if(item.Id == s.Id)
                {
                    item.Name = s.Name;
                    item.Age = s.Age;
                    item.Grade = s.Grade;
                    break;
                }
            }
        }
        public void DeleteStudent(int id)
        {
            foreach (Student item in studentlist)
            {
                if(item.Id == id)
                {
                    studentlist.Remove(item);
                    break;
                }
            }
        }
    }
}
