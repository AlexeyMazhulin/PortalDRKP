namespace PortalDRKP.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<cmnUser> cmnUser { get; set; }
        public virtual DbSet<drkpBudget> drkpBudget { get; set; }
        public virtual DbSet<drkpDepartment> drkpDepartment { get; set; }
        public virtual DbSet<drkpKPI> drkpKPI { get; set; }
        public virtual DbSet<drkpKPIHistory> drkpKPIHistory { get; set; }
        public virtual DbSet<drkpPlanManagerNew> drkpPlanManagerNew { get; set; }
        public virtual DbSet<drkpStaffKPI> drkpStaffKPI { get; set; }
        public virtual DbSet<drkpStaffKPIHistory> drkpStaffKPIHistory { get; set; }
        public virtual DbSet<drkpStaffList> drkpStaffList { get; set; }
        public virtual DbSet<drkpStaffListHistory> drkpStaffListHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cmnUser>()
                .HasMany(e => e.drkpStaffList)
                .WithOptional(e => e.cmnUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<drkpBudget>()
                .HasMany(e => e.drkpStaffList)
                .WithOptional(e => e.drkpBudget)
                .HasForeignKey(e => e.BudgetID);

            modelBuilder.Entity<drkpDepartment>()
                .HasMany(e => e.drkpDepartment1)
                .WithOptional(e => e.drkpDepartment2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<drkpKPI>()
                .HasMany(e => e.drkpKPIHistory)
                .WithRequired(e => e.drkpKPI)
                .HasForeignKey(e => e.kpiID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<drkpKPI>()
                .HasMany(e => e.drkpStaffKPIHistory)
                .WithOptional(e => e.drkpKPI)
                .HasForeignKey(e => e.KpiID);

            modelBuilder.Entity<drkpKPI>()
                .HasMany(e => e.drkpStaffKPI)
                .WithOptional(e => e.drkpKPI)
                .HasForeignKey(e => e.KpiID);

            modelBuilder.Entity<drkpStaffKPI>()
                .HasMany(e => e.drkpPlanManagerNew)
                .WithOptional(e => e.drkpStaffKPI)
                .HasForeignKey(e => e.StaffKpiID);

            modelBuilder.Entity<drkpStaffKPI>()
                .HasOptional(e => e.drkpStaffKPI1)
                .WithRequired(e => e.drkpStaffKPI2);

            modelBuilder.Entity<drkpStaffList>()
                .HasMany(e => e.drkpStaffKPI)
                .WithOptional(e => e.drkpStaffList)
                .HasForeignKey(e => e.StaffID);

            modelBuilder.Entity<drkpStaffList>()
                .HasMany(e => e.drkpStaffKPIHistory)
                .WithOptional(e => e.drkpStaffList)
                .HasForeignKey(e => e.StaffID);

            modelBuilder.Entity<drkpStaffList>()
                .HasMany(e => e.drkpStaffList1)
                .WithOptional(e => e.drkpStaffList2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<drkpStaffList>()
                .HasMany(e => e.drkpStaffListHistory)
                .WithOptional(e => e.drkpStaffList)
                .HasForeignKey(e => e.StaffListID);
        }
    }
}
