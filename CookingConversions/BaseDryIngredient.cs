using System;
using System.Collections.Generic;
using System.Text;
using CookingConversions.Enums;
using CookingConversions.Interfaces;

namespace CookingConversions
{
    public class BaseDryIngredient : IDryIngredient
    {
        public decimal Quantity { get; set; }
        public DryMeasurement Measurement { get; set; }


        public void Convert(DryMeasurement destination)
        {
            switch (destination)
            {
                case DryMeasurement.Cup:
                    ConvertFromCup(destination);
                    break;
                case DryMeasurement.Tablespoon:
                    ConvertFromTablespoon(destination);
                    break;
                case DryMeasurement.Teaspoon:
                    ConvertFromTeaspoon(destination);
                    break;
                case DryMeasurement.Pinch:
                    ConvertFromPinch(destination);
                    break;
                case DryMeasurement.Dash:
                    ConvertFromDash(destination);
                    break;
            }
        }

        private void ConvertFromCup(DryMeasurement destination)
        {
            if (destination == DryMeasurement.Cup)
            {
                return;
            }
            switch (destination)
            {
                case DryMeasurement.Tablespoon:
                    Quantity = Quantity * 16;
                    break;
                case DryMeasurement.Teaspoon:
                    Quantity = Quantity * 48;
                    break;
                case DryMeasurement.Pinch:
                    Quantity = Quantity * 48 * 8;
                    break;
                case DryMeasurement.Dash:
                    Quantity = Quantity * 48 * 16;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromTablespoon(DryMeasurement destination)
        {
            if (destination == DryMeasurement.Tablespoon)
            {
                return;
            }
            switch (destination)
            {
                case DryMeasurement.Cup:
                    Quantity = Quantity /16;
                    break;
                case DryMeasurement.Teaspoon:
                    Quantity = Quantity * 3;
                    break;
                case DryMeasurement.Pinch:
                    Quantity = Quantity * 24;
                    break;
                case DryMeasurement.Dash:
                    Quantity = Quantity * 48;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromTeaspoon(DryMeasurement destination)
        {
            if (destination == DryMeasurement.Teaspoon)
            {
                return;
            }
            switch (destination)
            {
                case DryMeasurement.Cup:
                    Quantity = Quantity/48;
                    break;
                case DryMeasurement.Tablespoon:
                    Quantity = Quantity/3;
                    break;
                case DryMeasurement.Pinch:
                    Quantity = Quantity * 8;
                    break;
                case DryMeasurement.Dash:
                    Quantity = Quantity * 16;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromPinch(DryMeasurement destination)
        {
            if (destination == DryMeasurement.Pinch)
            {
                return;
            }
            switch (destination)
            {
                case DryMeasurement.Cup:
                    Quantity = Quantity/(24 * 16);
                    break;
                case DryMeasurement.Tablespoon:
                    Quantity = Quantity/24;
                    break;
                case DryMeasurement.Teaspoon:
                    Quantity = Quantity/8;
                    break;
                case DryMeasurement.Dash:
                    Quantity = Quantity * 2;
                    break;
            }
            Measurement = destination;
        }

        private void ConvertFromDash(DryMeasurement destination)
        {
            if (destination == DryMeasurement.Dash)
            {
                return;
            }
            switch (destination)
            {
                case DryMeasurement.Cup:
                    Quantity = Quantity/(16 * 72);
                    break;
                case DryMeasurement.Tablespoon:
                    Quantity = Quantity/72;
                    break;
                case DryMeasurement.Teaspoon:
                    Quantity = Quantity/24;
                    break;
                case DryMeasurement.Pinch:
                    Quantity = Quantity/2;
                    break;
            }
            Measurement = destination;
        }
    }
}
