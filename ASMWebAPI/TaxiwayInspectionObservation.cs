//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASMWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxiwayInspectionObservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaxiwayInspectionObservation()
        {
            this.TaxiwayInspectionChecklists = new HashSet<TaxiwayInspectionChecklist>();
        }
    
        public int TIC_ID { get; set; }
        public string OBSERVATIONS { get; set; }
        public Nullable<bool> ISACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxiwayInspectionChecklist> TaxiwayInspectionChecklists { get; set; }
    }
}
