using System;
namespace Payroll
{
    //Milestone 2
    //inheritance
    class FullTimeEmployee : Employee , IBonusEligible
    {
        public decimal MonthlySalary { get; private set; }

        public FullTimeEmployee(string name, decimal monthlySalary) : base(name)
        {
            if (monthlySalary <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            MonthlySalary = monthlySalary;
        }

        public  decimal CalculateBonus()
        {
            return MonthlySalary*10 /100;
        }
        public override decimal CalculateMonthlyPay()
        {
            return MonthlySalary;
        }

        public override string GetEmployeeType()
        {
            return "Full-time";
        }

        public void GiveRaise(int percent)
        {
            if (percent < 1 || percent > 50)
            {
                throw new ArgumentOutOfRangeException("Raise can't be more than 50%");
            }

        MonthlySalary = MonthlySalary + (MonthlySalary * percent / 100);

        }
    }
}

