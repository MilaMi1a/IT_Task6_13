using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    internal class Tram : PublicTransport
    {

        public int numberVagons;
        public int crewCount;
        public int countPassangerInVagon;

        public override string addPassangers()
        {
            if (isDriving)
            {
                if (numberPassengers < numberVagons * countPassangerInVagon)
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
                return "Трамвай не вышел на маршрут";
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
                    return "В трамвае никого нет";
                }
            }
            else
            {
                return "Трамвай не вышел на маршрут";
            }
        }

        public string addVagon()
        {
            numberVagons++;
            return $"Теперь вагонов {numberVagons}";
        }

        public string removeVagon()
        {
            if (numberVagons > 0)
            {
                numberVagons--;
                return $"Теперь вагонов {numberVagons}";
            }
            else
            {
                return "У трамвая больше нет вагонов";
            }
        }
    }
}