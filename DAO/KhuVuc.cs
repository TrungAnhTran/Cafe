//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO
{
    using System;
    using System.Collections.Generic;
    [Table("khuvuc")]

    public partial class KhuVuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuVuc()
        {
            this.Bans = new HashSet<Ban>();
        }
        [Key]
        public int MaKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}
