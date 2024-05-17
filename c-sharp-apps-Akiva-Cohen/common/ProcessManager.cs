using c_sharp_apps_Akiva_Cohen.bank_app;
using c_sharp_apps_Akiva_Cohen.draft_app;
using c_sharp_apps_Akiva_Cohen.sport_app;
using c_sharp_apps_Akiva_Cohen.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.common
{
    public class ProcessManager
    {
        public static void RunMainProcess()
        {
            char ch;
            do
            {
                Console.WriteLine("1 – Bank App\n2 – Sport App\n3 – Transportation App" +
                    "\n4 – Draft App\n0 - Exit");
                ch = Console.ReadLine()[0];
                switch(ch)
                {
                    case '1':
                        BankAppMain.MainEntry();
                        break;
                    case '2':
                        SportAppMain.MainEntry();
                        break;
                    case '3':
                        TransportationAppMain.MainEntry();
                        break;
                    case '4':
                        DraftAppMain.MainEntry();
                        break;
                    case '0':
                        break;
                }
            } while (ch != '0') ;
        }
    }
}
