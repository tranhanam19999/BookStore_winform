//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTVEntityFramwork.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.MUONSACHes = new HashSet<MUONSACH>();
        }
    
        public int MAUSER { get; set; }
        public string USERNAME { get; set; }
        public string MATKHAU { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public Nullable<int> MACARD { get; set; }
        public string CHUCVU { get; set; }
        public string TEN { get; set; }
    
        public virtual CARD CARD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONSACH> MUONSACHes { get; set; }
    }
}
