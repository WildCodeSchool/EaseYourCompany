using System;
using System.Collections.Generic;
using System.Text;

namespace EaseYourCompany
{
    public abstract class Employee
    {
        public abstract Single MonthlyWage { get; set; }

        public String Name { get; set; }

        public DateTime HiredAt { get; set; }

        public abstract String Function { get; }


        public Employee(String name, DateTime hiredAt, Single wage)
        {
            Name = name;
            HiredAt = hiredAt;
            MonthlyWage = wage;
        }

        public abstract override String ToString();
    }
}