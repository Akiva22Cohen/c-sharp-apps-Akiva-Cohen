using c_sharp_apps_Akiva_Cohen.TransportationApp.Inters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Abs
{
    public class CargoVehicle: IContainable
    {
        private Driver driver;
        private double maxWeightAmount;
        private double maxVolumeAmount;
        private bool canDrive;
        private bool isOverload;
        private Port currentPort;
        private Port nextPort;
        private int idOfCurrentRide;
        List<IPortable> portables;
        private Dictionary<int, string> payment;
        private int travelDistance;


        public string GetPricingList()
        {
            return "";
        }


        public bool Load(IPortable item)
        {
            if (IsHaveRoom())
            {
                portables.Add(item);
                return true;
            }
            return false;
        }

        public bool Load(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
                if (!Load(items[i]))
                    return false;

            return true;
        }

        public bool Unload()
        {
            while (portables[0] != null)
                portables.Remove(portables[0]);
            return portables.Count == 0;
        }

        public bool Unload(IPortable item)
        {
            portables.Remove(item);
            return portables.Contains(item);
        }

        public bool Unload(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
                if (!Unload(items[i]))
                    return false;

            return true;
        }

        public bool IsHaveRoom() { return portables.Count < portables.Capacity; }

        public bool IsOverload()
        {
            return true;
        }


        public double GetMaxVolume()
        {
            return 0;
        }

        public double GetMaxWeight()
        {
            return 0;
        }

        public double GetCurrentVolume()
        {
            return 0;
        }

        public double GetCurrentWeight()
        {
            return 0;
        }
    }
}
