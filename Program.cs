using System;
namespace Payroll
{ 
    class Program
    {
        static void Main( string[] args )
        {
            Counter apples = new Counter("Apples");
            Counter oranges = new Counter("Oranges");
            Counter grapes = new Counter("Grapes");

            apples.Increment();
            apples.Increment();
            apples.Increment();
            grapes.Increment();
            oranges.Increment();
            oranges.Increment();



        Console.WriteLine("Apples : " + apples.GetCount());
        Console.WriteLine("Oranges : " + oranges.GetCount());
        Console.WriteLine("Grapes : " + grapes.GetCount());

            Console.WriteLine("Total Counters : " + Counter.GetTotalCounters());

        }
    }
}
