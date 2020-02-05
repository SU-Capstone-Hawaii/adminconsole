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
        private DataSourceEnum dataSourceEnum;

        public LocationsContactSpecialQualitiesBackend(DataSourceEnum dataSourceEnum = DataSourceEnum.LIVE)
        {
            this.dataSourceEnum = dataSourceEnum;
        }

        public LocationsContactSpecialQualitiesBackend(MaphawksContext context, DataSourceEnum dataSourceEnum = DataSourceEnum.LIVE)
        {
            this.context = context;
            this.dataSourceEnum = dataSourceEnum;

        }

        public async Task<List<Locations>> IndexAsync(bool deleted = false)
        {
            if (dataSourceEnum is DataSourceEnum.LIVE)
            {
                List<Locations> locations_list;
                if (deleted) // Get soft deleted records
                {
                    locations_list = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.SoftDelete == true).ToListAsync().ConfigureAwait(false);
                }
                else
                {
                    locations_list = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.SoftDelete != true).ToListAsync().ConfigureAwait(false);
                }

                foreach (var location in locations_list)
                {
                    ConvertDbStringsToEnums(location);
                }
                return locations_list;
            } else
            {
                var dataMock = new LocationsContactSpecialQualitiesViewModelDataMock();
                List<LocationsContactSpecialQualitiesViewModel> viewModelList;
                List<Locations> locations_list = new List<Locations>();
                if (deleted) // Get soft deleted records
                {
                    viewModelList = dataMock.Get_All_ViewModel_List(deleted);
                }
                else
                {
                    viewModelList = dataMock.Get_All_ViewModel_List();
                }

                foreach (var location in viewModelList)
                {
                    var loc  = LocationsContactSpecialQualitiesViewModel.GetNewLocation(location);
                    locations_list.Add(ConvertDbStringsToEnums(loc));
                }
                return locations_list;
            }
        }

        public async Task<Locations> DetailsAsync(string id)
        {
            if (dataSourceEnum is DataSourceEnum.LIVE)
            {
                var resultLocation = await context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).Include(x => x.HoursPerDayOfTheWeek).Where(x => x.LocationId == id).FirstAsync().ConfigureAwait(false);
                if (resultLocation == null)
                {
                    return null;
                }

                ConvertDbStringsToEnums(resultLocation);
                return resultLocation;

            } else
            {
                var dataMock = new LocationsContactSpecialQualitiesViewModelDataMock();
                List<KeyValuePair<string, string>> keyValueList = new List<KeyValuePair<string, string>>();
                KeyValuePair<string, string> idPair = new KeyValuePair<string, string>("LocationId", id);

                
                keyValueList.Add(idPair);


                var resultLocation = LocationsContactSpecialQualitiesViewModel.GetNewLocation(
                    dataMock.GetOneLocation(keyValueList));

                if (resultLocation != null)
                {
                    ConvertDbStringsToEnums(resultLocation);
                }
                return resultLocation;
            }
        }

        public bool Create(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation == null)
            {
                return false;
            }
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
                LocationsContactSpecialQualitiesViewModel location = new LocationsContactSpecialQualitiesViewModel();
            
                location.locations = await context.Locations
                    .Include(x => x.Contact)
                    .Include(x => x.SpecialQualities)
                    .Include(x => x.HoursPerDayOfTheWeek)
                    .Where(x => x.LocationId == id)
                    .ToListAsync()
                    .ConfigureAwait(false);

                location.InstatiateViewModelPropertiesWithOneLocation();
                
                return location;
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
