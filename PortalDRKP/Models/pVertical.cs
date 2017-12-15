namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pVertical")]
    public partial class pVertical
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pVertical()
        {
            pVertical1 = new HashSet<pVertical>();
            T_1C_Subdivision = new HashSet<T_1C_Subdivision>();
            T_1C_Users = new HashSet<T_1C_Users>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? ParentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pVertical> pVertical1 { get; set; }

        public virtual pVertical pVertical2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Subdivision> T_1C_Subdivision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Users> T_1C_Users { get; set; }
    }
}
