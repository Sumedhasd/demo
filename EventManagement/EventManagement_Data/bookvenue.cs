//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventManagement_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class bookvenue
    {
        public int bookingid { get; set; }
        public Nullable<int> id { get; set; }
        public string eventtype { get; set; }
        public string venuetype { get; set; }
        public Nullable<int> noofguest { get; set; }
        public Nullable<System.DateTime> Bookingdate { get; set; }
    
        public virtual userregistration userregistration { get; set; }
    }
}