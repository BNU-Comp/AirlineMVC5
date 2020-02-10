using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineMVC.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        // e.g. 2 Adults
        public int NoAdults { get; set; }

        // e.g. 1 Child
        public int NoChildren { get; set; }

        public int NoInfants { get; set; }

        // e.g. Economy
        public FlightTypes Type { get; set; }

        // e.g. 10/01/2019
        public DateTime DateBooked { get; set; }

        public decimal TotalCost { get; set; }

        // navigation properties

        public virtual Flight OutboundFlight { get; set; }
        public virtual Flight InboundFlight { get; set; }

        public virtual Customer Customer { get; set; }
    }

    public enum FlightTypes 
    { 
        Economy,
        PremiumEconomy,
        Business,
        FirstClass
    }
}
