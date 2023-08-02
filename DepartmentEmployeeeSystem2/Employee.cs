using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeeSystem2
{
    abstract internal class Employee
    {
        private string _Empname;
        public string EmpNAME
        {
            get
            {
                return _Empname;
            }
            set
            {
                if (Check(value))
                {
                    _Empname = value;
                }
                else
                {
                    Console.WriteLine("Empname must consist of letters only");
                }
            }
        }
        private string _Empsurname;
        public string EmpSurName
        {
            get
            {
                return _Empsurname;
            }
            set
            {
                if (Check(value))
                {
                    _Empsurname = value;
                }
                else
                {
                    Console.WriteLine("Empsurname must consist of letters only");
                }

            }
        }
        public static bool Check(string word)
        {
            bool result = false;
            foreach (var letter in word)
            {
                if (!char.IsLetter(letter))
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }

            }
            return result;
        }

        public abstract double WorkHours { get ; set; }

        protected  double EmpSalary { get; set; }

        public DateTime EndTime { get; set; }


        public Employee(string name,string surname,double workhours,DateTime period)
        {
            EmpNAME= name;
            EmpSurName= surname;
            WorkHours = workhours;
            EndTime= period;
        }

        
    }
}

