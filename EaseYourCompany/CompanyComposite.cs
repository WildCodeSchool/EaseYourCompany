using System;
using System.Collections.Generic;
using System.Text;

namespace EaseYourCompany
{
    public class CompanyComposite
    {
        public IEnumerable<Employee> Employees { get; set; }

        public CompanyComposite(IEnumerable<Employee> employees)
        {
            Employees = employees;
        }

        public void ShowEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }

        public Single TotalSalaries
        {
            get
            {
                Single sum = 0;
                foreach (Employee employee in Employees)
                {
                    sum += employee.MonthlyWage;
                }
                return sum;
            }
        }
    }
}