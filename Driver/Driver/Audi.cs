using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Audi:Auto
    {
        public Audi(Driver driver) : base(driver) { }
        public override void Drive()
        {
            Console.WriteLine("Audi is driving, the driver is" + Driver);
        }
    }
}
