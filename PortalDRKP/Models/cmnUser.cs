namespace PortalDRKP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cmnUser")]
    public partial class cmnUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmnUser()
        {
            drkpStaffList = new HashSet<drkpStaffList>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string FirstNameRu { get; set; }

        [StringLength(50)]
        public string LastNameRu { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(101)]
        public string FullNameRu { get; set; }

        [StringLength(50)]
        public string FirstNameEn { get; set; }

        [StringLength(50)]
        public string LastNameEn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(102)]
        public string FullNameEn { get; set; }

        [StringLength(1024)]
        public string DomainName { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        [StringLength(2)]
        public string PreferedLanguage { get; set; }

        [StringLength(3)]
        public string PreferedCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drkpStaffList> drkpStaffList { get; set; }
    }
}
