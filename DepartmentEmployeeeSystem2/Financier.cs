using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeeSystem2
{
    internal class Financier : Employee,CheckExistingRoom


    {
       public bool CheckSertification { get; set; }
        public override double WorkHours
        {
            get
            {
                return EmpSalary;
            }
            set
            {
                EmpSalary = value * 20;
            }


        }
        public Financier(bool check, string name, string surname, double workhours, DateTime period) : base(name, surname, workhours,period)
        {
            CheckSertification= check;

        }

        public void CheckExistingRoom()
        {
            Console.WriteLine($"{EmpNAME} Financi RoomFinance otaqinda yerlesir");
        }
    }
}
