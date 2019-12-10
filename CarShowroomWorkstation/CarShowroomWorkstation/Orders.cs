//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarShowroomWorkstation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Cars = new HashSet<Cars>();
        }
    
        public System.DateTime DateOfIssue { get; set; }
        public decimal OrderPrice { get; set; }
        public byte IsCompleted { get; set; }
        public Nullable<System.DateTime> DateOrderClosing { get; set; }
        public Nullable<System.DateTime> LeadTime { get; set; }
        public int ID_order { get; set; }
        public int ClientFK { get; set; }
        public Nullable<int> ManagerFK { get; set; }
        public int PayTypeFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars> Cars { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Managers Managers { get; set; }
        public virtual PayType PayType { get; set; }
    }
}
