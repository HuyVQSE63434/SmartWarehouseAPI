//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWhRestApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class check_store_detail
    {
        public int check_store_infor_id { get; set; }
        public int material_id { get; set; }
        public Nullable<long> amount { get; set; }
    
        public virtual check_store check_store { get; set; }
        public virtual material material { get; set; }
    }
}
