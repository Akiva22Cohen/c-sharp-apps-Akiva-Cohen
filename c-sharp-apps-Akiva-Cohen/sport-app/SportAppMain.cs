using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class SportAppMain
    {
        public static void MainEntry()
        {
            Random rnd = new Random();
            Season[] groups = TestSportApp.CreateChampionsLeagueMock();

            Team[] teams;
            Game game;
            foreach (Season season in groups)
            {
                teams = season.GetTeam();
                foreach (Team groupA in teams)
                {
                    foreach (Team groupB in teams)
                    {
                        if (groupA != groupB)
                        {
                            int groupANumGoals = rnd.Next(6),
                                groupBNumGoals = rnd.Next(6);
                            game = new Game(groupA, groupB, rnd.Next(5), rnd.Next(5), 90, false);
                            game.FinishGame();
                        }
                    }
                }
            }

            TestSportApp.PrintAllGroup(groups);

            //Random rnd = new Random();
            //Season[] groups = TestSportApp.CreateChampionsLeagueMock();

            //Team[] teams = groups[0].GetTeam();
            //Game game1 =    new Game(teams[1], teams[2], 2, 2, 90, false),
            //     game2 =    new Game(teams[0], teams[3], 4, 3, 90, false),
            //     game3 =    new Game(teams[3], teams[2], 2, 3, 90, false),
            //     game4 =    new Game(teams[1], teams[0], 1, 2, 90, false),
            //     game5 =    new Game(teams[2], teams[0], 1, 3, 90, false),
            //     game6 =    new Game(teams[3], teams[1], 1, 0, 90, false),
            //     game7 =    new Game(teams[0], teams[2], 2, 1, 90, false),
            //     game8 =    new Game(teams[1], teams[3], 4, 3, 90, false),
            //     game9 =    new Game(teams[2], teams[3], 3, 3, 90, false),
            //     game10 =   new Game(teams[0], teams[1], 0, 0, 90, false),
            //     game11 =   new Game(teams[3], teams[0], 0, 1, 90, false),
            //     game12 =   new Game(teams[1], teams[2], 1, 0, 90, false);

            //game1.FinishGame();
            //game2.FinishGame();
            //game3.FinishGame();
            //game4.FinishGame();
            //game5.FinishGame();
            //game6.FinishGame();
            //game7.FinishGame();
            //game8.FinishGame();
            //game9.FinishGame();
            //game10.FinishGame();
            //game11.FinishGame();
            //game12.FinishGame();


            //groups[0].DisplayTable();
        }
    }
}
