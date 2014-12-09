using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class GradeCalculator
    {
        private int physicsMarks;
        private int chemistryMarks;
        private int mathMarks;

        public int PhysicsMarks
        {
            set { physicsMarks = value; }
        }

        public int ChemistryMarks
        {
            set { chemistryMarks = value; }
        }

        public int MathMarks
        {
            set { mathMarks = value; }
        }

        public GradeCalculator(int phy, int chem, int math)
        {
            physicsMarks = phy;
            chemistryMarks = chem;
            mathMarks = math;
        }

        //public GradeCalculator(int phy, int chem) : this(phy)
        //{
        //    chemistryMarks = chem;
        //}

        //public GradeCalculator(int phy) : this()
        //{
        //    physicsMarks = phy;
        //}

        //public GradeCalculator()
        //{
        //    physicsMarks = 0;
        //    chemistryMarks = 0;
        //    mathMarks = 0;
        //}

        public double AverageMark()
        {
            return (physicsMarks + chemistryMarks + mathMarks)/3.0;
        }

        public string LetterGrade()
        {
            double avg = AverageMark();

            if (avg >= 80)
            {
                return "A+";
            }
            else if (avg >= 70)
            {
                return "B+";
            }
            else if (avg >= 60)
            {
                return "C+";
            }
            else if (avg >= 50)
            {
                return "D+";
            }
            else if (avg < 50)
            {
                return "F";
            }

            return "NO GRADE GIVEN";
        }
    }
}
