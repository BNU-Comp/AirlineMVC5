using System;
using System.Collections.Generic;

namespace AirlineMVC.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        //e.g. Jacob
        public String FirstName { get; set; }
        //e.g. Gardiner-Smith
        public String LastName { get; set; }
        //e.g. jacobgsmith@visual.com
        public String EmailAddress { get; set; }
        //e.g. 079324 89565
        public String TelephoneNo { get; set; }

        public int AddressID { get; set; }

        public int BookingID { get; set; }

        // Navigation Properties

        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Address Address { get; set; }
    }
}