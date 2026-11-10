using System;


namespace Payroll
{
    class Counter
    {
        public string Name { get; }
        private int count = 0;
        private static int totalCounters = 0;


        public Counter(string name)
        {
            Name = name;
            totalCounters++;
        }

        public void Increment() 
        {
            count++;
        }
        public int GetCount()
        {
            return count;
        }
        public static int GetTotalCounters()
        {
            return totalCounters;
        }

    }
}
