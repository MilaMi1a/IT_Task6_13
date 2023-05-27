using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public abstract class PublicTransport : TransportVehicle
    {
        public bool isDriving { get; set; }

    public int numberPassengers = 0;
    public int numberRoute = 0;

    public string go()
    {
        isDriving = true;
        return "Движение началось";
    }

    public string stop()
    {
        isDriving = false;
        return "Движение закончилось";
    }

    public abstract string addPassangers();

    public abstract string removePassangers();

    public abstract string changeRoute(int newNumber);
}
}
