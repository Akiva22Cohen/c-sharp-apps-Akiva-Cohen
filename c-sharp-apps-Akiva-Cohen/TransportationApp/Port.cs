using c_sharp_apps_Akiva_Cohen.TransportationApp.Abs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class Port : StorageStructure
    {
        private CargoType cargoType;
        public Port(string country, string city, string street, int num, int maxNumPortables, CargoType cargoType) : base(country, city, street, num, maxNumPortables)
        {
            this.CargoType = cargoType;
        }

        public CargoType CargoType { get => cargoType; set => cargoType = value; }
    }
}
