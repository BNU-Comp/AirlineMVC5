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

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String EmailAddress { get; set; }

        public String TelephoneNo { get; set; }

        public int AddressID { get; set; }

        // Navigation Properties

        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Address Address { get; set; }
    }
}