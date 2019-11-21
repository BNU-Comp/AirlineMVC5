using System;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Name ?
    /// </summary>
    public class Address
    {
        public int AddressID { get; set; }

        public String HouseNumber { get; set; }

        public String Street { get; set; }

        public String Town { get; set; }

        public String County { get; set; }

        public String PostCode { get; set; }

        // Navigation Properties

        public virtual Customer Customer { get; set; }

    }
}

