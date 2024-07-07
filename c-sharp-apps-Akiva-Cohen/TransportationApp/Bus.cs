using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class Bus : PublicVehicle
    {
        private readonly int doors;
        private bool bellStop = false;

        public Bus() { }

        public Bus(int line, int id, int maxSpeed, int seats, int doors) : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }

        public int Doors => doors;
        public bool BellStop { get => bellStop; set => bellStop = value; }
        public override int MaxSpeed { get => maxSpeed; set { maxSpeed = (value > 120) ? maxSpeed : value; } }

        public override bool CalculateHasRoom() { return CurrentPassengers < Math.Round(Seats * 1.1); }

        public override void UploadPassengers(int uploadPassengers)
        {
            if (CalculateHasRoom())
            {
                int total = CurrentPassengers + uploadPassengers;
                if (total < Math.Round(Seats * 1.1))
                    CurrentPassengers = total;
                else
                {
                    CurrentPassengers += ((int)Math.Round(Seats * 1.1)) - CurrentPassengers;
                    RejecetedPassengers = total - ((int)Math.Round(Seats * 1.1));
                    HasRoom = false;
                }
            }
            else
            {
                Console.WriteLine("The vehicle is full");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nThere are {Doors} doors.\n" +
                                        $"Stop bell {(BellStop ? "" : "not")} pressed.";
        }

    }
}
