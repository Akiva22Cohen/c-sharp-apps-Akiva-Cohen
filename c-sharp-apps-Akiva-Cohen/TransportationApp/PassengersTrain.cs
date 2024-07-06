using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone[] crones = null;
        private int cronesAmount = 0;

        public PassengersTrain() { }

        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount) : base(line, id, maxSpeed)
        {
            this.crones = new Crone[cronesAmount];
            for (int i = 0; i < crones.Length; i++)
                crones[i] = new Crone(crone);
            base.Seats = MaxNumberOfPassengers();
        }

        protected override int MaxSpeed { get => base.MaxSpeed; set { base.MaxSpeed = (value > 300) ? 300 : value; } }

        public int MaxNumberOfPassengers()
        {
            int maxNumberOfPassengers = 0;
            foreach (Crone crone in crones)
                maxNumberOfPassengers += crone.GetSeats() + crone.GetExtras();
            return maxNumberOfPassengers;
        }

        public override bool CalculateHasRoom() { return CurrentPassengers < MaxNumberOfPassengers(); }

        public override void UploadPassengers(int uploadPassengers)
        {
            int maxNumberOfPassengers = MaxNumberOfPassengers();
            if (CalculateHasRoom())
            {
                int total = CurrentPassengers + uploadPassengers;
                if (total < maxNumberOfPassengers)
                    CurrentPassengers = total;
                else
                {
                    CurrentPassengers += maxNumberOfPassengers - CurrentPassengers;
                    RejecetedPassengers = total - maxNumberOfPassengers;
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
            return base.ToString() + $"\nclass PassengersTrain:\nNumber of train cars: {cronesAmount}";
        }
    }
}
