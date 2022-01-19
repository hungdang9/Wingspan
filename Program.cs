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
        FnG,
        GnW,
        FnW,
        FnGnW,
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

    enum NestEnum
    {
        Platform,
        Ground,
        Cavity,
        Bowl,
    }

    enum FoodEnum
    { 
        Invertebrate,
        Seed,
        Fruit,
        Rodent,
        Fish,
    }
    internal class Card
    {

        private HabitatEnum _habitat;
        private PowerEnum _power;
        private NestEnum _nest;

        public Card(HabitatEnum habitat, PowerEnum power, NestEnum nest)
        {
            this._habitat = habitat;
            this._power = power;
            this._nest = nest;
        }

        public HabitatEnum GetHabitat()
        {
            return this._habitat;
        }

        public PowerEnum GetPower()
        {
            return this._power;
        }

      
    }
    internal class Program
    {
        static void Main(string[] args);
        {
            
}

    }
}