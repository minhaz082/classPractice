using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class GradeCalculatorUI : Form
    {
        public GradeCalculatorUI()
        {
            InitializeComponent();
        }
        
        GradeCalculator aGradeCalculator = new GradeCalculator(30,70,60);

        private void showButton_Click(object sender, EventArgs e)
        {
            //aGradeCalculator.PhysicsMarks = Convert.ToInt32(physicsTextBox.Text);
            //aGradeCalculator.ChemistryMarks = Convert.ToInt32(chemistryTextBox.Text);
            //aGradeCalculator.MathMarks = Convert.ToInt32(mathTextBox.Text);

            double avgMark = aGradeCalculator.AverageMark();
            string letterGrade = aGradeCalculator.LetterGrade();

            averageTextBox.Text = avgMark.ToString();
            gradeLetterTextBox.Text = letterGrade;
        }
    }
}
