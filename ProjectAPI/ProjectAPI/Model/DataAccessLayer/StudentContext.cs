using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectAPI.Model.DataAccessLayer
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<TblStudentDetails> TblStudentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Student;user id=sa;password=6342;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<TblStudentDetails>(entity =>
            {
                entity.HasKey(x => x.StudentId)
                    .HasName("PK__Tbl_Stud__4D11D63CD2BF0719");

                entity.ToTable("Tbl_StudentDetails");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasColumnName("studentName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
