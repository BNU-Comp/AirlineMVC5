using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Name??
    /// </summary>
    public class Destination
    {
        public int DestinationID { get; set; }

        [Required, StringLength(20)]
        public String Name { get; set; }


        public CountryCodes Country { get; set; }


        // Navigation Properties


    }


}
