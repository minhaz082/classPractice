using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Person
    {
        public string Name { private set; get; }
        public int Age { private set; get; }
        public string Country { private set; get; }
        public string Email { private set; get; }
        public Degree ADegree { set; get; }
        public Experience AnExperience { set; get; }

        public Person(string name,int age, string country, string email, Degree aDegree, Experience anExperience)
        {
            Name = name;
            Age = age;
            Country = country;
            Email = email;
            ADegree = aDegree;
            AnExperience = anExperience;
        }

        public int CalculateExperienceYear()
        {
            return Age/AnExperience.ExperienceInYear;
        }

        public bool CompareCountry()
        {
            string countryBirth = Country;
            string countryStudy = ADegree.InstituteCountry;

            if (countryBirth == countryStudy)
            {
                return true;
            }

            return false;
        }
    }
}
