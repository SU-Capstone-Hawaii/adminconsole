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

        public virtual DbSet<ContactsModel> Contact { get; set; }
        public virtual DbSet<LocationsModel> LocationsModel { get; set; }
        public virtual DbSet<SpecialQualitiesModel> SpecialQualities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsModel>(entity =>
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
                    .HasForeignKey<ContactsModel>(d => d.LocationId)
                    .HasConstraintName("FK__Contact__Locatio__5165187F");
            });

            modelBuilder.Entity<LocationsModel>(entity =>
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

            modelBuilder.Entity<SpecialQualitiesModel>(entity =>
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
                    .HasForeignKey<SpecialQualitiesModel>(d => d.LocationId)
                    .HasConstraintName("FK__SpecialQu__Locat__5441852A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
