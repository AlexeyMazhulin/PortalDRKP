namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpDepartment")]
    public partial class drkpDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drkpDepartment()
        {
            drkpDepartment1 = new HashSet<drkpDepartment>();
            drkpStaffList = new HashSet<drkpStaffList>();
        }

        public int ID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(100)]
        public string DepartmentName { get; set; }

        public int? DepOrder { get; set; }

        [StringLength(100)]
        public string DepartmentNameEN { get; set; }

        public int? IsSaleDep { get; set; }

        public int? isChief { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpDepartment> drkpDepartment1 { get; set; }

        public virtual drkpDepartment drkpDepartment2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffList> drkpStaffList { get; set; }
    }
}
