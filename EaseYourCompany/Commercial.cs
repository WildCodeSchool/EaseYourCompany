using System;
using System.Collections.Generic;
using System.Text;

namespace EaseYourCompany
{
    public class Commercial : Employee
    {
        public Single MonthlyFixedWage { get; private set; }
        public Single WageBonus { get; set; }

        public Commercial(String name, DateTime hiredAt, Single wage) : base(name, hiredAt, wage)
        { }

        public override Single MonthlyWage 
        { 
            get
            {
                return MonthlyFixedWage + WageBonus;
            }
            set
            {
                MonthlyFixedWage = value;
            }
        }
        public override String Function { get => "Commercial"; }
        
        public override String ToString()
        {
            return $"{Name} - {Function} - {MonthlyWage} $";
        }
    }
}