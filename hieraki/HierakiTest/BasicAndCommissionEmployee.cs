using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierakiTest
{
    public class BasicAndCommissionEmployee :  CommissionEmployee
    {
        private decimal basicSalary; 
        private new decimal sales; //was it intended (. ﾟーﾟ) ? im sure it is

        public BasicAndCommissionEmployee(string firstName, string lastName, decimal sales, double rate, decimal basicSalary) : base (firstName, lastName, sales,rate)
        {
            this.sales = sales;
            this.basicSalary = basicSalary;
        }


        public override decimal Earnings()
        {
            if (rate < 1)
            {
                return (((decimal)rate * sales) * DateTime.DaysInMonth(1980, 08)) + basicSalary;
            }
            else
                return ((((decimal)rate / 100) * sales) * DateTime.DaysInMonth(1980, 08)) + basicSalary;
        }

        //har solgt for og har arbjedet i {DateTime.DaysInMonth(1980, 08)} til {basicSalary:C0} {sales:C0} til {rate:P0}";
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
