using System;
using CookingConversions.Enums;

namespace CookingConversions.Extensions
{
    public static class TemperatureExtensions
    {
        public static Temperature ToCelcius(this Temperature temperature)
        {
            switch (temperature.TemperatureSystem)
            {
                case TemperatureSystem.Celcius:
                    return temperature;
                case TemperatureSystem.Farenheit:
                    temperature.Degrees = (temperature.Degrees - 32) / (decimal)1.8;
                    temperature.TemperatureSystem = TemperatureSystem.Celcius;
                    return temperature;
                case TemperatureSystem.Kelvin:
                    temperature.Degrees = temperature.Degrees - (decimal)273.15;
                    temperature.TemperatureSystem = TemperatureSystem.Celcius;
                    return temperature;
                default:
                    throw new NotImplementedException();
            }
        }

        public static Temperature ToFarenheit(this Temperature temperature)
        {
            switch (temperature.TemperatureSystem)
            {
                case TemperatureSystem.Farenheit:
                    return temperature;
                case TemperatureSystem.Celcius:
                    temperature.Degrees = temperature.Degrees * (decimal)1.8 + 32;
                    temperature.TemperatureSystem = TemperatureSystem.Farenheit;
                    return temperature;
                case TemperatureSystem.Kelvin:
                    temperature.Degrees = temperature.Degrees * (decimal)1.8 - (decimal)457.67;
                    temperature.TemperatureSystem = TemperatureSystem.Farenheit;
                    return temperature;
                default:
                    throw new NotImplementedException();
            }
        }

        public static Temperature ToKelvin(this Temperature temperature)
        {
            switch (temperature.TemperatureSystem)
            {
                case TemperatureSystem.Kelvin:
                    return temperature;
                case TemperatureSystem.Farenheit:
                    temperature.Degrees = (temperature.Degrees + (decimal) 459.67) * ((decimal)5 / 9);
                    temperature.TemperatureSystem = TemperatureSystem.Kelvin;
                    return temperature;
                case TemperatureSystem.Celcius:
                    temperature.Degrees = temperature.Degrees + (decimal) 273.15;
                    temperature.TemperatureSystem = TemperatureSystem.Kelvin;
                    return temperature;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}