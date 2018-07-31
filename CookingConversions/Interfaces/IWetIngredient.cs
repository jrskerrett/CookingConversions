using CookingConversions.Enums;

namespace CookingConversions.Interfaces
{
    public interface IWetIngredient
    {
        decimal Quantity { get; set; }
        WetMeasurement Measurement { get; set; }
    }
}