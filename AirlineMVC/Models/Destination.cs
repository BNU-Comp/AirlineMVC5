using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Jonathan 
    /// </summary>
    public class Destination
    {
        public int DestinationID { get; set; }

        [Required, StringLength(20)]
        public String Name { get; set; }

        public CountryCodes Country { get; set; }

        public Countries2 International { get; set; }

        // Navigation Properties

        public enum Countries2
        {
            Afghanistan,
            Albania,
            Algeria,
            Andorra,
            Angola,
            ElSalvador,
            England,
            EquatorialGuinea,
            Eritrea,
            Estonia,
            Eswatini,
            Ethiopia,
            FaroeIslands,
            Fiji,
            SouthAfrica,
            SouthKorea,
            SouthSudan,
            Spain,
            SriLanka,
            Sudan,
            Suriname,
            Sweden,
            Switzerland,
            UnitedArabEmirates,
            UnitedStates,
            Uruguay,
            USVirginIslands,
            Uzbekistan,
            Vanuatu,
            Venezuela,
            Vietnam,
            HongKong,
            Hungary,
            Iceland,
            India,
            Indonesia,
            Iran,
            Iraq,
            Israel,
        }

    }


}
