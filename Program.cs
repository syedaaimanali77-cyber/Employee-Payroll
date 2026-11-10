using System;
namespace Payroll
{ 
    class Program
    {
        static void Main( string[] args )
        {

            Company company1 = new Company();

            FullTimeEmployee ali = new FullTimeEmployee("Ali Raza", 120000);

            PartTimeEmployee aiman = new PartTimeEmployee("Aiman Raza", 2000, 30);

            Intern hunain = new Intern("Hunain Raza", 30000);

            ContractualEmployee tahira = new ContractualEmployee("Tahira", DateTime.Now, DateTime.Now.AddMonths(12), 85000);
           

            company1.AddEmployee(ali);
            company1.AddEmployee(aiman);

            company1.AddEmployee(hunain);

            company1.AddEmployee(tahira);

            company1.PrintPayroll();

            ali.GiveRaise(10); 


            try
            {
                ali.GiveRaise(60);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            try
            {
                FullTimeEmployee testEmployee = new FullTimeEmployee("", 50000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Total Employees Created: " + Employee.TotalEmployeesCreated);

            Console.WriteLine("Updated Salary : " + ali.MonthlySalary);

            // search by id
            Employee? result1 = company1.Search(2);
            Console.WriteLine("Search by ID: " + result1?.GetDetails());
            // sarch by name
            Employee? result2 = company1.Search("Hunain Raza");

            Console.WriteLine("Search by Name: " + result2?.GetDetails());

            /*
            Counter apples = new Counter("Apples");
            Counter oranges = new Counter("Oranges");
            Counter grapes = new Counter("Grapes");
         

            apples.Increment();
            apples.Increment();
            apples.Increment();

            grapes.Increment(); 

            oranges.Increment(); 
            oranges.Increment();

            FullTimeEmployee employee = new FullTimeEmployee("Syed Ali Raza",150000);
        
            Console.WriteLine("Monthly Salary : " + employee.MonthlySalary);
            employee.GiveRaise(20);
          

            Console.WriteLine("Salary After Raise : " + employee.MonthlySalary);


            Console.WriteLine("Apples : " + apples.GetCount());
        Console.WriteLine("Oranges : " + oranges.GetCount());
            Console.WriteLine("Grapes : " + grapes.GetCount());

            Console.WriteLine("Total Counters : " + Counter.GetTotalCounters())
            ;
            */

        }
    }
}

