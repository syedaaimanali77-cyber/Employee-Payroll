using System;
namespace Payroll

{
    abstract class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private static int counter = 0;
        public static int TotalEmployeesCreated { get; private set; }

        protected Employee(string name)
        {
            if (name == null || name == "")
            {
                throw new ArgumentException("Name can't be empty....");
            }
            else
            {
                Name = name;
                counter++;
                Id = counter; 

                TotalEmployeesCreated++;
            }
        }

        public abstract decimal CalculateMonthlyPay();
        public abstract string GetEmployeeType();

        public virtual string GetDetails()
            {
            return "(E" +  Id.ToString("D3") + ") " + GetEmployeeType() + " : " + Name;
            }
    }
    }
      


