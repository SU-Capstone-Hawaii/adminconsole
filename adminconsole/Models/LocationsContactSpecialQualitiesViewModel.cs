using adminconsole.Backend;
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
        [EnumDataType(typeof(StateEnum))]
        public StateEnum State { get; set; }

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
        public BooleanEnum? RestrictedAccess { get; set; } = null;

        [DisplayName("Deposit Taking")]
        public BooleanEnum? DepositTaking { get; set; } = null;

        [DisplayName("Limited Transactions")]
        public BooleanEnum? LimitedTransactions { get; set; } = null;

        [DisplayName("Handicap Access")]
        public BooleanEnum? HandicapAccess { get; set; } = null;

        [DisplayName("Accepts Cash")]
        public BooleanEnum? AcceptsCash { get; set; } = null;

        [DisplayName("Cashless")]
        public BooleanEnum? Cashless { get; set; } = null;

        [DisplayName("Self Service Only")]
        public BooleanEnum? SelfServiceOnly { get; set; } = null;

        [DisplayName("Surcharge")]
        public BooleanEnum? Surcharge { get; set; } = null;

        [DisplayName("On Military Base")]
        public BooleanEnum? OnMilitaryBase { get; set; } = null;

        [DisplayName("Military ID Required")]
        public BooleanEnum? MilitaryIdRequired { get; set; } = null;

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
                locations = context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).ToList();
            } catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static Locations getNewLocation(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            // Locations row
            Locations location = new Locations();
            location.LocationId = newLocation.LocationId;
            location.City = newLocation.City ?? null;
            location.Hours = newLocation.Hours ?? null;
            location.InstitutionName = newLocation.InstitutionName ?? null;
            location.Lat = newLocation.Lat;
            location.Long = newLocation.Long;
            location.RetailOutlet = newLocation.RetailOutlet ?? null;
            location.TypeName = newLocation.TypeName;
            location.State = newLocation.State.ToString();
            location.Street = newLocation.Street;
            location.Zipcode = newLocation.Zipcode;

            return location;
        }

        public static Contact getNewContact(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            Contact contact = new Contact();
            contact.LocationId = newLocation.LocationId;
            contact.Phone = newLocation.Phone ?? null;
            contact.Fax = newLocation.Fax ?? null;
            contact.Terminal = newLocation.Terminal ?? null;

            return contact;
        }

        public static SpecialQualities getNewSpecialQualities(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            SpecialQualities specialQuality = new SpecialQualities();
            specialQuality.AcceptsCash = ConvertBooleanEnumToBool(newLocation.AcceptsCash);
            specialQuality.AdditionalDetail = newLocation.AdditionalDetail ?? null;
            specialQuality.Cashless = ConvertBooleanEnumToBool(newLocation.Cashless);
            specialQuality.DepositTaking = ConvertBooleanEnumToBool(newLocation.DepositTaking);
            specialQuality.HandicapAccess = ConvertBooleanEnumToBool(newLocation.HandicapAccess);
            specialQuality.LimitedTransactions = ConvertBooleanEnumToBool(newLocation.LimitedTransactions);
            specialQuality.LocationId = newLocation.LocationId;
            specialQuality.MilitaryIdRequired = ConvertBooleanEnumToBool(newLocation.MilitaryIdRequired);
            specialQuality.OnMilitaryBase = ConvertBooleanEnumToBool(newLocation.OnMilitaryBase);
            specialQuality.RestrictedAccess = ConvertBooleanEnumToBool(newLocation.RestrictedAccess);
            specialQuality.SelfServiceOnly = ConvertBooleanEnumToBool(newLocation.SelfServiceOnly);
            specialQuality.Surcharge = ConvertBooleanEnumToBool(newLocation.Surcharge);

            return specialQuality;
        }

        private static bool? ConvertBooleanEnumToBool(BooleanEnum? booleanEnum)
        {
            switch (booleanEnum)
            {
                case BooleanEnum.N:
                    return false;
                case BooleanEnum.Y:
                    return true;
                default:
                    return null;
            }
        }
    }
}
