using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierakiTest
{
    public class HourlyEmployee : Employee
    {
        protected decimal hourlyRate;
        protected double hours;

        public HourlyEmployee(string firstName, string lastName, double hours, decimal hourlyRate) : base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
            this.hours = hours;
        }

        public override decimal Earnings()
        {
            return (decimal)hours * hourlyRate;
        }

        public override string ToString()
        {
            //:C makes it somewhat bad FeelsBadMan
            return $"{base.ToString()} har arbejdet {hours} timer til {hourlyRate:C} i timen:\n{firstName} {lastName}:\t Timer: {hours}\t Sats: {hourlyRate:C}\t Udebaling: {Earnings():C}";
        }
    }
}
