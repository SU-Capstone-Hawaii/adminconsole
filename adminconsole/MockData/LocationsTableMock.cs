using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.MockData
{
    public class LocationsTableMock
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
        public decimal Lat { get; set; } = 0.0M;

        [Required]
        [DisplayName("Longitude")]
        public decimal Long { get; set; } = 0.0M;

        [DisplayName("Retail Outlet")]
        public string RetailOutlet { get; set; }

        [DisplayName("Hours")]
        public string Hours { get; set; }

        public virtual ContactTableMock Contact { get; set; }
        public virtual SpecialQualitiesTableMock SpecialQualities { get; set; }
    }
}
