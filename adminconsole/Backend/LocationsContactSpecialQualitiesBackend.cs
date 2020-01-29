using adminconsole.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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

        public async Task<List<Locations>> IndexAsync(bool deleted = false)
        {
            List<Locations> locations_list;
            if (deleted) // Get soft deleted records
            {
                locations_list = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.SoftDelete == true).ToListAsync().ConfigureAwait(false);
            } else 
            {
                locations_list = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.SoftDelete != true).ToListAsync().ConfigureAwait(false);
            }

            foreach (var location in locations_list)
            {
                ConvertDbStringsToEnums(location);
            }
            return locations_list;
        }

        public async Task<Locations> DetailsAsync(string id)
        {
            var resultLocation = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.LocationId == id).FirstAsync().ConfigureAwait(false);
            if (resultLocation == null)
            {
                return null;
            }

            ConvertDbStringsToEnums(resultLocation);
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
            catch (DbUpdateException)
            {
                return false;
            }

            return true;
        }

        public Locations GetLocation(string id)
        {
            Locations location = context.Locations.Include(x => x.Contact).Include(x => x.Contact).Where(x => x.LocationId == id).First();
            ConvertDbStringsToEnums(location);
            return location;
        }

        public async Task<bool> DeleteConfirmedAsync(string id)
        {
            try
            {
                var locations = await context.Locations.FindAsync(id);
                locations.SoftDelete = true;
                context.Locations.Update(locations);
                await context.SaveChangesAsync().ConfigureAwait(false);
                return true;
            } catch (DbUpdateException)
            {
                return false;
            }
            
        }

        public async Task<LocationsContactSpecialQualitiesViewModel> Edit(string id)
        {
            try
            {
                LocationsContactSpecialQualitiesViewModel location = new LocationsContactSpecialQualitiesViewModel();
                location.locations = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.LocationId == id).ToListAsync().ConfigureAwait(false);
                location.InstatiateViewModelPropertiesWithOneLocation();
                return location;
            } catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> EditPostAsync(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation == null)
            {
                return false;
            }

            Locations location = LocationsContactSpecialQualitiesViewModel.GetNewLocation(newLocation);
            Contacts contact = LocationsContactSpecialQualitiesViewModel.GetNewContact(newLocation);
            SpecialQualities specialQualities = LocationsContactSpecialQualitiesViewModel.GetNewSpecialQualities(newLocation);
            HoursPerDayOfTheWeek hoursPerDayOfTheWeek = LocationsContactSpecialQualitiesViewModel.GetNewHoursPerDayOfTheWeek(newLocation);

            try
            {
                context.Locations.Update(location);
                context.Contacts.Update(contact);
                context.SpecialQualities.Update(specialQualities);
                if (hoursPerDayOfTheWeek != null)
                {
                    context.HoursPerDayOfTheWeek.Update(hoursPerDayOfTheWeek);
                }
                var result = await context.SaveChangesAsync().ConfigureAwait(false);
                return true;
            } catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> RecoverAsync(string id)
        {
            try
            {
                var location = await context.Locations.FirstAsync(x => x.LocationId == id).ConfigureAwait(false);
                location.SoftDelete = false;
                context.Update(location);
                context.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        private static Locations ConvertDbStringsToEnums(Locations location)
        {
            var state = LocationsContactSpecialQualitiesViewModel.ConvertStringToStateEnum(location.State);
            var locationType = LocationsContactSpecialQualitiesViewModel.ConvertStringToLocationTypeEnum(location.LocationType);
            if (state != null) // If stored state name is a state abbreviation
            {
                location.State = state.GetType().GetMember(state.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
            }
            if (locationType != null) // If stored state name is a state abbreviation
            {
                location.LocationType = locationType.GetType().GetMember(locationType.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
            }
            return location;
        }
    }
}
