using System.ComponentModel;

namespace CookingConversions.Enums
{
    public enum GasMark
    {
        Lowest = 0,

        [DisplayName("Very Low")]
        VeryLow = 1,

        Low = 2,

        [DisplayName("Moderately Low")]
        ModeratelyLow = 3,

        [DisplayName("Medium Low")]
        MediumLow = 4,

        Medium = 5,

        [DisplayName("Medium High")]
        MediumHigh = 6,

        [DisplayName("Moderately High")]
        ModeratelyHigh = 7,

        High = 8,

        [DisplayName("Very High")]
        VeryHigh = 9,

        Highest = 10,
    }
}