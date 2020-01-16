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

        public bool Create(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            Console.WriteLine(newLocation.LocationId.Length);
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
    }
}
