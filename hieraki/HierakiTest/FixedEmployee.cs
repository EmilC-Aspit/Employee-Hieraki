using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierakiTest
{
   public class FixedEmployee : Employee
    {
        protected decimal fixedSalary;

        public FixedEmployee(string firstName, string lastName, decimal fixedSalary) : base(firstName, lastName)
        {
            this.fixedSalary = fixedSalary;
        }

        public override decimal Earnings()
        {
           
            return fixedSalary * DateTime.DaysInMonth(1980, 08);
        }

        public override string ToString()
        {
            return $"{base.ToString()} har Abejdet i {DateTime.DaysInMonth(1980,08)} til {fixedSalary:C}\n{firstName} {lastName}\t Dage: {DateTime.DaysInMonth(1980, 08)}\t Sats:{fixedSalary:C}\t Udebetaling: {Earnings():C}";
        }
    }

}
