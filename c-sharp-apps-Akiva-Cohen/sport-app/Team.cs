using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class Team
    {
        private string name;
        private string city;
        private string currentLeague;
        private int totalGames;
        private int gamesPlayed;
        private int victories;
        private int losses;
        private int draw;
        private int points;
        private int goalsFor;
        private int goalsAgainst;
        private int goalsDifferential;

        Team(string name, string city, string currentLeage)
        {
            this.name = name;
            this.city = city;
            this.currentLeague = currentLeage;
        }
    }
}
