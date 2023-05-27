using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    internal class Bus : PublicTransport
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
                return "Автобус не вышел на маршрут";
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
                    return "В автобусе никого нет";
                }
            }
            else
            {
                return "Автобус не вышел на маршрут";
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
