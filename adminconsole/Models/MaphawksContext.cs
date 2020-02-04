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

        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<HoursPerDayOfTheWeek> HoursPerDayOfTheWeek { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<SpecialQualities> SpecialQualities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Entity<Contacts>(entity =>
                {
                    entity.HasKey(e => e.LocationId)
                        .HasName("PK__Contacts__E7FEA477A3457B54");

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Fax)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Phone)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.WebAddress)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Location)
                        .WithOne(p => p.Contact)
                        .HasForeignKey<Contacts>(d => d.LocationId)
                        .HasConstraintName("FK__Contacts__Locati__5FB337D6");
                });

                modelBuilder.Entity<HoursPerDayOfTheWeek>(entity =>
                {
                    entity.HasKey(e => e.LocationId)
                        .HasName("PK__HoursPer__E7FEA4774ED970AB");

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtfriClose)
                        .HasColumnName("HoursDTFriClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtfriOpen)
                        .HasColumnName("HoursDTFriOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtmonClose)
                        .HasColumnName("HoursDTMonClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtmonOpen)
                        .HasColumnName("HoursDTMonOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtsatClose)
                        .HasColumnName("HoursDTSatClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtsatOpen)
                        .HasColumnName("HoursDTSatOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtsunClose)
                        .HasColumnName("HoursDTSunClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtsunOpen)
                        .HasColumnName("HoursDTSunOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtthuClose)
                        .HasColumnName("HoursDTThuClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtthuOpen)
                        .HasColumnName("HoursDTThuOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDttueClose)
                        .HasColumnName("HoursDTTueClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDttueOpen)
                        .HasColumnName("HoursDTTueOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtwedClose)
                        .HasColumnName("HoursDTWedClose")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursDtwedOpen)
                        .HasColumnName("HoursDTWedOpen")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursFriClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursFriOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursMonClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursMonOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursSatClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursSatOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursSunClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursSunOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursThuClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursThuOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursTueClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursTueOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursWedClose)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.HoursWedOpen)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Location)
                        .WithOne(p => p.HoursPerDayOfTheWeek)
                        .HasForeignKey<HoursPerDayOfTheWeek>(d => d.LocationId)
                        .HasConstraintName("FK__HoursPerD__Locat__656C112C");
                });

                modelBuilder.Entity<Locations>(entity =>
                {
                    entity.HasKey(e => e.LocationId)
                        .HasName("PK__Location__E7FEA477F8FBBD84");

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Address)
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.City)
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.CoopLocationId)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Country)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.County)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Hours)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                    entity.Property(e => e.LocationType)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                    entity.Property(e => e.Name)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.PostalCode)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.RetailOutlet)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.State)
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<SpecialQualities>(entity =>
                {
                    entity.HasKey(e => e.LocationId)
                        .HasName("PK__SpecialQ__E7FEA477041F4759");

                    entity.Property(e => e.LocationId)
                        .HasColumnName("LocationID")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.AcceptCash)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.AcceptDeposit)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Access)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.AccessNotes)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Cashless)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.DriveThruOnly)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.EnvelopeRequired)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.HandicapAccess)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.InstallationType)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.LimitedTransactions)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.MilitaryIdRequired)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.OnMilitaryBase)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.OnPremise)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.RestrictedAccess)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.SelfServiceDevice)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.SelfServiceOnly)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.Property(e => e.Surcharge)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Location)
                        .WithOne(p => p.SpecialQualities)
                        .HasForeignKey<SpecialQualities>(d => d.LocationId)
                        .HasConstraintName("FK__SpecialQu__Locat__628FA481");
                });

                OnModelCreatingPartial(modelBuilder);
            } catch (Exception e)
            {
                throw e;
            }
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
