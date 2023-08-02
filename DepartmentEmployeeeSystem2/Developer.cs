using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeeSystem2
{
    internal class Developer : Employee, Remote

    {
        public string UsingLanguage { get; set; }
        public bool VersionControl { get; set; }
        public string TypeOfDeveloper { get; set; }
        public Developer(string usinglanguage,bool versioncontrol,string typeofdeveloper,string name ,string surname ,double workhours, DateTime period) :base(name,surname,workhours,period)
        {
            UsingLanguage= usinglanguage;
            VersionControl= versioncontrol;
            TypeOfDeveloper= typeofdeveloper;
        }
        public override double WorkHours {
            get
            {
                return EmpSalary;
            }
            set
            {
                EmpSalary = value * 40;
            } 
                
                
        }

        public void Remote()
        {
            Console.WriteLine($"{EmpNAME} Developer ucun otaq ayrilmayib.Cunki bu developer remote sekilde isleyecek");
        }
    }
}
