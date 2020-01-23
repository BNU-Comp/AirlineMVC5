using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineMVC.Models
{
    /// <summary>
    /// Name ?
    /// </summary>
    public class Ticket
    {
        public int TicketID { get; set; }

        public decimal Price { get; set; }

        // navigation properties

        public virtual Seat Seat { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
