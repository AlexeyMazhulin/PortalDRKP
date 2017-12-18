namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpKPIHistory")]
    public partial class drkpKPIHistory
    {
        public int ID { get; set; }

        public int kpiID { get; set; }

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

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public virtual drkpKPI drkpKPI { get; set; }
    }
}
