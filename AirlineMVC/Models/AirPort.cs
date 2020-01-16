using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineMVC.Models
{
    public class Airport
    {
        // 3 Letter code such as LGW and FCO
        public string AirportID { get; set; }

        // e.g. Gatwick
        public string AirportName { get; set; }
        // e.g. London
        public string NearestCity { get; set; }
        // e.g. GBR
        public CountryCodes CountryCode { get; set; }
    }

    public enum CountryCodes 
    { 
        GBR,
        USA,
        ITA,
        FRA,
        COL,
        DRC,
        POL,
        GER,
        BEL,
        SFA
    }
}