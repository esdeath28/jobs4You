//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jobs4You.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int ratingID { get; set; }
        public Nullable<int> paymentID { get; set; }
        public Nullable<double> client_rating { get; set; }
        public Nullable<double> freelancer_rating { get; set; }
    
        public virtual Payment Payment { get; set; }
    }
}
