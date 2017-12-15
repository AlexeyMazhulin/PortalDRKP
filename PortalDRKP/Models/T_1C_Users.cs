namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_1C_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_1C_Users()
        {
            T_1C_Users1 = new HashSet<T_1C_Users>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_ID { get; set; }

        public int? Order { get; set; }

        [Required]
        [StringLength(50)]
        public string User_SID1C { get; set; }

        [StringLength(50)]
        public string User_ID1C { get; set; }

        [StringLength(255)]
        public string User_Name { get; set; }

        public int? User_ParentID { get; set; }

        public int? Sub_ID { get; set; }

        [StringLength(255)]
        public string SUBDIVISION { get; set; }

        public int? Reg_ID { get; set; }

        [StringLength(50)]
        public string REGION { get; set; }

        [StringLength(50)]
        public string MODIFIEDSTATUS { get; set; }

        public DateTime ModifiedDate { get; set; }

        [StringLength(50)]
        public string PROJECT { get; set; }

        public int? Proj_ID { get; set; }

        public int? VerticalID { get; set; }

        public virtual pVertical pVertical { get; set; }

        public virtual T_1C_Subdivision T_1C_Subdivision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_1C_Users> T_1C_Users1 { get; set; }

        public virtual T_1C_Users T_1C_Users2 { get; set; }
    }
}
