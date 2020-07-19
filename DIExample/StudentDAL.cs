using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    public interface IShowStudent
    { 
        List<Student> GetStudent(); 
    }
    public class StudentDAL : IShowStudent
    {
        public List<Student> GetStudent()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { Id = 1, name = "Rishu", subject = "maths" });
            studentList.Add(new Student() { Id = 2, name = "Saket", subject = "physics" });
            studentList.Add(new Student() { Id = 3, name = "Rishabh", subject = "Chemistry" });
            return studentList;
        }
    }
}
