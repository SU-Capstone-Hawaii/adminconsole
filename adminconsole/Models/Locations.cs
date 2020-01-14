using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public partial class Locations
    {
        [Required]
        public string LocationId { get; set; }

        [DisplayName("Institution Name")]
        public string InstitutionName { get; set; }

        [Required]
        [DisplayName("Type")]
        public string TypeName { get; set; }

        [Required]
        [DisplayName("Street")]
        public string Street { get; set; }

        [Required]
        [DisplayName("City")]
        public string City { get; set; }

        [Required]
        [DisplayName("State")]
        public string State { get; set; }

        [Required]
        [DisplayName("Zipcode")]
        public string Zipcode { get; set; }

        [Required]
        [DisplayName("Latitude")]
        public decimal Lat { get; set; }

        [Required]
        [DisplayName("Longitude")]
        public decimal Long { get; set; }

        [DisplayName("Retail Outlet")]
        public string RetailOutlet { get; set; }

        [DisplayName("Hours")]
        public string Hours { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual SpecialQualities SpecialQualities { get; set; }
    }
}
