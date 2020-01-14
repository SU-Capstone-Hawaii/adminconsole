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
            if (!result)
            {
                LocationsContactSpecialQualitiesViewModel loc = new LocationsContactSpecialQualitiesViewModel(context);
                return loc;
            }
            return locations;
        }

        public LocationsContactSpecialQualitiesViewModel Details(string id)
        {
            var resultLocation = context.Locations.Where(x => x.LocationId == id).First();
            if (resultLocation == null)
            {
                return null;
            }
            var resultContact = context.Contact.Where(x => x.LocationId == id).First();
            var resultSpecialQualities = context.SpecialQualities.Where(x => x.LocationId == id).First();

            LocationsContactSpecialQualitiesViewModel resultViewModel = new LocationsContactSpecialQualitiesViewModel(context);
            resultViewModel.locations.Add(resultLocation);
            resultViewModel.contacts.Add(resultContact);
            resultViewModel.specialQualities.Add(resultSpecialQualities);
            

            return resultViewModel;
        }
    }
}
