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
        private MaphawksContext context;            // DB Context
        private DataSourceEnum dataSourceEnum;      // Allows for toggling betwen Live/Test data
        private LocationsContactSpecialQualitiesViewModelDataMock dataMock;


        /// <summary>
        /// 
        /// Constructor without DB Context for Unit Testing
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="dataSourceEnum"> Default is for Live (DB) data. Can also set to DataSourceEnum.Test for Unit Testing </param>
        public LocationsContactSpecialQualitiesBackend(DataSourceEnum dataSourceEnum = DataSourceEnum.LIVE)
        {
            this.dataSourceEnum = dataSourceEnum;
            
            if (dataSourceEnum is DataSourceEnum.TEST)
            {
                dataMock = new LocationsContactSpecialQualitiesViewModelDataMock();
            }
        }






        /// <summary>
        /// 
        /// Constructor with DB Context for Live Dependency Injection
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="context"> DB Context Object </param>
        public LocationsContactSpecialQualitiesBackend(MaphawksContext context)
        {
            this.context = context;
            this.dataSourceEnum = dataSourceEnum;

        }






        /// <summary>
        /// 
        /// Gets all Locations Objects with a join on all tables on LocationId. 
        /// If deleted == false: fetches live records (SoftDelete != true)
        /// If deleted == true: fetched deleted records (SoftDelete == true)
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="deleted"> Lets you choose between deleted or live Locations records </param>
        /// 
        /// 
        /// <returns> Returns List of Locations Objects </returns>
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






        /// <summary>
        /// 
        /// Gets a single Locations record with a join on all tables on LocationId
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="id">  The string ID of the Location record requested by the user </param>
        /// 
        /// 
        /// <returns> Returns a single Locations Object </returns>
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







        /// <summary>
        /// 
        /// Creates new Locations, Contacts, SpecialQualities, HoursPerDayOfTheWeek.
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> ViewModel with properties corresponding to the fields for each table </param>
        /// 
        /// 
        /// <returns> 
        /// 
        /// False: If newLocation is null or there was an error when attempting to insert
        /// True: It newLocation is successfully inserted into the Database
        /// 
        /// </returns>
        public bool Create(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation == null) // Non-valid ViewModel Object
            {
                return false;
            }


            if (dataSourceEnum is DataSourceEnum.LIVE) // Use the Database
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

            } else // Use mock data
            {
                var originalNumberOfLocations = dataMock.GetNumberOfLocations();
                dataMock.Create(newLocation);
                var newNumberOfLocations = dataMock.GetNumberOfLocations();


                return (originalNumberOfLocations + 1) == newNumberOfLocations;
            }

        }





        /// <summary>
        /// 
        /// Gets a single Locations Object from the Database given an LocationId.
        /// Used by LocationsController: Edit (Post), Delete (Get)
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="id"> The string ID of a Locations Object </param>
        /// 
        /// 
        /// <returns> If the record doesn't exist returns NULL, otherwise returns the Locations Object </returns>
        public Locations GetLocation(string id)
        {
            if (id == null)
            {
                return null;
            }

            Locations location;

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {
                location = context.Locations.Include(x => x.Contact).Include(x => x.Contact).Where(x => x.LocationId == id).First();
            }
            else // Use mock data
            {
                List<KeyValuePair<string, string>> newList = new List<KeyValuePair<string, string>>();
                KeyValuePair<string, string> idPair = new KeyValuePair<string, string>("LocationId", id);
                
                
                
                newList.Add(idPair);


                LocationsContactSpecialQualitiesViewModel locationViewModel = dataMock.GetOneLocation(newList);
                location = LocationsContactSpecialQualitiesViewModel.GetNewLocation(locationViewModel);


                if (location != null) // Then we can fill in other tables' values
                {
                    location.Contact = LocationsContactSpecialQualitiesViewModel.GetNewContact(locationViewModel);
                    location.SpecialQualities = LocationsContactSpecialQualitiesViewModel.GetNewSpecialQualities(locationViewModel);
                    location.HoursPerDayOfTheWeek = LocationsContactSpecialQualitiesViewModel.GetNewHoursPerDayOfTheWeek(locationViewModel);
                }

            }

            if (location != null)
            {
                ConvertDbStringsToEnums(location);
            }

            return location;
        }






        /// <summary>
        /// 
        /// Soft Deletes a Locations Object.
        /// 
        /// </summary>
        /// 
        /// <param name="id"> The string ID of the Locations Object the user wants to Delete </param>
        /// 
        /// <returns>
        /// 
        /// True: If successfully updates SoftDelete field to True
        /// False: If Database error or if the LocationId does not exist in Database
        /// 
        /// </returns>
        public async Task<bool> DeleteConfirmedAsync(string id)
        {

            if (id == null)
            {
                return false;
            }

            Locations locations;

            if (dataSourceEnum is DataSourceEnum.LIVE)
            {
                locations = await context.Locations.FindAsync(id);
            } else
            {
                var whereList = new List<KeyValuePair<string, string>>();
                var idPair = new KeyValuePair<string, string>("LocationId", id);
                whereList.Add(idPair);
                locations = LocationsContactSpecialQualitiesViewModel.GetNewLocation(dataMock.GetOneLocation(whereList));
            }

            if (locations == null)
            {
                return false;
            }

            locations.SoftDelete = true;

            if (dataSourceEnum is DataSourceEnum.LIVE)
            {
                try
                {
                    context.Locations.Update(locations);
                    await context.SaveChangesAsync().ConfigureAwait(false);
                    return true;
                } catch (DbUpdateException)
                {
                    return false;
                }
            }
            else
            {
                var originalNumberOfLocations = dataMock.GetNumberOfLocations();
                dataMock.Delete(locations);
                var newNumberOfLocations = dataMock.GetNumberOfLocations();

                return (originalNumberOfLocations - 1) == newNumberOfLocations;
            }
            
            
        }



        /// <summary>
        /// 
        /// Gets the Location Object given a LocationId for the User to Edit upon
        /// 
        /// </summary>
        /// 
        /// <param name="id"> The string ID of the Locations Object the user wants to Edit </param>
        /// 
        /// <returns> 
        /// 
        /// NULL: If Location record does not exist with the given ID
        /// Locations Object: If the record was found in the Database
        /// 
        /// </returns>
        public async Task<LocationsContactSpecialQualitiesViewModel> EditAsync(string id)
        {
            if (id == null)
            {
                return null;
            }


            LocationsContactSpecialQualitiesViewModel location;
            

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {
                location = new LocationsContactSpecialQualitiesViewModel();


                location.locations = await context.Locations // Get Location from Database 
                .Include(x => x.Contact)
                .Include(x => x.SpecialQualities)
                .Include(x => x.HoursPerDayOfTheWeek)
                .Where(x => x.LocationId == id)
                .ToListAsync()
                .ConfigureAwait(false);

                if (location != null)
                {
                    location.InstatiateViewModelPropertiesWithOneLocation();
                }
            } else // Use Mock
            {
                var whereList = new List<KeyValuePair<string, string>>();
                var idPair = new KeyValuePair<string, string>("LocationId", id);
                whereList.Add(idPair);


                location = dataMock.GetOneLocation(whereList);
            }

            return location;
        }





        /// <summary>
        /// 
        /// Updates the Location Record in the Database
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> ViewModel Object containing the data for the fields of all the tables provided by the user </param>
        /// 
        /// 
        /// <returns>
        /// 
        /// True: If successfully updates Location record in DB
        /// False: If newLocation is null, of if there was a Database Update error
        /// 
        /// </returns>
        public async Task<bool> EditPostAsync(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation == null)
            {
                return false;
            }


            // Get each table's Object
            Locations location = LocationsContactSpecialQualitiesViewModel.GetNewLocation(newLocation);
            Contacts contact = LocationsContactSpecialQualitiesViewModel.GetNewContact(newLocation);
            SpecialQualities specialQualities = LocationsContactSpecialQualitiesViewModel.GetNewSpecialQualities(newLocation);
            HoursPerDayOfTheWeek hoursPerDayOfTheWeek = LocationsContactSpecialQualitiesViewModel.GetNewHoursPerDayOfTheWeek(newLocation);

            bool result; // Value to be returned

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {
                try
                {
                    context.Locations.Update(location);
                    context.Contacts.Update(contact);
                    context.SpecialQualities.Update(specialQualities);
                    if (hoursPerDayOfTheWeek != null)
                    {
                        context.HoursPerDayOfTheWeek.Update(hoursPerDayOfTheWeek);
                    }
                    result = Convert.ToBoolean(await context.SaveChangesAsync().ConfigureAwait(false));
                }
                catch (DbUpdateConcurrencyException)
                {
                    result = false;
                }
            } else // Use mock data
            {                
                result = dataMock.EditPostAsync(location, contact, specialQualities, hoursPerDayOfTheWeek);
            }


            return result;
            
        }




        /// <summary>
        /// 
        /// Recovers a deleted Locations record
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="id"> The string ID for the Locations Object the user wants to recover </param>
        /// 
        /// 
        /// <returns>
        /// 
        /// True: If the Locations record's SoftDelete field was successfully changed to False
        /// False: If there was a Database error when trying to Update the Locations record
        /// 
        /// </returns>
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




        /// <summary>
        /// 
        /// Converts Database State and LocationType strings to their corresponding Enum values so that we can use these values in the ViewModel.
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="location"> A Locations Object </param>
        /// 
        /// <returns> The Updated Location. </returns>
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
