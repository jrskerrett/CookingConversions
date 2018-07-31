using System;
using System.Collections.Generic;
using System.Text;
using CookingConversions.Enums;
using CookingConversions.Interfaces;

namespace CookingConversions
{
    public class Salt : BaseDryIngredient
    {
        public Salt(decimal quantity, DryMeasurement measurement, SaltType type)
        {
            Quantity = quantity;
            Measurement = measurement;
            SaltType = type;
        }

        private Salt() { }
        public SaltType SaltType { get; set; }

        /// <summary>
        /// How many grams per cup per type of salt.
        /// Defaults to table salt.
        /// </summary>
        private decimal GramsPerCup
        {
            get
            {
                switch (SaltType)
                {
                    case SaltType.FineSea: return (decimal)233.6;
                    case SaltType.Maldon: return (decimal)134.4;
                    case SaltType.SelGris: return (decimal)208;
                    case SaltType.MortonTable: return (decimal)297.6;
                    case SaltType.MortonKosher: return (decimal)236;
                    case SaltType.DiamondKosher: return (decimal)156;
                    default: return (decimal)297.6;
                }
            }
        }
    }
}
