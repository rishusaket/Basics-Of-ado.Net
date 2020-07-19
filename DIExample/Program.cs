using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBL studentBL = new StudentBL(new StudentDAL());
            List<Student> result = studentBL.StudentList();
            foreach(Student student in result)
            {
                Console.WriteLine(student.name);
            }
            Console.ReadKey();

        }
    }
}
