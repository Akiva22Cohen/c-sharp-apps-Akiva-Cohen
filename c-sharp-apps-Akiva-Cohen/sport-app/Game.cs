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

        public Game(Team groupA, Team groupB, int groupANumGoals, int groupBNumGoals
            , int currentMinute, bool activeGame)
        {
            this.groupA = groupA;
            this.groupB = groupB;
            this.groupANumGoals = groupANumGoals;
            this.groupBNumGoals = groupBNumGoals;
            this.currentMinute = currentMinute;
            this.activeGame = activeGame;
        }
    }
}
