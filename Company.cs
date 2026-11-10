using System;
using System.Collections.Generic;
namespace Payroll
{ 
    class Company
    {
        private List<Employee> collection = new List<Employee>();

        public void AddEmployee( Employee employee )
        {
            collection.Add(employee);
        }

        public Employee? Search( int id)
        {
           Employee? employee = collection.Find(employee => employee.Id == id);

            return employee;
        }
        public Employee? Search( string name )
        {
            Employee? employee = collection.Find(employee => employee.Name == name);

            return employee;
        }
        public void PrintPayroll()
        {
            foreach (Employee employee in collection)
            {
                decimal pay = employee.CalculateMonthlyPay();

                decimal bonus = 0;
                if (employee is IBonusEligible b)
                {
                    bonus = b.CalculateBonus();
                }

                decimal tax = TaxHelper.CalculateTax(pay);
                
                decimal netPay = pay + bonus - tax;

                Console.WriteLine("Employee : " + employee.Name);

                Console.WriteLine(employee.GetDetails());

                Console.WriteLine("Pay: " + pay.ToString("N0"));
                Console.WriteLine("Bonus: " + bonus.ToString("N0"));
                Console.WriteLine("Tax: " + tax.ToString("N0"));
                Console.WriteLine("Net Pay: " + netPay.ToString("N0"));
                Console.WriteLine();
                Console.WriteLine("--------------");

            }
        }
        
    }
}
