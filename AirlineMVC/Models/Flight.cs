using System;
namespace AirlineMVC.Models 
{
    /// <summary>
    /// Name?
    /// </summary>
    public class Flight
    {
        public int FlightID { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        // navigation properties
        public virtual Ticket ticket { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual Destination Destination { get; set; }

    }
}
