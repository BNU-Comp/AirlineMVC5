using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Jonathan
    /// </summary>
    public class Destination
    {
        public int destinationID {get; set; }

        public String destination {get; set; }

        public String country {get; set; }

	    public virtual Flight Flight {get; set; }
        public Destination Destination { get; set; } 
    }
}