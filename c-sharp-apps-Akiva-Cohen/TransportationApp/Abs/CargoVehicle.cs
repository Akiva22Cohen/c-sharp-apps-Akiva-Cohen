using c_sharp_apps_Akiva_Cohen.TransportationApp.Inters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Abs
{
    public abstract class CargoVehicle: IContainable
    {
        private Driver driver;
        private bool canDrive;
        private Port currentPort;
        private Port nextPort;
        private int idOfCurrentRide;
        private Dictionary<int, string> payment;
        private int travelDistance;


        public string GetPricingList()
        {
            return "";
        }


        public abstract bool Load(IPortable item);

        public abstract bool Load(List<IPortable> items);

        public abstract bool Unload();

        public abstract bool Unload(IPortable item);

        public abstract bool Unload(List<IPortable> items);

        public abstract bool IsHaveRoom(double volume);

        public abstract bool IsOverload(double weight);


        public abstract double GetMaxVolume();

        public abstract double GetMaxWeight();

        public abstract double GetCurrentVolume();

        public abstract double GetCurrentWeight();
    }
}
