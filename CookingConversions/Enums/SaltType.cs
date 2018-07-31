using System.ComponentModel;

namespace CookingConversions.Enums
{
    public enum SaltType
    {
        [DisplayName("Morton's Table")]
        MortonTable = 0,

        [DisplayName("Morton's Kosher")]
        MortonKosher = 1,

        [DisplayName("Fine Sea")]
        FineSea = 2,

        [DisplayName("Sel Gris")]
        SelGris = 3,

        [DisplayName("Diamond Kosher")]
        DiamondKosher = 4,

        Maldon = 5
    }
}