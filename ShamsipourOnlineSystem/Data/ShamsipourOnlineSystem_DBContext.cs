using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShamsipourOnlineSystem.Models;

#nullable disable

namespace ShamsipourOnlineSystem.Data
{
    public partial class ShamsipourOnlineSystem_DBContext : DbContext
    {
        public ShamsipourOnlineSystem_DBContext()
        {
        }

        public ShamsipourOnlineSystem_DBContext(DbContextOptions<ShamsipourOnlineSystem_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DormStudent> DormStudents { get; set; }
        public virtual DbSet<EduExpertStudent> EduExpertStudents { get; set; }
        public virtual DbSet<FinalGraduatesExpertStudent> FinalGraduatesExpertStudents { get; set; }
        public virtual DbSet<FinancialStudent> FinancialStudents { get; set; }
        public virtual DbSet<GraduatesExpertStudent> GraduatesExpertStudents { get; set; }
        public virtual DbSet<ItexpertStudent> ItexpertStudents { get; set; }
        public virtual DbSet<LaboratoryStudent> LaboratoryStudents { get; set; }
        public virtual DbSet<LibraryStudent> LibraryStudents { get; set; }
        public virtual DbSet<ResearchAssistantStudent> ResearchAssistantStudents { get; set; }
        public virtual DbSet<Responsible> Responsibles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAffairsStudent> StudentAffairsStudents { get; set; }
        public virtual DbSet<ThesisExpertStudent> ThesisExpertStudents { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=EBRAHIMH;Initial Catalog=ShamsipourOnlineSystem_DB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DormStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduExpertStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinalGraduatesExpertStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GraduatesExpertStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItexpertStudent>(entity =>
            {
                entity.ToTable("ITExpertStudents");

                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaboratoryStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LibraryStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResearchAssistantStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Responsible>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NationalNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibleId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItexpertId).HasColumnName("ITExpertId");

                entity.Property(e => e.NationalNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dorm)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DormId)
                    .HasConstraintName("FK_Student_DormStudents");

                entity.HasOne(d => d.EduExpert)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.EduExpertId)
                    .HasConstraintName("FK_Student_EduExpertStudents");

                entity.HasOne(d => d.FinalGraduatesExpert)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.FinalGraduatesExpertId)
                    .HasConstraintName("FK_Student_FinalGraduatesExpertStudents");

                entity.HasOne(d => d.Financial)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.FinancialId)
                    .HasConstraintName("FK_Student_FinancialStudents");

                entity.HasOne(d => d.GraduatesExpert)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GraduatesExpertId)
                    .HasConstraintName("FK_Student_GraduatesExpertStudents");

                entity.HasOne(d => d.Itexpert)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ItexpertId)
                    .HasConstraintName("FK_Student_ITExpertStudents");

                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.LaboratoryId)
                    .HasConstraintName("FK_Student_LaboratoryStudents");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.LibraryId)
                    .HasConstraintName("FK_Student_LibraryStudents");

                entity.HasOne(d => d.ResearchAssistant)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ResearchAssistantId)
                    .HasConstraintName("FK_Student_ResearchAssistantStudents");

                entity.HasOne(d => d.StudentAffairs)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentAffairsId)
                    .HasConstraintName("FK_Student_StudentAffairsStudents");

                entity.HasOne(d => d.ThesisExpert)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ThesisExpertId)
                    .HasConstraintName("FK_Student_ThesisExpertStudents");
            });

            modelBuilder.Entity<StudentAffairsStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThesisExpertStudent>(entity =>
            {
                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_UserRoles_RoleID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_UserRoles_ResponsibleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
