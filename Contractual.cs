using System;
using System.Xml.Linq;
namespace Payroll
{
    class ContractualEmployee: Employee

    {
        public DateTime ContractStartDate { get; private set; }
        public DateTime ContractEndDate { get; private set; }
       
       public decimal MonthlyPay; 
        

        public ContractualEmployee ( string name, DateTime contractStartDate , DateTime contractEndDate ,  decimal monthlyPay ) : base (name)

        { 
            if ( monthlyPay <= 0 ) 
            {
                throw new ArgumentOutOfRangeException( );
            }

            ContractStartDate = contractStartDate;
            ContractEndDate = contractEndDate;
            MonthlyPay = monthlyPay;
        }

        public bool IsContractValid( DateTime contractEndDate )
        {
            if ( DateTime.Now < contractEndDate )       
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override decimal CalculateMonthlyPay()
        {
            return MonthlyPay;
        }
        public override string GetEmployeeType() 
        {
            return "Contractual-Employee";
        }
         }

}

