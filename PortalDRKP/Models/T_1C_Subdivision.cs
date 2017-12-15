namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_1C_Subdivision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_1C_Subdivision()
        {
            T_1C_Subdivision1 = new HashSet<T_1C_Subdivision>();
            T_1C_Users = new HashSet<T_1C_Users>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sub_ID { get; set; }

        public int? Order { get; set; }

        [Required]
        [StringLength(255)]
        public string Sub_SID1C { get; set; }

        [StringLength(255)]
        public string Sub_Name { get; set; }

        public int? Sub_ParentID { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool? ModifiedStatus { get; set; }

        public int? DepartmentID { get; set; }

        public int? VerticalID { get; set; }

        public int? Show { get; set; }

        public virtual cmnDepartment cmnDepartment { get; set; }

        public virtual pVertical pVertical { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Subdivision> T_1C_Subdivision1 { get; set; }

        public virtual T_1C_Subdivision T_1C_Subdivision2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Users> T_1C_Users { get; set; }
    }
}
