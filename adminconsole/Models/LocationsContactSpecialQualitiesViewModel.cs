using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adminconsole.Models
{
    public class LocationsContactSpecialQualitiesViewModel
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

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Fax")]
        public string Fax { get; set; }

        [DisplayName("Terminal")]
        public string Terminal { get; set; }

        [DisplayName("Restricted Access")]
        public bool? RestrictedAccess { get; set; }

        [DisplayName("Deposit Taking")]
        public bool? DepositTaking { get; set; }

        [DisplayName("Limited Transactions")]
        public bool? LimitedTransactions { get; set; }

        [DisplayName("Handicap Acces")]
        public bool? HandicapAccess { get; set; }

        [DisplayName("Accepts Cash")]
        public bool? AcceptsCash { get; set; }

        [DisplayName("Cashless")]
        public bool? Cashless { get; set; }

        [DisplayName("Self Service Only")]
        public bool? SelfServiceOnly { get; set; }

        [DisplayName("Surcharge")]
        public bool? Surcharge { get; set; }

        [DisplayName("On Military Base")]
        public bool? OnMilitaryBase { get; set; }

        [DisplayName("Military ID Required")]
        public bool? MilitaryIdrequired { get; set; }

        [DisplayName("Additional Detail")]
        [StringLength(100)]
        public string AdditionalDetail { get; set; }

        public List<Locations> locations;
        public List<Contact> contacts;
        public List<SpecialQualities> specialQualities;
        private readonly MaphawksContext context;

        public LocationsContactSpecialQualitiesViewModel(MaphawksContext context)
        {
            this.context = context;
            locations = new List<Locations>();
            contacts = new List<Contact>();
            specialQualities = new List<SpecialQualities>();
        }

        public bool Index()
        {
            try
            {
                locations = context.Locations.ToList();
                foreach (Locations location in locations)
                {
                    contacts.Add(context.Contact.Where(x => x.LocationId == location.LocationId).First());
                    specialQualities.Add(context.SpecialQualities.Where(x => x.LocationId == location.LocationId).First());
                }
            } catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
