//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class phone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phone()
        {
            this.phonedeatils = new HashSet<phonedeatil>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<double> phone_price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phonedeatil> phonedeatils { get; set; }
    }
}