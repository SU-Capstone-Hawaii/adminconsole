using adminconsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminconsole.Backend
{
    public class LocationsContactSpecialQualitiesBackend
    {
        private MaphawksContext context;

        public LocationsContactSpecialQualitiesBackend(MaphawksContext context)
        {
            this.context = context;
        }

        public LocationsContactSpecialQualitiesViewModel Index()
        {
            LocationsContactSpecialQualitiesViewModel locations = new LocationsContactSpecialQualitiesViewModel(context);
            var result = locations.Index();
            /*foreach (var row in context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).ToList()) 
            {
                var loc = new LocationsContactSpecialQualitiesViewModel();
                loc.AcceptsCash = row.SpecialQualities.AcceptsCash;
                loc.AdditionalDetail = row.SpecialQualities.AdditionalDetail;
                loc.Cashless = row.SpecialQualities.Cashless;
                loc.City = row.City;
                loc.DepositTaking = row.SpecialQualities.DepositTaking;
                loc.Fax = row.Contact.Fax;
                loc.HandicapAccess = row.SpecialQualities.HandicapAccess;
                loc.Hours = row.Hours;
                loc.InstitutionName = row.InstitutionName;
                loc.Lat = row.Lat;
                loc.LimitedTransactions = row.SpecialQualities.LimitedTransactions;
                loc.LocationId = row.LocationId;
                loc.Long = row.Long;
                loc.MilitaryIdrequired = row.SpecialQualities.MilitaryIdrequired;
                loc.OnMilitaryBase = row.SpecialQualities.OnMilitaryBase;
                loc.Phone = row.Contact.Phone;
                loc.RestrictedAccess = row.SpecialQualities.RestrictedAccess;
                loc.RetailOutlet = row.RetailOutlet;
                loc.SelfServiceOnly = row.SpecialQualities.SelfServiceOnly;
                loc.State = row.State;
                loc.Street = row.Street;
                loc.Surcharge = row.SpecialQualities.Surcharge;
                loc.Terminal = row.Contact.Terminal;
                loc.Zipcode = row.Zipcode;

                locations.Add(loc);
            }*/
            if (!result)
            {
                LocationsContactSpecialQualitiesViewModel loc = new LocationsContactSpecialQualitiesViewModel(context);
                return loc;
            }
            return locations;
        }
    }
}
