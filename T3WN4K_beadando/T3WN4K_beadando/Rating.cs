//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T3WN4K_beadando
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int mov_id { get; set; }
        public double rev_stars { get; set; }
        public int number_o_ratings { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
