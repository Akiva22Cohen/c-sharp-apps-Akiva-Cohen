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

        public Season(int year, string type, string leagueName, int roundAmount, Round nextRound, Team[] teams, int numOfGroups, bool active)
        {
            this.year = year;
            this.type = type;
            this.leagueName = leagueName;
            this.teams = teams;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < numOfGroups; i++)
                Console.WriteLine($"{i + 1} - {teams[i].GetName()} - {teams[i].GetPoints()}");
        }
    }
}
