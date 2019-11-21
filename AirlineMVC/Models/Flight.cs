using System;
namespace AirlineMVC.Models 
{
    /// <summary>
    /// Name?
    /// </summary>
    public class Flight
    {
        public int FlightID { get; set; }

        public string FlightNo { get; set; }

        public Airlines Airline { get; set; }

        public string GateNo { get; set; }

        public string TerminalNo { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        // navigation properties

        public virtual Airport  DepartureAirport { get; set; }

        public virtual Airport ArrivalAirport { get; set; }

        //public virtual Ticket ticket { get; set; }

        //public virtual Seat Seat { get; set; }

        //public virtual Destination Destination { get; set; }


        public TimeSpan FlightDuration ()
        {
            return ArrivalDateTime.Subtract(DepartureDateTime);
        }

    }

    public enum Airlines 
    { 
        BA,
        AmericanAirlines,
        RyanAir,
        Quantas
    }
}
