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

        public string GetName() { return name; }
        public string GetCity() { return city; }
        public string GetCurrentLeague() { return currentLeague; }
        public int GetTotalGames() { return totalGames; }
        public int GetGamesPlayed() { return gamesPlayed; }
        public int GetVictories() { return victories; }
        public int GetLosses() { return losses; }
        public int GetDraw() { return draw; }
        public int GetPoints() { return points; }
        public int GetGoalsFor() { return goalsFor; }
        public int GetGoalsAgainst() { return goalsAgainst; }
        public int GetGoalsDifferential() { return goalsDifferential; }

        public void SetName(string name) { this.name = name; }
        public void SetCity(string city) { this.city = city; }
        public void SetCurrentLeague(string currentLeague) { this.currentLeague = currentLeague; }

    }
}
