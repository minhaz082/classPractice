using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStudentApp
{
    class Student
    {
        public string RegNo { private set; get; }
        public string Name { private set; get; }
        public string Email { private set; get; }

        public Student(string regNo, string name, string email)
        {
            RegNo = regNo;
            Name = name;
            Email = email;
        }
    }
}
