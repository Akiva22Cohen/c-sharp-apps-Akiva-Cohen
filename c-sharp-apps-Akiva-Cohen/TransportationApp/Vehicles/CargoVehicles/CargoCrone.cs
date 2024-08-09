using c_sharp_apps_Akiva_Cohen.TransportationApp.Inters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles.CargoVehicles
{
    public class CargoCrone : IContainable
    {
        private List<IPortable> portables;

        private double maxVolume;
        private double maxWeight;
        private double currentVolume;
        private double currentWeight;

        public CargoCrone(double maxVolume, double maxWeight)
        {
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;

            currentVolume = 0.0;
            currentWeight = 0.0;

            portables = new List<IPortable>();
        }

        public List<IPortable> Portables { get => portables; }
        public double MaxVolume { get => maxVolume; set => maxVolume = value; }
        public double MaxWeight { get => maxWeight; set => maxWeight = value; }
        public double CurrentVolume { get => currentVolume; set => currentVolume = (value > maxVolume) ? maxVolume : (value < 0) ? 0 : value; }
        public double CurrentWeight { get => currentWeight; set => currentWeight = (value > maxWeight) ? maxWeight : (value < 0) ? 0 : value; }


        public bool Load(IPortable item)
        {
            if (IsHaveRoom(item.GetVolume()) && IsOverload(item.GetWeight()))
            {
                portables.Add(item);
                CurrentVolume += item.GetVolume();
                CurrentWeight += item.GetWeight();
            }
            return portables.Contains(item);
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
            for (int i = 0; i < portables.Count; i++)
                if (!Unload(portables[i]))
                    return false;

            return true;
        }

        public bool Unload(IPortable item)
        {
            portables.Remove(item);
            CurrentVolume -= item.GetVolume();
            CurrentWeight -= item.GetWeight();
            return !portables.Contains(item);
        }

        public bool Unload(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
                if (!Unload(items[i]))
                    return false;

            return true;
        }

        public bool IsHaveRoom(double volume) { return (CurrentVolume + volume) < MaxVolume; }

        public bool IsOverload(double weight) { return (CurrentWeight + weight) < MaxWeight; }


        public double GetMaxVolume() { return MaxVolume; }

        public double GetMaxWeight() { return MaxWeight; }

        public double GetCurrentVolume() { return CurrentVolume; }

        public double GetCurrentWeight() { return CurrentWeight; }
    }
}
