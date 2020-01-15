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
        public string LocationId { get; set; } = null;

        [DisplayName("Institution Name")]
        public string InstitutionName { get; set; } = null;

        [Required]
        [DisplayName("Type")]
        public string TypeName { get; set; } = null;

        [Required]
        [DisplayName("Street")]
        public string Street { get; set; } = null;

        [Required]
        [DisplayName("City")]
        public string City { get; set; } = null;

        [Required]
        [DisplayName("State")]
        public string State { get; set; } = null;

        [Required]
        [DisplayName("Zipcode")]
        public string Zipcode { get; set; } = null;

        [Required]
        [DisplayName("Latitude")]
        public decimal Lat { get; set; }

        [Required]
        [DisplayName("Longitude")]
        public decimal Long { get; set; }

        [DisplayName("Retail Outlet")]
        public string RetailOutlet { get; set; } = null;

        [DisplayName("Hours")]
        public string Hours { get; set; } = null;

        [DisplayName("Phone")]
        public string Phone { get; set; } = null;

        [DisplayName("Fax")]
        public string Fax { get; set; } = null;

        [DisplayName("Terminal")]
        public string Terminal { get; set; } = null;

        [DisplayName("Restricted Access")]
        public bool? RestrictedAccess { get; set; } = null;

        [DisplayName("Deposit Taking")]
        public bool? DepositTaking { get; set; } = null;

        [DisplayName("Limited Transactions")]
        public bool? LimitedTransactions { get; set; } = null;

        [DisplayName("Handicap Acces")]
        public bool? HandicapAccess { get; set; } = null;

        [DisplayName("Accepts Cash")]
        public bool? AcceptsCash { get; set; } = null;

        [DisplayName("Cashless")]
        public bool? Cashless { get; set; } = null;

        [DisplayName("Self Service Only")]
        public bool? SelfServiceOnly { get; set; } = null;

        [DisplayName("Surcharge")]
        public bool? Surcharge { get; set; } = null;

        [DisplayName("On Military Base")]
        public bool? OnMilitaryBase { get; set; } = null;

        [DisplayName("Military ID Required")]
        public bool? MilitaryIdrequired { get; set; } = null;

        [DisplayName("Additional Detail")]
        [StringLength(100)]
        public string AdditionalDetail { get; set; } = null;

        public List<Locations> locations;
        public List<Contact> contacts;
        public List<SpecialQualities> specialQualities;
        private readonly MaphawksContext context;

        public LocationsContactSpecialQualitiesViewModel() { }

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

        public Locations getNewLocation(string id)
        {
            // Locations row
            Locations location = new Locations();
            location.LocationId = id;
            location.City = City ?? null;
            location.Hours = Hours ?? null;
            location.InstitutionName = InstitutionName ?? null;
            location.Lat = Lat;
            location.Long = Long;
            location.RetailOutlet = RetailOutlet ?? null;
            location.State = State;
            location.Street = Street;
            location.Zipcode = Zipcode;

            return location;
        }

        public Contact getNewContact(string id)
        {
            Contact contact = new Contact();
            contact.LocationId = id;
            contact.Phone = Phone ?? null;
            contact.Fax = Fax ?? null;
            contact.Terminal = Terminal ?? null;

            return contact;
        }

        public SpecialQualities getNewSpecialQualities(string id)
        {
            SpecialQualities specialQuality = new SpecialQualities();
            specialQuality.AcceptsCash = AcceptsCash ?? null;
            specialQuality.AdditionalDetail = AdditionalDetail ?? null;
            specialQuality.Cashless = Cashless ?? null;
            specialQuality.DepositTaking = DepositTaking ?? null;
            specialQuality.HandicapAccess = HandicapAccess ?? null;
            specialQuality.LimitedTransactions = LimitedTransactions ?? null;
            specialQuality.LocationId = id;
            specialQuality.MilitaryIdrequired = MilitaryIdrequired ?? null;
            specialQuality.OnMilitaryBase = OnMilitaryBase ?? null;
            specialQuality.RestrictedAccess = RestrictedAccess ?? null;
            specialQuality.SelfServiceOnly = SelfServiceOnly ?? null;
            specialQuality.Surcharge = Surcharge ?? null;

            return specialQuality;
        }
    }
}
