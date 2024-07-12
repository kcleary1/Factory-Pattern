using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tires)
        {
            switch (tires)
            {
                case "2":
                    return new Motorcycle();
                case "16":
                    return new BigRig();
                default:
                    return new Motorcycle();
            }

        }
    }
}
