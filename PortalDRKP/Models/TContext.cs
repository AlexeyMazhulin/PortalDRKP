namespace PortalDRKP.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TContext : DbContext
    {
        public TContext()
            : base("name=TContext")
        {
        }

        public virtual DbSet<cmnDepartment> cmnDepartment { get; set; }
        public virtual DbSet<pVertical> pVertical { get; set; }
        public virtual DbSet<T_1C_Subdivision> T_1C_Subdivision { get; set; }
        public virtual DbSet<T_1C_Users> T_1C_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cmnDepartment>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<cmnDepartment>()
                .HasMany(e => e.cmnDepartment1)
                .WithOptional(e => e.cmnDepartment2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<cmnDepartment>()
                .HasMany(e => e.T_1C_Subdivision)
                .WithOptional(e => e.cmnDepartment)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<pVertical>()
                .HasMany(e => e.pVertical1)
                .WithOptional(e => e.pVertical2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<pVertical>()
                .HasMany(e => e.T_1C_Subdivision)
                .WithOptional(e => e.pVertical)
                .HasForeignKey(e => e.VerticalID);

            modelBuilder.Entity<pVertical>()
                .HasMany(e => e.T_1C_Users)
                .WithOptional(e => e.pVertical)
                .HasForeignKey(e => e.VerticalID);

            modelBuilder.Entity<T_1C_Subdivision>()
                .HasMany(e => e.T_1C_Subdivision1)
                .WithOptional(e => e.T_1C_Subdivision2)
                .HasForeignKey(e => e.Sub_ParentID);

            modelBuilder.Entity<T_1C_Users>()
                .HasMany(e => e.T_1C_Users1)
                .WithOptional(e => e.T_1C_Users2)
                .HasForeignKey(e => e.User_ParentID);
        }
    }
}
