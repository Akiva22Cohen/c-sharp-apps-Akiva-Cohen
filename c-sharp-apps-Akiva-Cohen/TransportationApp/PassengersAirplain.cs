using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp
{
    public class PassengersAirplain : PublicVehicle
    {
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;

        public PassengersAirplain() { }
        public PassengersAirplain(int line, int id) : base(line, id) { }

        public PassengersAirplain(int enginesNum, int wingLength, int rows, int columns)
        {
            this.EnginesNum = enginesNum;
            this.WingLength = wingLength;
            this.Rows = rows;
            this.Columns = columns;

            base.Seats = this.Rows * this.Columns;
        }

        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

        protected override int MaxSpeed { get => base.MaxSpeed; set { base.MaxSpeed = (value > 1000) ? 1000 : value; } }

        public override bool CalculateHasRoom() { return CurrentPassengers < (base.Seats - 7); }

        public override void UploadPassengers(int uploadPassengers)
        {
            if (CalculateHasRoom())
            {
                int total = CurrentPassengers + uploadPassengers;
                if (total < (base.Seats - 7))
                    CurrentPassengers = total;
                else
                {
                    CurrentPassengers += (base.Seats - 7) - CurrentPassengers;
                    RejecetedPassengers = total - (base.Seats - 7);
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
            return base.ToString() + $"\nclass PassengersAirplain:\nWing length: {wingLength}\nNumber of engines: {enginesNum}\nrows/columns: {rows}/{columns}";
        }
    }
}
