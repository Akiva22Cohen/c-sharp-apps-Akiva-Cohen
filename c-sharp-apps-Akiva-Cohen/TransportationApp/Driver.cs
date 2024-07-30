using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public enum CargoType
    {
        Car,
        Motorcycle,
        Truck,
        Plane,
        Train,
        Ship
    }

    public class Driver
    {
        private int id;
        private string firstName;
        private string lastName;
        CargoType cargoType;

        public bool Approve(CargoType type)
        {
            return true;
        }

    }
}
