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
    
    public partial class phonedeatil
    {
        public string phonename { get; set; }
        public Nullable<int> ram { get; set; }
        public Nullable<double> cam { get; set; }
        public int id { get; set; }
        public Nullable<int> phID { get; set; }
    
        public virtual phone phone { get; set; }
    }
}
