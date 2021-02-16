using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SVR___Sajermann_Vehicle_Reservations.Models
{
    public partial class svrContext : DbContext
    {
        public svrContext()
        {
        }

        public svrContext(DbContextOptions<svrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=svr;user=sa;password=Bruno123456%;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.DateFrom).HasColumnName("dateFrom");

                entity.Property(e => e.DateUntil).HasColumnName("dateUntil");

                entity.Property(e => e.Destination).HasColumnName("destination");

                entity.Property(e => e.IdDriver).HasColumnName("idDriver");

                entity.Property(e => e.IdVehicle).HasColumnName("idVehicle");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Origin).HasColumnName("origin");

                entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.Bio)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("bio");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("cover");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("marca")
                    .IsFixedLength(true);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("model")
                    .IsFixedLength(true);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("placa")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
