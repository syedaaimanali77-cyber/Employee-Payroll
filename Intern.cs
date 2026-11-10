using System;
namespace Payroll
{ //milestone 3
    sealed class Intern : Employee
    {
        public decimal Stipend { get; private set; }

        public Intern(string name, decimal stipend) : base(name)
        {
            if (stipend <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Stipend = stipend;
        }
        public override decimal CalculateMonthlyPay()
        {
            return Stipend;
        }

    public override string GetEmployeeType()
        {
          return "Intern";
}
    }
}