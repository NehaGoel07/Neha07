using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstEntity.Models
{
    public partial class SalesContext : DbContext
    {
        public SalesContext()
        {
        }

        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Sales;user id=sa;password=6342;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__A1B71F9006CE10B7");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustAddress)
                    .HasColumnName("cust_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasColumnName("cust_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustPhone).HasColumnName("cust_phone");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__4659622950AD40A9");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.FkCustId).HasColumnName("FK_cust_id");

                entity.Property(e => e.FkProdId).HasColumnName("FK_prod_id");

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FkCust)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.FkCustId)
                    .HasConstraintName("FK__Orders__FK_cust___3B75D760");

                entity.HasOne(d => d.FkProd)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.FkProdId)
                    .HasConstraintName("FK__Orders__FK_prod___3C69FB99");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Products__56958AB2673B95B0");

                entity.Property(e => e.ProdId).HasColumnName("prod_id");

                entity.Property(e => e.ProdName)
                    .HasColumnName("prod_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
