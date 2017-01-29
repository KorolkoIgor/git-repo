using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class BMW:Auto
    {
        public BMW(Driver driver) : base(driver) { }
        public virtual void Drive()
        {
            Console.WriteLine("BMW is driving, the driver is" + Driver);
        }
    }
}
