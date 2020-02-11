using System;
using System.Collections.Generic;

namespace EaseYourCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Laurent", DateTime.Today, 3000);
            List<Dev> developers = new List<Dev>
            {
                new Dev("Iurii", DateTime.Today),
                new Dev("Elif", DateTime.Today),
                new Dev("Elisa", DateTime.Today)
            };

            List<Commercial> commercials = new List<Commercial>
            {
                new Commercial("Gilles", DateTime.Today, 5750),
                new Commercial("Attila", DateTime.Today, 2750)
            };

            List<Employee> manyEmployees = new List<Employee>
            {
                new Manager("Laurent", DateTime.Today, 3000),
                new Commercial("Gilles", DateTime.Today, 5750),
                new Dev("Iurii", DateTime.Today)
            };

            manager.Team.AddRange(developers);
            manager.Team.AddRange(commercials);

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.AddRange(developers);
            allEmployees.AddRange(commercials);
            allEmployees.Add(manager);

            CompanyComposite company = new CompanyComposite(allEmployees);
            company.ShowEmployees();

            Console.WriteLine(company.TotalSalaries);
        }
    }
}
