namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpKPI")]
    public partial class drkpKPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drkpKPI()
        {
            drkpKPIHistory = new HashSet<drkpKPIHistory>();
            drkpStaffKPIHistory = new HashSet<drkpStaffKPIHistory>();
            drkpStaffKPI = new HashSet<drkpStaffKPI>();
        }

        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(800)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FactCountType { get; set; }

        [StringLength(50)]
        public string RoleID { get; set; }

        [StringLength(255)]
        public string NameSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpKPIHistory> drkpKPIHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffKPIHistory> drkpStaffKPIHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffKPI> drkpStaffKPI { get; set; }
    }
}
