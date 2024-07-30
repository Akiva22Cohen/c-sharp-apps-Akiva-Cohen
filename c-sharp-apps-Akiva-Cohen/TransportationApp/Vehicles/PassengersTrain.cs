using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone[] crones = null;
        private int cronesAmount = 0;

        public PassengersTrain() { }

        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount) : base(line, id, maxSpeed)
        {
            this.Crones = new Crone[cronesAmount];
            for (int i = 0; i < Crones.Length; i++)
                Crones[i] = new Crone(crone);
            Seats = NumOfSeats();
        }

        public override int MaxSpeed { get => maxSpeed; set { maxSpeed = (value > 300) ? maxSpeed : value; } }

        public Crone[] Crones { get => crones; set => crones = value; }
        public int CronesAmount { get => cronesAmount; set => cronesAmount = value; }

        public int NumOfSeats()
        {
            int numOfSeats = 0;
            foreach (Crone crone in Crones)
                numOfSeats += crone.GetSeats();
            return numOfSeats;
        }

        public int MaxNumberOfPassengers()
        {
            int maxNumberOfPassengers = 0;
            foreach (Crone crone in Crones)
                maxNumberOfPassengers += crone.GetExtras();
            return maxNumberOfPassengers + NumOfSeats();
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
            return base.ToString() + $"\nNumber of train cars: {CronesAmount}";
        }
    }
}
