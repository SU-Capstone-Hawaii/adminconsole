using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace adminconsole.Models
{
    public partial class MaphawksContext : DbContext
    {
        public MaphawksContext()
        {
        }

        public MaphawksContext(DbContextOptions<MaphawksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<SpecialQualities> SpecialQualities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Contact__E7FEA477A5E98A57");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Terminal)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithOne(p => p.Contact)
                    .HasForeignKey<Contact>(d => d.LocationId)
                    .HasConstraintName("FK__Contact__Locatio__5165187F");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA47765EF14A1");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Long).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.RetailOutlet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecialQualities>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__SpecialQ__E7FEA477BD8D499F");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MilitaryIdrequired).HasColumnName("MilitaryIDRequired");

                entity.HasOne(d => d.Location)
                    .WithOne(p => p.SpecialQualities)
                    .HasForeignKey<SpecialQualities>(d => d.LocationId)
                    .HasConstraintName("FK__SpecialQu__Locat__5441852A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
