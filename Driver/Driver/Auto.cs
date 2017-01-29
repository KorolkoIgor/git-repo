using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Auto
    {
        public string Driver { get; set; }
        public Auto(Driver driver)
        {
            Driver = driver.Name + " " + driver.LastName;
        }
        public virtual void Drive()
        {
            Console.WriteLine("Auto is driving, the driver is" + Driver);
        }
    }
}
