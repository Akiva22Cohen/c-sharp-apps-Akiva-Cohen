using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class MonitorTransportation
    {
        public static void Test1()
        {
            //TODO: 

            //10 tests:

            //test max speed

            //test uplod some passenger and the currentPassengers after. 

            //cases that it's should be done. And not. 

            PublicVehicle publicVehicle = new PublicVehicle(64, 999, 25, 10);
            Console.WriteLine(publicVehicle);
            Console.WriteLine();

            Bus bus = new Bus(2, 88, 123, 130, 30);
            Console.WriteLine(bus);
            Console.WriteLine();

            PassengersTrain passengersTrain = new PassengersTrain(100, 321, 300, new Crone(8, 4), 10);
            Console.WriteLine(passengersTrain);
            Console.WriteLine();

            PassengersAirplain passengersAirplain = new PassengersAirplain();
            Console.WriteLine(passengersAirplain);
            Console.WriteLine();

        }
    }
}
