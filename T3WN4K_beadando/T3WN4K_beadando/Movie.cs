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
    
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            this.Movies_Director = new HashSet<Movies_Director>();
        }
    
        public int ID { get; set; }
        public string mov_title { get; set; }
        public Nullable<System.DateTime> mov_release { get; set; }
        public string mov_rel_country { get; set; }
    
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movies_Director> Movies_Director { get; set; }
        public virtual Rating Rating { get; set; }
    }
}