using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Ford:Auto
    {
        public Ford(Driver driver) : base(driver) { }
        public virtual void Drive()
        {
            

            Console.WriteLine("Ford is driving, the driver is" + Driver);
        }
    }
}
