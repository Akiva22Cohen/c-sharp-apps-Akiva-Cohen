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

        public Season(int year, string type, string leagueName, Team[] teams)
        {
            this.year = year;
            this.type = type;
            this.leagueName = leagueName;
            this.teams = teams;
            numOfGroups = teams.Length;
        }

        public void DisplayTable()
        {
            Console.WriteLine(leagueName);
            Console.WriteLine(" --------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("|{0,-20} | {1,-6}| {2, -6} | {3,-6} | {4,-6} | {5,-6} | {6,-8} | {7,-15} | {8, -6} |", "Team", "Played", "Won", "Drawn", "Lost", "For", "Against", "Goal difference", "Points"));
            Console.WriteLine(" --------------------------------------------------------------------------------------------------------");
            foreach (Team t in teams)
            {
                Console.WriteLine(String.Format("|{0,-20} | {1,-6}| {2, -6} | {3,-6} | {4,-6} | {5,-6} | {6,-8} | {7,-15} | {8, -6} |", t.GetName(), t.GetGamesPlayed(), t.GetVictories(), t.GetDraw(), t.GetLosses(), t.GetGoalsFor(), t.GetGoalsAgainst(), t.GetGoalsDifferential(), t.GetPoints()));
            }
            Console.WriteLine(" --------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        public Team[] GetTeam() { return teams; }
    }
}
