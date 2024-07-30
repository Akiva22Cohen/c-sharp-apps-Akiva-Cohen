using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.TransportationApp.Abs;

namespace c_sharp_apps_Akiva_Cohen.TransportationApp.Inters
{
    public interface IPortable
    {
        double GetArea();

        int[] GetSize();

        double GetVolume();

        double GetWeight();

        void PackageItem();

        bool IsPackaged();

        void UnPackage();

        bool IsFragile();

        StorageStructure GetLocation();

        bool IsLoaded();
    }
}
