using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Degree
    {
        public string InstituteName { set; get; }
        public string InstituteCountry { set; get; }

        public Degree(string name, string country)
        {
            InstituteName = name;
            InstituteCountry = country;
        }
    }
}
