
using DepartmentEmployeeeSystem2;
using System.Net;

Department deparment = new Department("SpaceX", 50);
DateTime dev1 = new DateTime(2020, 08, 05);
Developer developer1 = new Developer("C#", true, "backend", "Elcan1", "Salanov",130,dev1);
DateTime dev2 = new DateTime(2020, 09, 03);
Developer developer2 = new Developer("C#", false, "backend", "Elmir", "Sadiqov", 125, dev2);
DateTime dev3 = new DateTime(2024, 08, 05);
Developer developer3 = new Developer("Asp.net", true, "backend", "Xelil", "ehmedov", 135, dev3);
DateTime dev4 = new DateTime(2024, 08, 10);
Developer developer4 = new Developer("Javascript", false, "frontend", "Aygun", "Memmedova", 120, dev4);
DateTime des1 = new DateTime(2024, 08, 05);
Designer designer1 = new Designer("Adobe", "Web designer", "Babas", "Bedelov", 100, des1);
DateTime des2 = new DateTime(2024, 08, 05);
Designer designer2 = new Designer("Ado", "Grafik designer", "Nesibe", "Qedirova", 110, des2);
DateTime fin1 = new DateTime(2024, 08, 05);
Financier financier1 = new Financier(true, "Togrul", "Ismayilov", 115, fin1);

string answer;
do
{
    Console.WriteLine("1.Employee elave et");
    Console.WriteLine("2.Departmentde olan bütün employeelere bax");
    Console.WriteLine("3.Muqavile muddetinin yoxlanisi");
    Console.WriteLine("4.Menudan cix");
    answer = Console.ReadLine();

    switch (answer)
    {
        case "1":

            deparment.AddEmployee(developer1);
            deparment.AddEmployee(developer2);
            deparment.AddEmployee(developer3);
            deparment.AddEmployee(developer4);
            deparment.AddEmployee(designer1);
            deparment.AddEmployee(designer2);
            deparment.AddEmployee(financier1);
            developer1.Remote();
            developer2.Remote();
            developer3.Remote();
            developer4.Remote();
            designer1.CheckExistingRoom();
            designer2.CheckExistingRoom();
            financier1.CheckExistingRoom();
           
            break;
        case "2":
            deparment.ListGroup(deparment.employees);
            break;
        case "3":
            deparment.RemoveEmployee(developer1);
            deparment.RemoveEmployee(developer2);
            deparment.RemoveEmployee(developer3);
            deparment.RemoveEmployee(developer4);
            deparment.RemoveEmployee(financier1);
            deparment.RemoveEmployee(designer1);
            break;
        
        default: break;

    }
} while (!(answer == "4"));