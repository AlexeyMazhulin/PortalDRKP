namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpStaffKPIHistory")]
    public partial class drkpStaffKPIHistory
    {
        public int ID { get; set; }

        public int? drkpStaffKpiID { get; set; }

        public int? StaffID { get; set; }

        public int? KpiID { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        public int? Weight { get; set; }

        public int? IsCountable { get; set; }

        public int? FiscalYear { get; set; }

        public DateTime? ChangeData { get; set; }

        [StringLength(100)]
        public string ChangedUser { get; set; }

        [StringLength(50)]
        public string WTF { get; set; }

        public virtual drkpKPI drkpKPI { get; set; }

        public virtual drkpStaffList drkpStaffList { get; set; }
    }
}
