using System;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Name??
    /// </summary>
    public class Destination
    {
        public int DestinationID { get; set; }

        public String Name { get; set; }

        public String Country { get; set; }

        // Navigation Properties

        public virtual Flight Flight { get; set; }

    }
}
