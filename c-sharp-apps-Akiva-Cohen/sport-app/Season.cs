using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class Season
    {
        private int year;
        private string type;
        private string leagueName;
        private int roundAmount;
        private Round nextRound;
        private Team[] teams;
        private int numOfGroups;
        private bool active;

        public void DisplayTable()
        {
            for (int i = 0; i < numOfGroups; i++)
                Console.WriteLine($"{i} - {teams[i].GetName()} - {teams[i].GetPoints()}");
        }
    }
}
