using System;
using System.Collections.Generic;
using System.Text;
using CookingConversions.Enums;
using CookingConversions.Interfaces;

namespace CookingConversions
{
    public class BaseWetIngredient : IWetIngredient
    {
        public decimal Quantity { get; set; }
        public WetMeasurement Measurement { get; set; }


        public void Convert(WetMeasurement destination)
        {
            switch (destination)
            {
                case WetMeasurement.Gallon:
                    ConvertFromGallon(destination);
                    break;
                case WetMeasurement.Quart:
                    ConvertFromQuart(destination);
                    break;
                case WetMeasurement.Pint:
                    ConvertFromPint(destination);
                    break;
                case WetMeasurement.Cup:
                    ConvertFromCup(destination);
                    break;
                case WetMeasurement.Ounce:
                    ConvertFromOunce(destination);
                    break;
            }
        }

        private void ConvertFromGallon(WetMeasurement destination)
        {
            if (destination == WetMeasurement.Gallon)
            {
                return;
            }
            switch (destination)
            {
                case WetMeasurement.Quart:
                    Quantity = Quantity * 4;
                    break;
                case WetMeasurement.Pint:
                    Quantity = Quantity * 8;
                    break;
                case WetMeasurement.Cup:
                    Quantity = Quantity * 16;
                    break;
                case WetMeasurement.Ounce:
                    Quantity = Quantity * 128;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromQuart(WetMeasurement destination)
        {
            if (destination == WetMeasurement.Quart)
            {
                return;
            }
            switch (destination)
            {
                case WetMeasurement.Gallon:
                    Quantity = Quantity /4;
                    break;
                case WetMeasurement.Pint:
                    Quantity = Quantity * 2;
                    break;
                case WetMeasurement.Cup:
                    Quantity = Quantity * 4;
                    break;
                case WetMeasurement.Ounce:
                    Quantity = Quantity * 32;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromPint(WetMeasurement destination)
        {
            if (destination == WetMeasurement.Pint)
            {
                return;
            }
            switch (destination)
            {
                case WetMeasurement.Gallon:
                    Quantity = Quantity/8;
                    break;
                case WetMeasurement.Quart:
                    Quantity = Quantity/2;
                    break;
                case WetMeasurement.Cup:
                    Quantity = Quantity * 2;
                    break;
                case WetMeasurement.Ounce:
                    Quantity = Quantity * 16;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromCup(WetMeasurement destination)
        {
            if (destination == WetMeasurement.Cup)
            {
                return;
            }
            switch (destination)
            {
                case WetMeasurement.Gallon:
                    Quantity = Quantity/16;
                    break;
                case WetMeasurement.Quart:
                    Quantity = Quantity/4;
                    break;
                case WetMeasurement.Pint:
                    Quantity = Quantity/2;
                    break;
                case WetMeasurement.Ounce:
                    Quantity = Quantity * 8;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromOunce(WetMeasurement destination)
        {
            if (destination == WetMeasurement.Ounce)
            {
                return;
            }
            switch (destination)
            {
                case WetMeasurement.Gallon:
                    Quantity = Quantity/128;
                    break;
                case WetMeasurement.Quart:
                    Quantity = Quantity/32;
                    break;
                case WetMeasurement.Pint:
                    Quantity = Quantity/16;
                    break;
                case WetMeasurement.Cup:
                    Quantity = Quantity/8;
                    break;
            }
            Measurement = destination;
        }
    }
}
