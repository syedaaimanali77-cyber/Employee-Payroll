using System;
namespace Payroll
{
    static class TaxHelper
    {

        public static decimal CalculateTax(decimal pay)
        {
            if (pay <= 50000)
            {
                return 0;
            }
            else
            {
                return (pay - 50000) / 100 * 10;
            }
        }
    }
}
