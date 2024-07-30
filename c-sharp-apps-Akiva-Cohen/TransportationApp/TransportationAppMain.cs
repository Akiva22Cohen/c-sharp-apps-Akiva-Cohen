using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class TransportationAppMain
    {
        public static void MainEntry()
        {
            PublicVehicle[] publicVehicles =
            {
                new PublicVehicle(24, 3779444, 40, 10),
                new Bus(14, 3300465, 100, 19, 3),
                new PassengersTrain(257, 1552065, 361, new Crone(14, 4), 4),
                new PassengersAirplain(577, 9621316, 5, 10, 50, 3),
                new Bus(28, 9792974, 119, 20, 2)
            };
            MonitorTransportation.Test1();
            //MonitorTransportation.MyTest();
            //Console.WriteLine("Number of passenger planes: " + MonitorTransportation.CountPlains(publicVehicles));
        }
    }
}
