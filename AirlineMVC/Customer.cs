using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirlineMVC.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        
        //e.g. Jacob
        [Required, StringLength(20), DisplayName("First Name")]
        public String FirstName { get; set; }
        //e.g. Gardiner-Smith

        public String LastName { get; set; }
        //e.g. jacobgsmith@visual.com

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }
        
        //e.g. 079324 89565
        [DataType(DataType.PhoneNumber)]
        public String TelephoneNo { get; set; }


        public Nullable<int> AddressID { get; set; }


        // Navigation Properties

        //public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Address Address { get; set; }
    }
}