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
    
    public partial class transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaction()
        {
            this.transaction_detail = new HashSet<transaction_detail>();
        }
    
        public int id { get; set; }
        public string exchange_store_id { get; set; }
        public string store_id { get; set; }
        public System.DateTime time { get; set; }
        public long staff_id { get; set; }
        public string transaction_type_id { get; set; }
        public string status_id { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual status status { get; set; }
        public virtual store store { get; set; }
        public virtual store store1 { get; set; }
        public virtual transaction_type transaction_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction_detail> transaction_detail { get; set; }
    }
}