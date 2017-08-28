using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierakiTest
{
    public class CommissionEmployee : Employee
    {
        protected double rate;
        protected decimal sales;

        public CommissionEmployee(string firstName, string lastName, decimal sales, double rate) : base(firstName, lastName)
        {
            this.rate = rate;
            this.sales = sales;
        }

        public override decimal Earnings()
        {
            if(rate < 1)
            {
                return ((decimal)rate * sales) * DateTime.DaysInMonth(1980, 08);
            }
            else
                return (((decimal)rate/100) * sales) * DateTime.DaysInMonth(1980,08);
        }

        public override string ToString()
        {
            return $"{base.ToString()} har solgt for {sales:C0} til {rate:P0}\n{firstName} {lastName}\t Rate: {rate:P0}\t Sats: {sales:C0}\t Udbetaling: {Earnings():C0}";
        }
    }
}
