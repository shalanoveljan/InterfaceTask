using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeeSystem2
{
    internal class Designer : Employee,CheckExistingRoom

    {
        public string UsingDesignProg { get; set; }
        public string TypeOfDesigner { get; set; }

        public override double WorkHours
        {
            get
            {
                return EmpSalary;
            }
            set
            {
                EmpSalary = value * 30;
            }

        }

        public Designer(string usingdesignprog,string typeofdesigner,string name,string surname,double workhours, DateTime period) :base(name,surname,workhours,period)
        {
            UsingDesignProg = usingdesignprog;
            TypeOfDesigner = typeofdesigner;

        }

        public void CheckExistingRoom()
        {
            Console.WriteLine($"{EmpNAME} Designer RoomDesign otaqinda yerlesir");
        }
    }
}