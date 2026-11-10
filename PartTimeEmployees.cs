using System;
namespace Payroll

{
    //milestone 3

    class PartTimeEmployee : Employee , IBonusEligible
    {
        public decimal HourlyRate { get; private set; }
        public int HoursWorked { get; private set; } 

        public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name) 
        {
            if (hourlyRate <= 0 || hoursWorked < 0 || hoursWorked > 200) 

            {
                throw new ArgumentOutOfRangeException();
            }
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateBonus()
        {
            return HoursWorked * 50;
        }

        public override decimal CalculateMonthlyPay() 
        {
            return HourlyRate * HoursWorked;
        }
        public override string GetEmployeeType()
        {
            return "Part-time";
        }
        public override string GetDetails()
        {
            return base.GetDetails() + " ( " + HoursWorked + " hrs )";
        }

    }
}

