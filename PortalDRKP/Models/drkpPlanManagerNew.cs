namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpPlanManagerNew")]
    public partial class drkpPlanManagerNew
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlanDate { get; set; }

        public int? UserID { get; set; }

        public int? StaffKpiID { get; set; }

        public double? PlanValue { get; set; }

        [StringLength(50)]
        public string UnitMeasure { get; set; }

        [StringLength(50)]
        public string PlanType { get; set; }

        public virtual drkpStaffKPI drkpStaffKPI { get; set; }
    }
}
