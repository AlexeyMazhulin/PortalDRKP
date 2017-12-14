namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpBudget")]
    public partial class drkpBudget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drkpBudget()
        {
            drkpStaffList = new HashSet<drkpStaffList>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string BudgetName { get; set; }

        public int? FiscalYear { get; set; }

        public int? SortOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffList> drkpStaffList { get; set; }
    }
}
