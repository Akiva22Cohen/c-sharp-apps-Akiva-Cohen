using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles
{
    public class PublicVehicle
    {
        private int line = 0;
        private int id = 0;
        protected int maxSpeed = 0;
        private int currentPassengers = 0;
        private int seats = 0;
        private bool hasRoom = true;
        private int rejecetedPassengers = 0;

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public virtual int MaxSpeed { get => maxSpeed; set { maxSpeed = (value > 40) ? maxSpeed : value; } }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public int RejecetedPassengers { get => rejecetedPassengers; set => rejecetedPassengers = value; }

        public PublicVehicle() { }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.Line = line;
            this.Id = id;
            this.MaxSpeed = maxSpeed;
            this.Seats = seats;
        }

        public PublicVehicle(int line, int id)
        {
            this.Line = line;
            this.Id = id;
        }

        public PublicVehicle(int line, int id, int maxSpeed) : this(line, id)
        {
            this.MaxSpeed = maxSpeed;
        }

        public virtual bool CalculateHasRoom() { return CurrentPassengers < Seats; }

        public virtual void UploadPassengers(int uploadPassengers)
        {
            if (CalculateHasRoom())
            {
                int total = CurrentPassengers + uploadPassengers;
                if (total < Seats)
                    CurrentPassengers = total;
                else
                {
                    CurrentPassengers += Seats - CurrentPassengers;
                    RejecetedPassengers = total - Seats;
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
            return $"class {this.GetType().Name}:\n" +
                    $"Line {Line} contains {CurrentPassengers}/{Seats} passengers,\n" +
                    $"{rejecetedPassengers} passengers were rejected.\n" +
                    $"{(hasRoom ? "There is" : "No")} space available.\n" +
                    $"The maximum speed is {maxSpeed}.";
        }
    }
}
