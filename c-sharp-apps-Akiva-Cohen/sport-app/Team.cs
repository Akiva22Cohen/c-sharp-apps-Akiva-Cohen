using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class Team
    {
        private string name; // שם
        private string city; // עיר
        private string currentLeague; // ליגה נוכחית
        private int totalGames; // סה''כ משחקים
        private int gamesPlayed = 0; // משחקים ששוחקו
        private int victories = 0; // נצחונות
        private int losses = 0; // הפסדים
        private int draw = 0; // תיקו
        private int points = 0; // נקודות
        private int goalsFor = 0; // שערים
        private int goalsAgainst = 0; // שערים בחובה
        private int goalsDifferential = 0; // הפרש שערים

        public Team(string name, string city)
        {
            this.name = name;
            this.city = city;
        }


        // מתודות קבלה
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


        // מתודות הגדרה
        public void SetName(string name) { this.name = name; }
        public void SetCity(string city) { this.city = city; }
        public void SetCurrentLeague(string currentLeague) { this.currentLeague = currentLeague; }
        public void SetPoints(int points) { this.points = points; }


        // מתודות עדכונים
        // הפעולות פרטיות לשימוש פרטי בלבד
        // מעדכן משחקים ששוחקו
        private void UpdateGamesPlayed() { this.gamesPlayed = this.victories + this.draw + this.losses; }
        // מעדכן נקודות
        private void UpdatePoints() { this.points = this.victories * 3 + this.draw; }
        // מעדכן הפרש שערים
        private void UpdateGoalsDifferential() { this.goalsDifferential = this.goalsFor - this.goalsAgainst; }


        // מתודות הוספה
        // מתודות הוספה כוללות בתוכם מתודות עדכונים בהתאם
        public void AddVictories(int victories = -1)
        {
            if (victories == -1)
                this.victories++;
            else
                this.victories = victories;

            UpdateGamesPlayed();
            UpdatePoints();
        }


        public void AddDraw(int draw = -1)
        {
            if (draw == -1)
                this.draw++;
            else
                this.draw = draw;

            UpdateGamesPlayed();
            UpdatePoints();
        }

        public void AddLosses(int losses = -1)
        {
            if (losses == -1)
                this.losses++;
            else
                this.losses = losses;

            UpdateGamesPlayed();
        }

        public void AddGoalsFor(int goalsFor, string mode = "add")
        {
            if (mode.Equals("add"))
                this.goalsFor += goalsFor;
            else if (mode.Equals("set"))
                this.goalsFor = goalsFor;

            UpdateGoalsDifferential();
        }

        public void AddGoalsAgainst(int goalsAgainst, string mode = "add")
        {
            if (mode.Equals("add"))
                this.goalsAgainst += goalsAgainst;
            else if (mode.Equals("set"))
                this.goalsAgainst = goalsAgainst;

            UpdateGoalsDifferential();
        }
    }
}
