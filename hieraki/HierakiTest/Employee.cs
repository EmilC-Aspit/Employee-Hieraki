using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierakiTest
{
    abstract public class Employee
    {
        protected string firstName;
        protected string lastName;

        public abstract decimal Earnings();
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return $"{firstName}";
        }

    }
}
