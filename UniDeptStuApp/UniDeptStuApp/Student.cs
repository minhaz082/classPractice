using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDeptStuApp
{
    class Student
    {
        public string Name { set; get; }
        public string Reg { set; get; }
        public string Email { set; get; }

        public Student(string name, string reg, string email)
        {
            Name = name;
            Reg = reg;
            Email = email;
        }
    }
}
