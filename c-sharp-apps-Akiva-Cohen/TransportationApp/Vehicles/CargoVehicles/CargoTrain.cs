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
        private double maxVolume;
        private double maxWeight;
        private double currentVolume;
        private double currentWeight;
        CargoCrone[] cargoCrones;

        public CargoTrain(double maxVolume, double maxWeight, int numCrone)
        {
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;

            currentVolume = 0.0;
            currentWeight = 0.0;

            cargoCrones = new CargoCrone[numCrone];
            for (int i = 0; i < numCrone; i++)
                cargoCrones[i] = new CargoCrone(this.maxVolume / numCrone, this.maxWeight / numCrone);
        }

        public CargoCrone CargoCrones { get => CargoCrones; }
        public double MaxVolume { get => maxVolume; set => maxVolume = value; }
        public double MaxWeight { get => maxWeight; set => maxWeight = value; }
        public double CurrentVolume { get => currentVolume; set => currentVolume = (value > maxVolume) ? maxVolume : (value < 0) ? 0 : value; }
        public double CurrentWeight { get => currentWeight; set => currentWeight = (value > maxWeight) ? maxWeight : (value < 0) ? 0 : value; }


        public override bool Load(IPortable item)
        {
            for (int i = 0; i < cargoCrones.Length; i++)
            {
                if (cargoCrones[i].IsHaveRoom(item.GetVolume()) && cargoCrones[i].IsOverload(item.GetWeight()))
                {
                    cargoCrones[i].Load(item);
                    return cargoCrones[i].Portables.Contains(item);
                }
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
            for (int i = 0; i < cargoCrones.Length; i++)
                if (!cargoCrones[i].Unload()) 
                    return false;

            return true;
        }

        public override bool Unload(IPortable item)
        {
            for (int i = 0; i < cargoCrones.Length; i++)
            {
                if (cargoCrones[i].Portables.Contains(item))
                {
                    if (cargoCrones[i].Unload(item))
                    {
                        CurrentVolume -= item.GetVolume();
                        CurrentWeight -= item.GetWeight();
                    }
                    return cargoCrones[i].Portables.Contains(item);
                }
            }
            return false;
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
