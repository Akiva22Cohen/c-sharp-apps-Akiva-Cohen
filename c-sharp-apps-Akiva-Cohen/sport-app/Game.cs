using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class Game
    {
        private Team groupA;
        private Team groupB;
        private int groupANumGoals;
        private int groupBNumGoals;
        private int currentMinute;
        private bool activeGame;

        public Game(Team groupA, Team groupB, int groupANumGoals, int groupBNumGoals, int currentMinute, bool activeGame)
        {
            this.groupA = groupA;
            this.groupB = groupB;
            this.groupANumGoals = groupANumGoals;
            this.groupBNumGoals = groupBNumGoals;
            this.currentMinute = currentMinute;
            this.activeGame = activeGame;
        }

        // מייצגת הבקעת גול, ע"י הקבוצה שמוגשת לה בתור פאראמטר.
        public void ScoreGoal(Team team)
        {
            if (team.GetName().Equals(groupA.GetName()))
                groupANumGoals++;
            else if (team.GetName().Equals(groupB.GetName()))
                groupBNumGoals++;
        }

        // עדכון קבוצה
        private void UpdateGroup(Team team, int goalsFor, int goalsAgainst)
        {
            team.AddGoalsFor(goalsFor);
            team.AddGoalsAgainst(goalsAgainst);

            if (goalsFor > goalsAgainst)
                team.AddVictories();
            else if (goalsFor < goalsAgainst)
                team.AddLosses();
            else
                team.AddDraw();
        }

        // סיום משחק
        // הפעולה מסיימת משחק ומעדכנת קבוצות
        public void FinishGame()
        {
            activeGame = false;

            UpdateGroup(groupA, groupANumGoals, groupBNumGoals);
            UpdateGroup(groupB, groupBNumGoals, groupANumGoals);
        }
    }
}
