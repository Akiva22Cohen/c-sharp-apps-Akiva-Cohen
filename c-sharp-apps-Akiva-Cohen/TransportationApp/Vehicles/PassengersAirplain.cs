using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Vehicles
{
    public class PassengersAirplain : PublicVehicle
    {
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;

        public PassengersAirplain() { }

        public PassengersAirplain(int line, int id, int enginesNum, int wingLength, int rows, int columns) : base(line, id)
        {
            this.EnginesNum = enginesNum;
            this.WingLength = wingLength;
            this.Rows = rows;
            this.Columns = columns;

            Seats = this.Rows * this.Columns;
        }

        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

        public override int MaxSpeed { get => maxSpeed; set { maxSpeed = (value > 1000) ? maxSpeed : value; } }

        public override bool CalculateHasRoom() { return CurrentPassengers < (Seats - 7); }

        public override void UploadPassengers(int uploadPassengers)
        {
            if (CalculateHasRoom())
            {
                int total = CurrentPassengers + uploadPassengers;
                if (total < (Seats - 7))
                    CurrentPassengers = total;
                else
                {
                    CurrentPassengers += (Seats - 7) - CurrentPassengers;
                    RejecetedPassengers = total - (Seats - 7);
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
            return base.ToString() + $"\nWing length: {wingLength}\n" +
                                        $"Number of engines: {enginesNum}\n" +
                                        $"rows/columns: {rows}/{columns}";
        }
    }
}
