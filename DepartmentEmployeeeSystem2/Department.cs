using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DepartmentEmployeeeSystem2
{
    internal class Department
    {
        public string Name { get; set; }
          public int count { get; set; }
          public int EmployeeLimit { get; set; }
        public Employee[] employees;

        
        public Department(string name,int employeelimit)
        {
            count = 0;
            Name = name;
            EmployeeLimit = employeelimit;
            employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            if (count <= EmployeeLimit)
            {
                if (employee.EmpSurName != null && employee.EmpNAME != null)
                {

                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = employee;
                    count++;
                    Console.WriteLine($"add {count}.employee was added to the department");

                }
                else
                {
                    Console.WriteLine("ad veya soyad yanlis qeyd edilib");
                }
            }

            else
            {
                Console.WriteLine("Limit asilmisdir.");
            }
       

        }

        public void RemoveEmployee(Employee employee)
        {
            if(employee.EmpNAME==null || employee.EmpSurName==null )
            {
                return;
            }
            //TimeSpan ts = employee.EndTime - DateTime.Now;
            var z = employee.EndTime.Subtract(DateTime.Now).Days;

            if (z>0) 
            {
                Console.WriteLine($"{employee.EmpNAME} ise devam edir");

            }

            else
            {
               int index= Array.IndexOf(employees, employee);
                employees[index] =null;
                Console.WriteLine($"{employee.EmpNAME} ile olan muqavile muddeti bitmisdir");
            }

        }

        public  void ListGroup(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
               

                    Console.WriteLine("{0}----->{1}------>{2}", employees[i].EmpNAME, employees[i].EmpSurName, employees[i].WorkHours);
                



            }

        }
    }
}

