using c_sharp_apps_Akiva_Cohen.TransportationApp.Inters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Abs
{
    public abstract class StorageStructure : IContainable
    {
        private string country;
        private string city;
        private string street;
        private int num;

        private List<IPortable> portables;
        private readonly int maxNumPortables;

        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int Num { get => num; set => num = value; }

        public List<IPortable> Portables { get => portables; }
        public int MaxNumPortables { get => maxNumPortables; }

        protected StorageStructure(string country, string city, string street, int num, int maxNumPortables)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Num = num;

            this.maxNumPortables = maxNumPortables;
            this.portables = new List<IPortable>(MaxNumPortables);
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
