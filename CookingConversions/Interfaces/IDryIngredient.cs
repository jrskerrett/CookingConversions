using CookingConversions.Enums;

namespace CookingConversions.Interfaces
{
    public interface IDryIngredient
    {
        decimal Quantity { get; set; }
        DryMeasurement Measurement { get; set; }
    }
}