using System;
using System.Collections.Generic;

namespace adminconsole.Models
{
    public partial class LocationsModel
    {
        public string LocationId { get; set; }
        public string InstitutionName { get; set; }
        public string TypeName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public string RetailOutlet { get; set; }
        public string Hours { get; set; }

        public virtual ContactsModel Contact { get; set; }
        public virtual SpecialQualitiesModel SpecialQualities { get; set; }
    }
}
