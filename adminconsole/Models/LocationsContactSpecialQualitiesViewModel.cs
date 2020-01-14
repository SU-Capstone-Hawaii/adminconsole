using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminconsole.Models
{
    public class LocationsContactSpecialQualitiesViewModel
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
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Terminal { get; set; }
        public bool? RestrictedAccess { get; set; }
        public bool? DepositTaking { get; set; }
        public bool? LimitedTransactions { get; set; }
        public bool? HandicapAccess { get; set; }
        public bool? AcceptsCash { get; set; }
        public bool? Cashless { get; set; }
        public bool? SelfServiceOnly { get; set; }
        public bool? Surcharge { get; set; }
        public bool? OnMilitaryBase { get; set; }
        public bool? MilitaryIdrequired { get; set; }
        public string AdditionalDetail { get; set; }

        private List<Locations> locations;
        private List<Contact> contacts;
        private List<SpecialQualities> specialQualities;
    }
}
