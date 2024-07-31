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

        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int Num { get => num; set => num = value; }        

        protected StorageStructure(string country, string city, string street, int num)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Num = num;
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
