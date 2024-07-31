using c_sharp_apps_Akiva_Cohen.TransportationApp.Abs;
using c_sharp_apps_Akiva_Cohen.TransportationApp.Inters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles.CargoVehicles
{
    public class CargoTrain : CargoVehicle
    {
        private List<IPortable> portables;

        private double maxVolume;
        private double maxWeight;
        private double currentVolume;
        private double currentWeight;


        public List<IPortable> Portables { get => portables; }
        public double MaxVolume { get => maxVolume; set => maxVolume = value; }
        public double MaxWeight { get => maxWeight; set => maxWeight = value; }
        public double CurrentVolume { get => currentVolume; set => currentVolume = (value > maxVolume) ? maxVolume : (value < 0) ? 0 : value; }
        public double CurrentWeight { get => currentWeight; set => currentWeight = (value > maxWeight) ? maxWeight : (value < 0) ? 0 : value; }


        public override bool Load(IPortable item)
        {
            if (IsHaveRoom(item.GetVolume()) && IsOverload(item.GetWeight()))
            {
                portables.Add(item);
                CurrentVolume += item.GetVolume();
                CurrentWeight += item.GetWeight();
                return true;
            }
            return false;
        }

        public override bool Load(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
                if (!Load(items[i]))
                    return false;

            return true;
        }

        public override bool Unload()
        {
            for (int i = 0; i < portables.Count; i++)
                if (!Unload(portables[i]))
                    return false;

            return true;
        }

        public override bool Unload(IPortable item)
        {
            portables.Remove(item);
            CurrentVolume -= item.GetVolume();
            CurrentWeight -= item.GetWeight();
            return !portables.Contains(item);
        }

        public override bool Unload(List<IPortable> items)
        {
            for (int i = 0; i < items.Count; i++)
                if (!Unload(items[i]))
                    return false;

            return true;
        }

        public override bool IsHaveRoom(double volume) { return (CurrentVolume + volume) < MaxVolume; }

        public override bool IsOverload(double weight) { return (CurrentWeight + weight) < MaxWeight; }


        public override double GetMaxVolume() { return MaxVolume; }

        public override double GetMaxWeight() { return MaxWeight; }

        public override double GetCurrentVolume() { return CurrentVolume; }

        public override double GetCurrentWeight() { return CurrentWeight; }
    }
}
