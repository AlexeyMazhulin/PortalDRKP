namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("drkpStaffList")]
    public partial class drkpStaffList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drkpStaffList()
        {
            drkpStaffKPI = new HashSet<drkpStaffKPI>();
            drkpStaffKPIHistory = new HashSet<drkpStaffKPIHistory>();
            drkpStaffList1 = new HashSet<drkpStaffList>();
            drkpStaffListHistory = new HashSet<drkpStaffListHistory>();
        }

        public int ID { get; set; }

        public int? drkpDepartmentID { get; set; }

        [StringLength(10)]
        public string StaffCode { get; set; }

        public int? UserID { get; set; }

        public bool? IsChief { get; set; }

        public int? BudgetID { get; set; }

        public int? drkpBusinessDepartmentID { get; set; }

        public int? ParentID { get; set; }

        public int? DivOption { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmploymentDate { get; set; }

        public virtual cmnUser cmnUser { get; set; }

        public virtual drkpBudget drkpBudget { get; set; }

        public virtual drkpDepartment drkpDepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffKPI> drkpStaffKPI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffKPIHistory> drkpStaffKPIHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffList> drkpStaffList1 { get; set; }

        public virtual drkpStaffList drkpStaffList2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffListHistory> drkpStaffListHistory { get; set; }
    }
}
