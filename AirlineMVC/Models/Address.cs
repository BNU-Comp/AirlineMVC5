using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirlineMVC.Models
{
    /// <summary>
    /// jonathan 
    /// </summary>
    public class Address
    {
        public int AddressID { get; set; }

        [DisplayName, Required]
        public String HouseNumber { get; set; }

        // e.g. Warren Street 
        public String Street { get; set; }

        //e.g. Wellingborough
        public String Town { get; set; }

        //e.g. Suffolk 
        public Counties County { get; set; }

        //e.g. LL99 9LL
        public String PostCode { get; set; }

        public Nullable<int> CustomerID { get; set; }
        // Navigation Properties

        public virtual Customer Customer { get; set; }

    }

    public enum Counties
    {
        Bedfordshire,
        Berkshire,
        Bristol,
        Buckinghamshire,
        Cambridgeshire,
        Cheshire,
        Cornwall,
        CountyDurham,
        Cumbria,
        Cumberland,
        Derbyshire,
        Devon,
        Dorset,
        Essex,
        Gloucestershire,
        Hampshire,
        Herefordshire,
        Hertfordshire,
        Huntingdonshire,
        Kent,
        Lancashire,
        Leicestershire,
        Lincolnshire,
        Middlesex,
        Norfolk,
        Northamptonshire,
        Northumberland,
        Nottinghamshire,
        Oxfordshire,
        Rutland,
        Shropshire,
        Somerset,
        Staffordshire,
        Suffolk,
        Surrey,
        Sussex,
        Warwickshire,
        Wiltshire,
        Worcestershire,
        Yorkshire
    }
}

