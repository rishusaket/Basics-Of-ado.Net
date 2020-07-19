using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    public class StudentBL
    {
        public IShowStudent showStudent;
        public StudentBL(IShowStudent showStudent)
        {
            this.showStudent = showStudent;
        }
        public List<Student> StudentList()
        {
            return showStudent.GetStudent();
        }
    }
}
