using System;
using System.Collections.Generic;
using System.Text;

namespace EaseYourCompany
{
    public class Dev : Employee
    {
        public int WeeklyWorkedHours { get => 35; }
        public Single HourPrice { get; private set; }

        public Dev(String name, DateTime hiredAt) : base(name, hiredAt, 1500)
        { }

        public override Single MonthlyWage 
        {
            get
            {
                return WeeklyWorkedHours * HourPrice * 4;
            }
            set
            {
                HourPrice = value / (WeeklyWorkedHours * 4);
            }
        }

        public override String Function { get => "Bada$$"; }

        public override String ToString()
        {
            return $"{Name} - {Function} - {MonthlyWage} $";
        }
    }
}