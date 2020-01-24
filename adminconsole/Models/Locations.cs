using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public partial class Locations
    {
        [Required]
        #nullable disable
        public string LocationId { get; set; }

        public string CoopLocationId { get; set; }

        [DisplayName("Take Co-Op Data")]
        public bool? TakeCoopData { get; set; }


        public bool? SoftDelete { get; set; }

        [DisplayName("Institution")]
        public string Name { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("County")]
        public string County { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Zipcode")]
        public string PostalCode { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }

        [DisplayName("Latitude")]
        public decimal? Latitude { get; set; }

        [DisplayName("Longitude")]
        public decimal? Longitude { get; set; }

        [DisplayName("24hrs / Business Hours Access")]
        public string Hours { get; set; }

        [DisplayName("Retail Outlet")]
        public string RetailOutlet { get; set; }

        [DisplayName("Location Type")]
        public string LocationType { get; set; }


        #region Objects Used for Joins
        public virtual Contacts Contact { get; set; }
        public virtual SpecialQualities SpecialQualities { get; set; }
        public virtual HoursPerDayOfTheWeek HoursPerDayOfTheWeek { get; set; }
        #endregion
    }
}
