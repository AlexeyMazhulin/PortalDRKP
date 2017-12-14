namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpStaffListHistory")]
    public partial class drkpStaffListHistory
    {
        public int ID { get; set; }

        public int? StaffListID { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DismissalDate { get; set; }

        public virtual drkpStaffList drkpStaffList { get; set; }
    }
}
