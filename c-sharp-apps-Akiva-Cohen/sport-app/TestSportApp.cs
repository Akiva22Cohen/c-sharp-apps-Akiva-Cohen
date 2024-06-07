using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class TestSportApp
    {
        public static Season[] CreateChampionsLeagueMock()
        {
            Season[] groups = new Season[8];

            //your code come here
            Team bayern = new Team("Bayern", "Bayern");








            return groups;
        }

        public static void Test1()
        {

            Console.WriteLine("Test 1 - champions league mock");
            Season[] groups = CreateChampionsLeagueMock();

            for (int i = 0; i < groups.Length; i++)
                groups[i].DisplayTable();

        }
    }
}
