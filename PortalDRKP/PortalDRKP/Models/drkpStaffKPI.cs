namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpStaffKPI")]
    public partial class drkpStaffKPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drkpStaffKPI()
        {
            drkpPlanManagerNew = new HashSet<drkpPlanManagerNew>();
        }

        public int ID { get; set; }

        public int? StaffID { get; set; }

        public int? KpiID { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        public int? Weight { get; set; }

        public int? IsCountable { get; set; }

        public int? FiscalYear { get; set; }

        public virtual drkpKPI drkpKPI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpPlanManagerNew> drkpPlanManagerNew { get; set; }

        public virtual drkpStaffKPI drkpStaffKPI1 { get; set; }

        public virtual drkpStaffKPI drkpStaffKPI2 { get; set; }

        public virtual drkpStaffList drkpStaffList { get; set; }
    }
}
