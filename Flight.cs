using System;

using System.Linq;
using System.Web;
namespace AirlineMVC.Models
{
    /// <summary>
    /// Jonathan
    /// </summary>
    public class Flight
    {
        public int FlightID { get; set; }
        public Date departure_Date { get; set; }
        public Time departure_Time { get; set; }
        public Date arrival_Date { get; set; }
        public Time arrival_Time { get; set; }

        public Ticket Ticket { get; set; }

        public Seats Seat { get; set; } 
        public Destination Destination { get; set; }
    }
}