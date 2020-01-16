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
        public MaphawksContext context;

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

        public Locations Details(string id)
        {
            var resultLocation = context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Where(x => x.LocationId == id).First();
            if (resultLocation == null)
            {
                return null;
            }

            return resultLocation ;
        }

        public bool Create(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            while(context.Locations.Where(x => x.LocationId == newLocation.LocationId).ToList().Any())
            {
                newLocation.LocationId = Guid.NewGuid().ToString();
            }
            Locations location = LocationsContactSpecialQualitiesViewModel.getNewLocation(newLocation);
            Contact contact = LocationsContactSpecialQualitiesViewModel.getNewContact(newLocation);
            SpecialQualities specialQuality = LocationsContactSpecialQualitiesViewModel.getNewSpecialQualities(newLocation);

            try
            {
                context.Add(location);
                context.Add(contact);
                context.Add(specialQuality);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public Locations GetLocation(string id)
        {
            Locations location = context.Locations.Include(x => x.Contact).Include(x => x.Contact).Where(x => x.LocationId == id).First();
            return location;
        }
    }
}
