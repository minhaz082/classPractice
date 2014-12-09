using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentStudentApp
{
    class Department
    {
        public string Code { private set; get; }
        public string Name { private set; get; }

        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }

        private List<Student> students = new List<Student>();

        public List<Student> Students
        {
            get { return students; }
        }

        public string AddStudent(Student aStudent)
        {
            string tempRegNo = aStudent.RegNo;

            foreach (Student student in students)
            {
                if(student.RegNo != tempRegNo)
                {
                    //MessageBox.Show(student.RegNo);
                    return "Student Added";
                    //students.Add(aStudent);
                    //return "Student Added";
                }
            }

            //students.Add(aStudent);
            return "No Unique";
        }
    }
}
