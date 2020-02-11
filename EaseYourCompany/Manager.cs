using System;
using System.Collections.Generic;
using System.Text;

namespace EaseYourCompany
{
    public class Manager : Employee
    {
        public Single MonthlyFixedWage { get; private set; }

        public List<Employee> Team { get; }

        public Manager(String name, DateTime hiredAt, Single wage) : base(name, hiredAt, wage)
        {
            Team = new List<Employee>();
        }

        public override Single MonthlyWage
        {
            get
            {
                return MonthlyFixedWage;
            }
            set
            {
                MonthlyFixedWage = value;
            }
        }
        
        public override String Function { get => "Manager"; }

        public override String ToString()
        {
            String description = "";
            description += $"{Name} - {Function} - {MonthlyWage} $";
            foreach (Employee employee in Team)
            {
                description += $"\n\t" + employee;
            }
            return description;
        }
    }
}