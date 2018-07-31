using System;
using System.Collections.Generic;
using System.Text;
using CookingConversions.Enums;
using CookingConversions.Interfaces;

namespace CookingConversions
{
    public class Sugar : BaseDryIngredient
    {
        public Sugar(decimal quantity, DryMeasurement measurement, SugarType type)
        {
            Quantity = quantity;
            Measurement = measurement;
            SugarType = type;
        }

        private Sugar() {}
        public SugarType SugarType { get; set; }

        public decimal GramsPerCup
        {
            get
            {
                switch (SugarType)
                {
                    case SugarType.Granulated: return 200;
                    case SugarType.Confectioners: return 125;
                    case SugarType.Caster: return 225;
                    case SugarType.Turbinado: return 220;
                    case SugarType.DarkBrown: return 230;
                    case SugarType.LightBrown: return 215;
                    case SugarType.Cane: return 250;
                    default: return 200;
                }
            }
        }
    }
}
