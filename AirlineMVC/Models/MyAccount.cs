using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineMVC.Models
{
    public class MyAccount
    {
        public Customer Customer { get; set; }

        public Address Address { get; set; }

    }
}