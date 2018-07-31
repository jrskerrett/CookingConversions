using System;
using System.Collections.Generic;
using System.Text;
using CookingConversions.Enums;

namespace CookingConversions
{
    public class Temperature
    {
        public Temperature(decimal degrees, TemperatureSystem temperatureSystem)
        {
            Degrees = degrees;
            TemperatureSystem = temperatureSystem;
        }

        private Temperature() {}

        public decimal Degrees { get; set; }
        public TemperatureSystem TemperatureSystem { get; set; }
    }
}
