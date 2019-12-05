using System;

using System.Linq;
using System.Web;


namespace AirlineMVC.Models
{
    public class Address
    {
        public int addressID { get; set; }
        public Integer house_Number { get; set; }
        public String address_line_1 { get; set; }
        public String address_line_2 { get; set; }
        public String post_Code { get; set; }

        public Customer Customer { get; set; }
        public Address Address { get; set; }
    }
}
