using System;
namespace AirlineMVC.Models 
{
    /// <summary>
    /// Name?
    /// </summary>
    public class Seat
    {
        public int SeatID { get; set; }

        public int FlightID { get; set; }

        public Boolean Reserved { get; set; }

        public decimal Price { get; set; }

        // navigation properties

        public virtual Ticket Ticket { get; set; }

        public virtual Flight[] Flight { get; set; }

    }
}
