using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Inters
{
    public interface IContainable
    {
        bool Load(IPortable item);

        bool Load(List<IPortable> items);

        bool Unload();

        bool Unload(IPortable item);

        bool Unload(List<IPortable> items);

        bool IsHaveRoom();

        bool IsOverload();


        double GetMaxVolume();

        double GetMaxWeight();

        double GetCurrentVolume();

        double GetCurrentWeight();
    }
}
