using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public interface TransportVehicle
    {
        bool isDriving { get; set; }
        string go();

        string stop();
    }
}
