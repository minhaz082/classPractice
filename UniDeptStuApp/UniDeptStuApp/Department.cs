using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDeptStuApp
{
    class Department
    {
        public string Code { set; get; }
        public string DeptName { set; get; }

        public List<Student> studentList;

        public Department(string code, string deptName) : this()
        {
            Code = code;
            DeptName = deptName;
        }

        public Department()
        {
            studentList = new List<Student>();
        }
    }
}
