using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Experience
    {
        public string MajorExperiences { set; get; }
        public int ExperienceInYear { set; get; }

        public Experience(string majorExperiences, int experienceInYear)
        {
            MajorExperiences = majorExperiences;
            ExperienceInYear = experienceInYear;
        }
    }
}
