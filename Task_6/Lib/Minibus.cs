using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    internal class Minibus : PublicTransport
    {

        public string endStation = "Station";
        public int crewCount;
        public int countPassangerInBus;

        public override string addPassangers()
        {
            if (isDriving)
            {
                if (numberPassengers < countPassangerInBus)
                {
                    numberPassengers++;
                    return $"Теперь пассажиров {numberPassengers}";
                }
                else
                {
                    return "Мест нет";
                }
            }
            else
            {
                return "Маршрутка не приехала";
            }

        }

        public override string changeRoute(int newNumber)
        {
            numberRoute = newNumber;
            return $"Новый маршрут {numberRoute}";
        }

        public override string removePassangers()
        {
            if (isDriving)
            {
                if (numberPassengers > 0)
                {
                    numberPassengers--;
                    return $"Теперь пассажиров {numberPassengers}";
                }
                else
                {
                    return "В маршрутке никого нет";
                }
            }
            else
            {
                return "Маршрутка не приехала";
            }
        }

        public string newEndStation(string station)
        {
            endStation = station;
            return $"Конечная станция изменилась: {endStation}";
        }

        public string getEndStation()
        {
            return $"Конечная станция: {endStation}";
        }
    }
}
