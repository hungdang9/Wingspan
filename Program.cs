// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wingspan
{
    enum HabitatEnum
    {
        Forest,
        Grassland,
        Wetland,
    }

    enum PowerEnum
    {
        WhenPlayed,
        WhenActivated,
        OnceBetweenTurns,
        RoundEnd,
        GameEnd,
        None
    }
    internal class Card
    {

        private HabitatEnum _habitat;

        public Card(HabitatEnum habitat)
        {
            this._habitat = habitat;
        }

        public HabitatEnum GetHabitat()
        {
            return this._habitat;
        }

        private PowerEnum _power;

        public Card(PowerEnum power)
        {
            this._power = power;
        }

        public PowerEnum GetPower()
        {
            return this._power;
        }

        public Card(HabitatEnum habitat, PowerEnum power)
        {
            this._habitat = habitat;
            this._power = power;
        }
    }
    internal class Program
    {
        static void Main(string[] args);
        {
            
}

    }
}