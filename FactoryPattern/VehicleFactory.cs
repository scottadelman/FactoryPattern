﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int answer)
        {
            if (answer == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return new Car();
            }
        }
    }
}
