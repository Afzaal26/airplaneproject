//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineManagementSystemOOAD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public Booking()
        {
            this.Booking_Details = new HashSet<Booking_Details>();
        }
    
        public int Booking_ID { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public string Details { get; set; }
    
        public virtual ICollection<Booking_Details> Booking_Details { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
