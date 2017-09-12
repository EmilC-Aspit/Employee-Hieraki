using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HierakiTest;
namespace hieraki
{
    class Program
    {
        static void Main(string[] args)
        {
            //toast er gud udhsaoiudjiuashdoias
            Console.WriteLine("Hourley:");
            Console.Writeline("Kagemand 45");
            HourlyEmployee mads = new HourlyEmployee("Mads", "Rasmussen", 10, 100M);
            HourlyEmployee emil = new HourlyEmployee("Emil", "Cordsen", 168, 200000);
            HourlyEmployee jack = new HourlyEmployee("jack", "Thomsen", 127, 20000);
            Console.WriteLine(mads.ToString() + "\n");

            Console.WriteLine(emil.ToString() + "\n");

            Console.WriteLine(jack.ToString() + "\n");

            Console.WriteLine("Fixed:");
            FixedEmployee morten = new FixedEmployee("Morten", "Hejn", 1000);
            FixedEmployee daniel = new FixedEmployee("Daniel", "Giversen", 20000);
            FixedEmployee emil2 = new FixedEmployee("Emil", "Cordsen", 200000);
            Console.WriteLine(morten.ToString() + "\n");

            Console.WriteLine(daniel.ToString() + "\n");

            Console.WriteLine(emil2.ToString() + "\n");



            Console.WriteLine("Commision:");
            CommissionEmployee jens = new CommissionEmployee("Jens", "Clausen", 200, 0.05);
            CommissionEmployee mads2 = new CommissionEmployee("Mads", "Andersen", 400, 0.10);
            CommissionEmployee emil3 = new CommissionEmployee("Emil", "Cordsen", 999, 120);
            Console.WriteLine(jens.ToString() + "\n");

            Console.WriteLine(mads2.ToString() + "\n");

            Console.WriteLine(emil3.ToString() + "\n");

            Console.WriteLine("CommisionAndBasic:");
            BasicAndCommissionEmployee jens2 = new BasicAndCommissionEmployee("Jens", "Clausen", 200, 0.05,200);
            BasicAndCommissionEmployee mads3 = new BasicAndCommissionEmployee("Mads", "Andersen", 400, 0.10, 400);
            BasicAndCommissionEmployee emil4 = new BasicAndCommissionEmployee("Emil", "Cordsen", 999, 120, 800);
            Console.WriteLine(jens2.ToString() + "\n");

            Console.WriteLine(mads3.ToString() + "\n");

            Console.WriteLine(emil4.ToString() + "\n");

            Console.ReadKey();
        }
    }
}
