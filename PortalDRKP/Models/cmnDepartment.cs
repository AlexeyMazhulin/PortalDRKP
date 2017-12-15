namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cmnDepartment")]
    public partial class cmnDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmnDepartment()
        {
            cmnDepartment1 = new HashSet<cmnDepartment>();
            T_1C_Subdivision = new HashSet<T_1C_Subdivision>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string DepartmentName { get; set; }

        public int? ParentID { get; set; }

        public int? SortOrder { get; set; }

        public bool? MustShow { get; set; }

        public bool? LastLevel { get; set; }

        [StringLength(5)]
        public string Vertical { get; set; }

        public bool? OnlyDepartmentAgregate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmnDepartment> cmnDepartment1 { get; set; }

        public virtual cmnDepartment cmnDepartment2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Subdivision> T_1C_Subdivision { get; set; }
    }
}
