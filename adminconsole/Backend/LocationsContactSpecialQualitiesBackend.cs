using adminconsole.Models;
using Microsoft.AspNetCore.Mvc;
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

        public List<Locations> Index()
        {
            var locations_list = context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).ToList();
            return locations_list;
        }

        public Locations Details(string id)
        {
            var resultLocation = context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.LocationId == id).First();
            if (resultLocation == null)
            {
                return null;
            }

            return resultLocation;
        }

        public bool Create(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            while (context.Locations.Where(x => x.LocationId == newLocation.LocationId).ToList().Any())
            {
                newLocation.LocationId = Guid.NewGuid().ToString();
            }
            Locations location = LocationsContactSpecialQualitiesViewModel.GetNewLocation(newLocation);
            Contacts contact = LocationsContactSpecialQualitiesViewModel.GetNewContact(newLocation);
            SpecialQualities specialQuality = LocationsContactSpecialQualitiesViewModel.GetNewSpecialQualities(newLocation);
            HoursPerDayOfTheWeek hoursPerDayOfTheWeek = LocationsContactSpecialQualitiesViewModel.GetNewHoursPerDayOfTheWeek(newLocation);

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
