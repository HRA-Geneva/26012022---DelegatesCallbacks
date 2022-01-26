using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Car : Vehicle
    {
        public int WheelCount { get; set; }
        public string FuelType { get; set; }
        public decimal Engine { get; set; }

        public override string GetNameOfVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
