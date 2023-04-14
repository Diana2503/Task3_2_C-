using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2_C_
{
    internal class Engine
    {
        private String power;
        private String volume;
        private String fuel;

        public Engine(String power, String volume, String fuel)
        {
            this.power = power;
            this.volume = volume;
            this.fuel = fuel;
        }

        public String Power
        {
            get { return power; }
            set { power = value; }
        }

        public String Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public String Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public string GetInfoPower()
        {
            return power;
        }

        public string GetInfoVolume()
        {
            return volume;
        }

        public string GetInfoFuel()
        {
            return fuel;
        }
    }
}
