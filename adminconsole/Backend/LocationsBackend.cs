﻿using adminconsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace adminconsole.Backend
{
    public class LocationsBackend
    {
        private MaphawksContext context;            // DB Context
        private DataSourceEnum dataSourceEnum;      // Allows for toggling betwen Live/Test data
        private AllTablesViewModelDataMock dataMock;

        public Exception errorMessage = null;


        /// <summary>
        /// 
        /// Constructor without DB Context for Unit Testing
        /// 
        /// </summary>
        /// 
        /// 
        /// <param name="dataSourceEnum"> Default is for Live (DB) data. Can also set to DataSourceEnum.Test for Unit Testing </param>
        public LocationsBackend(DataSourceEnum dataSourceEnum = DataSourceEnum.LIVE)
        {
            this.dataSourceEnum = dataSourceEnum;

            if (dataSourceEnum is DataSourceEnum.TEST)
            {
                dataMock = new AllTablesViewModelDataMock();
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
        public LocationsBackend(MaphawksContext context)
        {
            this.context = context;
            this.dataSourceEnum = DataSourceEnum.LIVE;

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
            var locations_list = new List<Locations>();

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use database
            {

                locations_list = await ReadMultipleRecordsAsync().ConfigureAwait(false); // Select * join all tables


            } else
            {
                var viewModelList = dataMock.GetAllViewModelList(deleted);

                if (viewModelList != null) // If there are records
                {
                    foreach (var location in viewModelList) // Convert ViewModels into Locations
                    {
                        var newLocation = AllTablesViewModel.GetNewLocation(location);
                        newLocation.Contact = AllTablesViewModel.GetNewContact(location);
                        newLocation.SpecialQualities = AllTablesViewModel.GetNewSpecialQualities(location);
                        newLocation.DailyHours = AllTablesViewModel.GetNewDailyHours(location);


                        locations_list.Add(newLocation);

                    }
                }
            }


            foreach (var location in locations_list)
            {
                ConvertDbStringsToEnums(location);
            }
            return locations_list;
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
                var resultLocation = await ReadOneRecordAsync(id).ConfigureAwait(false);
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


                var resultLocation = AllTablesViewModel.GetNewLocation(
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
        /// Creates new Locations, Contacts, SpecialQualities, DailyHours.
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
        public bool Create(AllTablesViewModel newLocation)
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



                Locations location = AllTablesViewModel.GetNewLocation(newLocation);
                Contacts contact = AllTablesViewModel.GetNewContact(newLocation);
                SpecialQualities specialQuality = AllTablesViewModel.GetNewSpecialQualities(newLocation);
                DailyHours DailyHours = AllTablesViewModel.GetNewDailyHours(newLocation);



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
        public async Task<Locations> GetLocationAsync(string id)
        {
            if (id == null)
            {
                return null;
            }

            Locations location;

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {
                location = await ReadOneRecordAsync(id).ConfigureAwait(false);
            }
            else // Use mock data
            {
                List<KeyValuePair<string, string>> newList = new List<KeyValuePair<string, string>>();
                KeyValuePair<string, string> idPair = new KeyValuePair<string, string>("LocationId", id);



                newList.Add(idPair);


                AllTablesViewModel locationViewModel = dataMock.GetOneLocation(newList);
                location = AllTablesViewModel.GetNewLocation(locationViewModel);


                if (location != null) // Then we can fill in other tables' values
                {
                    location.Contact = AllTablesViewModel.GetNewContact(locationViewModel);
                    location.SpecialQualities = AllTablesViewModel.GetNewSpecialQualities(locationViewModel);
                    location.DailyHours = AllTablesViewModel.GetNewDailyHours(locationViewModel);
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
        public async Task<AllTablesViewModel> EditAsync(string id)
        {
            if (id == null)
            {
                return null;
            }


            AllTablesViewModel locationViewModel = null;


            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {

                var location = await ReadOneRecordAsync(id).ConfigureAwait(false); // Get Location from Database

                if (location != null)
                {
                    locationViewModel = new AllTablesViewModel(location);
                }
            } else // Use Mock
            {
                var whereList = new List<KeyValuePair<string, string>>();
                var idPair = new KeyValuePair<string, string>("LocationId", id);
                whereList.Add(idPair);


                locationViewModel = dataMock.GetOneLocation(whereList);
            }

            return locationViewModel;
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
        public async Task<bool> EditPostAsync(AllTablesViewModel newLocation)
        {
            if (newLocation == null)
            {
                return false;
            }


            Locations response = await ReadOneRecordAsync(newLocation.LocationId).ConfigureAwait(true);


            if (response is null)  // Location does not exist
            {
                return false;
            }


            // Get each table's Object
            Locations location = AllTablesViewModel.GetNewLocation(newLocation);
            location.Contact = AllTablesViewModel.GetNewContact(newLocation);
            location.SpecialQualities = AllTablesViewModel.GetNewSpecialQualities(newLocation);
            location.DailyHours = AllTablesViewModel.GetNewDailyHours(newLocation);


            bool result = false; // Value to be returned

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {
                try
                {
                    _AddDeleteRow(response.Contact, location.Contact);
                    _AddDeleteRow(response.SpecialQualities, location.SpecialQualities);
                    _AddDeleteRow(response.DailyHours, location.DailyHours);


                    response = location;

                    result = AlterRecordInfo(AlterRecordInfoEnum.Update, response);

                    return result;
                }
                catch (Exception e)
                {
                    errorMessage = e;
                    return false;
                }
            } else // Use mock data
            {
                result = dataMock.EditPostAsync(location, location.Contact, location.SpecialQualities, location.DailyHours);
            }

            return true;
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
                locations = await ReadOneRecordAsync(id).ConfigureAwait(false);
            }
            else
            {
                var whereList = new List<KeyValuePair<string, string>>();
                var idPair = new KeyValuePair<string, string>("LocationId", id);
                whereList.Add(idPair);
                locations = AllTablesViewModel.GetNewLocation(dataMock.GetOneLocation(whereList));
            }

            if (locations == null) // Record not found
            {
                return false;
            }

            locations.SoftDelete = true;

            if (dataSourceEnum is DataSourceEnum.LIVE)
            {
                try
                {
                    AlterRecordInfo(AlterRecordInfoEnum.Update, locations);
                    return true;
                }
                catch (DbUpdateException)
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
            if (id == null)
            {
                return false;
            }

            Locations location = new Locations();

            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {

                // Get the record
                location = await ReadOneRecordAsync(id).ConfigureAwait(false);


            } else // Use mock data
            {
                // Mock the SQL statment
                var whereClause = new List<KeyValuePair<string, string>>();
                var idPair = new KeyValuePair<string, string>("LocationId", id);
                whereClause.Add(idPair);


                // Get the record
                var locationViewModel = dataMock.GetOneLocation(whereClause);



                if (locationViewModel is null) // Record doesn't exist
                {

                    location = null;


                } else // Mimic the structure that would be received from the Database
                {

                    location = AllTablesViewModel.GetNewLocation(locationViewModel);


                }
            }

            if (location is null)  // Location doesn't exist
            {
                return false;
            }


            // Change SoftDelete value to False
            location.SoftDelete = false;


            if (dataSourceEnum is DataSourceEnum.LIVE) // Use Database
            {


                try
                {
                    AlterRecordInfo(AlterRecordInfoEnum.Update, location);
                    return true;
                }
                catch (DbUpdateException)
                {
                    return false;
                }


            } else // Use mock data
            {

                dataMock.Recover(location);
                return true;

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
            var state = AllTablesViewModel.ConvertStringToStateEnum(location.State);
            var locationType = AllTablesViewModel.ConvertStringToLocationTypeEnum(location.LocationType);



            location.State = state.GetType().GetMember(state.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;


            location.LocationType = locationType.GetType().GetMember(locationType.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;

            return location;
        }







        /// <summary>
        /// Reads one record from the database given its Location ID
        /// </summary>
        /// 
        /// 
        /// <param name="referenceId"> The LocationId of the record to retrieve from the database </param>
        /// 
        /// 
        /// <returns> A location object if the record exists, otherwise null </returns>
        private async Task<Locations> ReadOneRecordAsync(string referenceId)
        {
            if (string.IsNullOrEmpty(referenceId) &&
                string.IsNullOrWhiteSpace(referenceId))
            {
                return null;
            }


            var result = await context.Locations
                            .Include(c => c.Contact)
                            .Include(s => s.SpecialQualities)
                            .Include(h => h.DailyHours)
                            .AsNoTracking()
                            .FirstAsync()
                            .ConfigureAwait(false);

            return result;
        }






        /// <summary>
        /// Reads all records from database. 
        /// </summary>
        /// 
        /// 
        /// <param name="isDeleted"> If true, return soft deleted records, otherwise return existing records </param>
        /// 
        /// 
        /// <returns> List<Locations> object if any records in databse, otherwise returns null </returns>
        private async Task<List<Locations>> ReadMultipleRecordsAsync(bool isDeleted = false)
        {
            var result = await context.Locations
                         .Include(c => c.Contact)
                         .Include(s => s.SpecialQualities)
                         .Include(h => h.DailyHours)
                         .AsNoTracking()
                         .Where(record => record.SoftDelete == isDeleted)
                         .ToListAsync()
                         .ConfigureAwait(false);

            return result;
        }







        /// <summary>
        /// Alters location record information, whether it be through: 
        ///     CREATING a new record,
        ///     UPDATING a prexisting record,
        ///     DELETING a preexisting record, or
        ///     RECOVERING a delete Locations record
        /// </summary>
        /// 
        /// 
        /// <param name="action"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        private bool AlterRecordInfo(AlterRecordInfoEnum action, IMaphawksDatabaseTable table)
        {
            if (table is null)
            {
                return false;
            }


            var table_type = GetTable(table);



            switch (table_type)
            {

                #region Locations
                case Table.Locations:


                    var locations_record = (Locations)table;

                    if (action is AlterRecordInfoEnum.Create)
                    {

                        try
                        {
                            context.Add(locations_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }

                    }


                    if (action is AlterRecordInfoEnum.Update)
                    {

                        try
                        {
                            context.Update(locations_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    if (action is AlterRecordInfoEnum.Delete)
                    {
                        try
                        {
                            locations_record.SoftDelete = true;
                            context.Update(locations_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }




                    if (action is AlterRecordInfoEnum.Recover)
                    {
                        try
                        {
                            locations_record.SoftDelete = false;
                            context.Update(locations_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    return false;

                #endregion

                
                    
                
                #region Contact
                case Table.Contacts:


                    var contact_record = (Contacts)table;

                    if (action is AlterRecordInfoEnum.Create)
                    {

                        try
                        {
                            context.Add(contact_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }

                    }


                    if (action is AlterRecordInfoEnum.Update)
                    {

                        try
                        {
                            context.Update(contact_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    if (action is AlterRecordInfoEnum.Delete)
                    {
                        try
                        {
                            context.Remove(context.Contacts.Single(c => c.LocationId.Equals(contact_record.LocationId)));
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }

                    return false;

                #endregion



                #region Special Qualities
                case Table.Special_Qualities:


                    var special_qualities_record = (SpecialQualities)table;

                    if (action is AlterRecordInfoEnum.Create)
                    {

                        try
                        {
                            context.Add(special_qualities_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }

                    }


                    if (action is AlterRecordInfoEnum.Update)
                    {

                        try
                        {
                            context.Update(special_qualities_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    if (action is AlterRecordInfoEnum.Delete)
                    {
                        try
                        {
                            context.Remove(context.SpecialQualities.Single(c => c.LocationId.Equals(special_qualities_record.LocationId)));
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    return false;

                #endregion



                #region Daily Hours
                case Table.Daily_Hours:


                    var daily_hours_record = (DailyHours)table;

                    if (action is AlterRecordInfoEnum.Create)
                    {

                        try
                        {
                            context.Add(daily_hours_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }

                    }


                    if (action is AlterRecordInfoEnum.Update)
                    {

                        try
                        {
                            context.Update(daily_hours_record);
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    if (action is AlterRecordInfoEnum.Delete)
                    {
                        try
                        {
                            context.Remove(context.DailyHours.Single(c => c.LocationId.Equals(daily_hours_record.LocationId)));
                            context.SaveChanges();
                            return true;
                        }
                        catch (DbUpdateException)
                        {
                            return false;
                        }
                    }


                    return false;

                #endregion


                default:
                    return false;
            }
        }


        private Table GetTable(IMaphawksDatabaseTable record)
        {
            if (!(record as Locations is null))
            {
                return Table.Locations;
            }


            if (!(record as Contacts is null))
            {
                return Table.Contacts;
            }


            if (!(record as SpecialQualities is null))
            {
                return Table.Special_Qualities;
            }


            if (!(record as DailyHours is null))
            {
                return Table.Daily_Hours;
            }


            return Table.None;
        }




        /// <summary>
        /// Adds a row in Contacts, SpecialQualities, or DailyHours table if one didn't exist before an edit.
        /// 
        /// Deletes a row in Contacts, SpecialQualities, or DailyHours table if after an edit an entire row's fields are null.
        /// </summary>
        /// 
        /// 
        /// <param name="referenceRow"> The row before the edit </param>
        /// <param name="editedRow"> The row after the edit </param>
        private void _AddDeleteRow (IMaphawksDatabaseTable referenceRow, IMaphawksDatabaseTable editedRow)
        {
            if (referenceRow is null && editedRow is null ||        // Don't need to add a new row
                !(referenceRow is null) && !(editedRow is null))
            {
                return;
            }

            if (referenceRow is null && !(editedRow is null))       // Add row
            {
                var table = GetTable(editedRow);

                switch (table)
                {

                    case (Table.Contacts):
                        
                        AlterRecordInfo(AlterRecordInfoEnum.Create, (Contacts)editedRow);
                        return;

                    case (Table.Special_Qualities):

                        AlterRecordInfo(AlterRecordInfoEnum.Create, (SpecialQualities)editedRow);
                        return;

                    case (Table.Daily_Hours):

                        AlterRecordInfo(AlterRecordInfoEnum.Create, (DailyHours)editedRow);
                        return;

                    default:
                        return;
                }
                
            }



            if (!(referenceRow is null) && editedRow is null)       // Delete row
            {
                var table = GetTable(referenceRow);

                switch (table)
                {

                    case (Table.Contacts):

                        AlterRecordInfo(AlterRecordInfoEnum.Delete, (Contacts)referenceRow);
                        return;

                    case (Table.Special_Qualities):

                        AlterRecordInfo(AlterRecordInfoEnum.Delete, (SpecialQualities)referenceRow);
                        return;

                    case (Table.Daily_Hours):

                        AlterRecordInfo(AlterRecordInfoEnum.Delete, (DailyHours)referenceRow);
                        return;

                    default:
                        return;
                }

            }

        }
    }
}
