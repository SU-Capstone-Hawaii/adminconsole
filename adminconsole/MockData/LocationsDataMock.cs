using System;
using System.Collections.Generic;
using System.Linq;

namespace adminconsole.Models
{
    /// <summary>
    /// Acts in place of DB. Assumes the query will conduct a join on all tables.
    /// </summary>
    public class LocationsDataMock
    {
        // List of DB rows
        private List<Locations> liveLocations;
        private List<Locations> deletedLocations;

        /// <summary>
        /// Constructor. Puts object in a valid state.
        /// </summary>
        public LocationsDataMock()
        {
            liveLocations = new List<Locations>();
            deletedLocations = new List<Locations>();
            SetDefaultValues();
        }




        /// <summary>
        /// Returns viewModelList and deletedViewModelList elements to their original values
        /// </summary>
        /// 
        /// 
        /// <returns> true if no error. else false </returns>
        public bool ResetDefaultValues()
        {
            liveLocations = null;
            deletedLocations = null;
            return SetDefaultValues();
        }




        /// <summary>
        /// Helper method to repopulate viewModelList with default data.
        /// </summary>
        /// 
        /// 
        /// <returns>
        /// 
        /// True: If creates all default ViewModel Objects successfully
        /// False: If there is an instantiation error, which will occur only if the Models' (and thereby the ViewModel's)
        ///        properties change.
        /// 
        /// </returns>
        private bool SetDefaultValues()
        {

            // Create ViewModel Objects
            Locations location_1 = InstantiateLocation(new Locations());
            Locations location_2 = InstantiateLocation(new Locations());
            Locations location_3 = InstantiateLocation(new Locations());
            Locations location_4 = InstantiateLocation(new Locations());
            Locations location_5 = InstantiateLocation(new Locations());


            // Set each object's properties
            //---------LOCATION 1---------NO NULL//
            location_1.SpecialQualities.AcceptCash = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.AcceptDeposit = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.Access = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.AccessNotes = "Lobby";
            location_1.Address = "362 Oxford Dr.";
            location_1.SpecialQualities.Cashless = BooleanEnum.Y.ToString();
            location_1.City = "Starkville";
            location_1.CoopLocationId = "WA9820-174920573";
            location_1.Country = "US";
            location_1.County = "King County";
            location_1.SpecialQualities.DriveThruOnly = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.EnvelopeRequired = BooleanEnum.Y.ToString();
            location_1.Contact.Fax = "8058451931";
            location_1.SpecialQualities.HandicapAccess = BooleanEnum.Y.ToString();
            location_1.Hours = "24 HOURS ACCESS";
            location_1.DailyHours.HoursDtfriClose = "9";
            location_1.DailyHours.HoursDtfriOpen = "9";
            location_1.DailyHours.HoursDtmonClose = "9";
            location_1.DailyHours.HoursDtmonOpen = "9";
            location_1.DailyHours.HoursDtsatClose = "9";
            location_1.DailyHours.HoursDtsatOpen = "9";
            location_1.DailyHours.HoursDtsunClose = "9";
            location_1.DailyHours.HoursDtsunOpen = "9";
            location_1.DailyHours.HoursDtthuClose = "9";
            location_1.DailyHours.HoursDtthuOpen = "9";
            location_1.DailyHours.HoursDttueClose = "9";
            location_1.DailyHours.HoursDttueOpen = "9";
            location_1.DailyHours.HoursDtwedClose = "9";
            location_1.DailyHours.HoursDtwedOpen = "9";
            location_1.DailyHours.HoursFriClose = "9";
            location_1.DailyHours.HoursFriOpen = "9";
            location_1.DailyHours.HoursMonClose = "9";
            location_1.DailyHours.HoursMonOpen = "9";
            location_1.DailyHours.HoursSatClose = "9";
            location_1.DailyHours.HoursSatOpen = "9";
            location_1.DailyHours.HoursSunClose = "9";
            location_1.DailyHours.HoursSunOpen = "9";
            location_1.DailyHours.HoursThuClose = "9";
            location_1.DailyHours.HoursThuOpen = "9";
            location_1.DailyHours.HoursTueClose = "9";
            location_1.DailyHours.HoursTueOpen = "9";
            location_1.DailyHours.HoursWedClose = "9";
            location_1.DailyHours.HoursWedOpen = "9";
            location_1.SpecialQualities.InstallationType = "Walk-Up";
            location_1.Latitude = 13.3108M;
            location_1.SpecialQualities.LimitedTransactions = BooleanEnum.Y.ToString();
            location_1.LocationId = "11170401-4112-43c1-aa4e-f73370e1014a";
            location_1.LocationType = LocationTypeEnum.A.ToString();
            location_1.Longitude = -132.8851M;
            location_1.SpecialQualities.MilitaryIdRequired = BooleanEnum.Y.ToString();
            location_1.Name = "BECU";
            location_1.SpecialQualities.OnMilitaryBase = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.OnPremise = BooleanEnum.Y.ToString();
            location_1.Contact.Phone = "4896771019";
            location_1.PostalCode = "39759";
            location_1.SpecialQualities.RestrictedAccess = BooleanEnum.Y.ToString();
            location_1.RetailOutlet = "Northgate";
            location_1.SpecialQualities.SelfServiceDevice = BooleanEnum.Y.ToString();
            location_1.SpecialQualities.SelfServiceOnly = BooleanEnum.Y.ToString();
            location_1.SoftDelete = true;
            location_1.State = StateEnum.MS.ToString();
            location_1.SpecialQualities.Surcharge = BooleanEnum.Y.ToString();
            location_1.TakeCoopData = true;
            location_1.Contact.WebAddress = "https://trypap.com/";

            //---------LOCATION 2--------- ALL SPECIAL QUALITIES NULL//
            location_2.SpecialQualities.AcceptCash = null;
            location_2.SpecialQualities.AcceptDeposit = null;
            location_2.SpecialQualities.Access = null;
            location_2.SpecialQualities.AccessNotes = null;
            location_2.Address = "7520 S. Edgewood Road";
            location_2.SpecialQualities.Cashless = null;
            location_2.City = "Gulfport";
            location_2.CoopLocationId = "WA9820-174920573";
            location_2.Country = "US";
            location_2.County = "King County";
            location_2.SpecialQualities.DriveThruOnly = null;
            location_2.SpecialQualities.EnvelopeRequired = null;
            location_2.Contact.Fax = "2429781246";
            location_2.SpecialQualities.HandicapAccess = null;
            location_2.Hours = "BUSINESS HOURS ACCESS";
            location_2.DailyHours.HoursDtfriClose = "9";
            location_2.DailyHours.HoursDtfriOpen = "9";
            location_2.DailyHours.HoursDtmonClose = "9";
            location_2.DailyHours.HoursDtmonOpen = "9";
            location_2.DailyHours.HoursDtsatClose = "9";
            location_2.DailyHours.HoursDtsatOpen = "9";
            location_2.DailyHours.HoursDtsunClose = "9";
            location_2.DailyHours.HoursDtsunOpen = "9";
            location_2.DailyHours.HoursDtthuClose = "9";
            location_2.DailyHours.HoursDtthuOpen = "9";
            location_2.DailyHours.HoursDttueClose = "9";
            location_2.DailyHours.HoursDttueOpen = "9";
            location_2.DailyHours.HoursDtwedClose = "9";
            location_2.DailyHours.HoursDtwedOpen = "9";
            location_2.DailyHours.HoursFriClose = "9";
            location_2.DailyHours.HoursFriOpen = "9";
            location_2.DailyHours.HoursMonClose = "9";
            location_2.DailyHours.HoursMonOpen = "9";
            location_2.DailyHours.HoursSatClose = "9";
            location_2.DailyHours.HoursSatOpen = "9";
            location_2.DailyHours.HoursSunClose = "9";
            location_2.DailyHours.HoursSunOpen = "9";
            location_2.DailyHours.HoursThuClose = "9";
            location_2.DailyHours.HoursThuOpen = "9";
            location_2.DailyHours.HoursTueClose = "9";
            location_2.DailyHours.HoursTueOpen = "9";
            location_2.DailyHours.HoursWedClose = "9";
            location_2.DailyHours.HoursWedOpen = "9";
            location_2.SpecialQualities.InstallationType = "Walk-Up";
            location_2.Latitude = 64.4829M;
            location_2.SpecialQualities.LimitedTransactions = null;
            location_2.LocationId = "2f104551-5140-4394-bce7-11a6a5b53db9";
            location_2.LocationType = LocationTypeEnum.S.ToString();
            location_2.Longitude = 87.9330M;
            location_2.SpecialQualities.MilitaryIdRequired = null;
            location_2.Name = "SoundCU";
            location_2.SpecialQualities.OnMilitaryBase = null;
            location_2.SpecialQualities.OnPremise = null;
            location_2.Contact.Phone = "4153066399";
            location_2.PostalCode = "39503";
            location_2.SpecialQualities.RestrictedAccess = null;
            location_2.RetailOutlet = "Ala Moana";
            location_2.SpecialQualities.SelfServiceDevice = null;
            location_2.SpecialQualities.SelfServiceOnly = null;
            location_2.SoftDelete = true;
            location_2.State = StateEnum.MS.ToString();
            location_2.SpecialQualities.Surcharge = null;
            location_2.TakeCoopData = true;
            location_2.Contact.WebAddress = "http://corndog.io/";

            //---------LOCATION 3---------ALL CONTACT NULL//
            location_3.SpecialQualities.AcceptCash = BooleanEnum.N.ToString();
            location_3.SpecialQualities.AcceptDeposit = BooleanEnum.N.ToString();
            location_3.SpecialQualities.Access = BooleanEnum.N.ToString();
            location_3.SpecialQualities.AccessNotes = "No bills larger than 20";
            location_3.Address = "8966C Henry Smith Lane";
            location_3.SpecialQualities.Cashless = BooleanEnum.N.ToString();
            location_3.City = "Palos Verdes Peninsula";
            location_3.CoopLocationId = "WA9820-174920573";
            location_3.Country = "US";
            location_3.County = "King County";
            location_3.SpecialQualities.DriveThruOnly = BooleanEnum.N.ToString();
            location_3.SpecialQualities.EnvelopeRequired = BooleanEnum.N.ToString();
            location_3.Contact.Fax = null;
            location_3.SpecialQualities.HandicapAccess = BooleanEnum.N.ToString();
            location_3.Hours = "24 HOURS ACCESS";
            location_3.DailyHours.HoursDtfriClose = "9";
            location_3.DailyHours.HoursDtfriOpen = "9";
            location_3.DailyHours.HoursDtmonClose = "9";
            location_3.DailyHours.HoursDtmonOpen = "9";
            location_3.DailyHours.HoursDtsatClose = "9";
            location_3.DailyHours.HoursDtsatOpen = "9";
            location_3.DailyHours.HoursDtsunClose = "9";
            location_3.DailyHours.HoursDtsunOpen = "9";
            location_3.DailyHours.HoursDtthuClose = "9";
            location_3.DailyHours.HoursDtthuOpen = "9";
            location_3.DailyHours.HoursDttueClose = "9";
            location_3.DailyHours.HoursDttueOpen = "9";
            location_3.DailyHours.HoursDtwedClose = "9";
            location_3.DailyHours.HoursDtwedOpen = "9";
            location_3.DailyHours.HoursFriClose = "9";
            location_3.DailyHours.HoursFriOpen = "9";
            location_3.DailyHours.HoursMonClose = "9";
            location_3.DailyHours.HoursMonOpen = "9";
            location_3.DailyHours.HoursSatClose = "9";
            location_3.DailyHours.HoursSatOpen = "9";
            location_3.DailyHours.HoursSunClose = "9";
            location_3.DailyHours.HoursSunOpen = "9";
            location_3.DailyHours.HoursThuClose = "9";
            location_3.DailyHours.HoursThuOpen = "9";
            location_3.DailyHours.HoursTueClose = "9";
            location_3.DailyHours.HoursTueOpen = "9";
            location_3.DailyHours.HoursWedClose = "9";
            location_3.DailyHours.HoursWedOpen = "9";
            location_3.SpecialQualities.InstallationType = "Walk-Up";
            location_3.Latitude = -66.4245M;
            location_3.SpecialQualities.LimitedTransactions = BooleanEnum.N.ToString();
            location_3.LocationId = "6cc2244b-ff5b-4860-8464-2e5186b7060f";
            location_3.LocationType = LocationTypeEnum.S.ToString();
            location_3.Longitude = -17.9152M;
            location_3.SpecialQualities.MilitaryIdRequired = BooleanEnum.N.ToString();
            location_3.Name = "VerityCU";
            location_3.SpecialQualities.OnMilitaryBase = BooleanEnum.N.ToString();
            location_3.SpecialQualities.OnPremise = BooleanEnum.N.ToString();
            location_3.Contact.Phone = null;
            location_3.PostalCode = "90274";
            location_3.SpecialQualities.RestrictedAccess = BooleanEnum.N.ToString();
            location_3.RetailOutlet = "Pearl Ridge";
            location_3.SpecialQualities.SelfServiceDevice = BooleanEnum.N.ToString();
            location_3.SpecialQualities.SelfServiceOnly = BooleanEnum.N.ToString();
            location_3.SoftDelete = true;
            location_3.State = StateEnum.CA.ToString();
            location_3.SpecialQualities.Surcharge = BooleanEnum.N.ToString();
            location_3.TakeCoopData = true;
            location_3.Contact.WebAddress = null;


            //---------LOCATION 4---------ALL OPTIONAL IN LOCATIONS NULL//
            location_4.SpecialQualities.AcceptCash = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.AcceptDeposit = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.Access = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.AccessNotes = "Public entry on noth-side of 34th St.";
            location_4.Address = "7307 Poor House Ave.";
            location_4.SpecialQualities.Cashless = BooleanEnum.Y.ToString();
            location_4.City = "West Bloomfield";
            location_4.CoopLocationId = null;
            location_4.Country = null;
            location_4.County = null;
            location_4.SpecialQualities.DriveThruOnly = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.EnvelopeRequired = BooleanEnum.Y.ToString();
            location_4.Contact.Fax = "9166280006";
            location_4.SpecialQualities.HandicapAccess = BooleanEnum.Y.ToString();
            location_4.Hours = null;
            location_4.DailyHours.HoursDtfriClose = "9";
            location_4.DailyHours.HoursDtfriOpen = "9";
            location_4.DailyHours.HoursDtmonClose = "9";
            location_4.DailyHours.HoursDtmonOpen = "9";
            location_4.DailyHours.HoursDtsatClose = "9";
            location_4.DailyHours.HoursDtsatOpen = "9";
            location_4.DailyHours.HoursDtsunClose = "9";
            location_4.DailyHours.HoursDtsunOpen = "9";
            location_4.DailyHours.HoursDtthuClose = "9";
            location_4.DailyHours.HoursDtthuOpen = "9";
            location_4.DailyHours.HoursDttueClose = "9";
            location_4.DailyHours.HoursDttueOpen = "9";
            location_4.DailyHours.HoursDtwedClose = "9";
            location_4.DailyHours.HoursDtwedOpen = "9";
            location_4.DailyHours.HoursFriClose = "9";
            location_4.DailyHours.HoursFriOpen = "9";
            location_4.DailyHours.HoursMonClose = "9";
            location_4.DailyHours.HoursMonOpen = "9";
            location_4.DailyHours.HoursSatClose = "9";
            location_4.DailyHours.HoursSatOpen = "9";
            location_4.DailyHours.HoursSunClose = "9";
            location_4.DailyHours.HoursSunOpen = "9";
            location_4.DailyHours.HoursThuClose = "9";
            location_4.DailyHours.HoursThuOpen = "9";
            location_4.DailyHours.HoursTueClose = "9";
            location_4.DailyHours.HoursTueOpen = "9";
            location_4.DailyHours.HoursWedClose = "9";
            location_4.DailyHours.HoursWedOpen = "9";
            location_4.SpecialQualities.InstallationType = "Walk-Up";
            location_4.Latitude = -53.0338M;
            location_4.SpecialQualities.LimitedTransactions = BooleanEnum.Y.ToString();
            location_4.LocationId = "a91be80e-ed05-4157-bb95-aa3494663d2a";
            location_4.LocationType = LocationTypeEnum.A.ToString();
            location_4.Longitude = -40.3143M;
            location_4.SpecialQualities.MilitaryIdRequired = BooleanEnum.Y.ToString();
            location_4.Name = null;
            location_4.SpecialQualities.OnMilitaryBase = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.OnPremise = BooleanEnum.Y.ToString();
            location_4.Contact.Phone = "9997957521";
            location_4.PostalCode = "48322";
            location_4.SpecialQualities.RestrictedAccess = BooleanEnum.Y.ToString();
            location_4.RetailOutlet = null;
            location_4.SpecialQualities.SelfServiceDevice = BooleanEnum.Y.ToString();
            location_4.SpecialQualities.SelfServiceOnly = BooleanEnum.Y.ToString();
            location_4.SoftDelete = false;
            location_4.State = StateEnum.MI.ToString();
            location_4.SpecialQualities.Surcharge = BooleanEnum.Y.ToString();
            location_4.TakeCoopData = true;
            location_4.Contact.WebAddress = "https://www.movenowthinklater.com/";

            //---------LOCATION 5---------AS MANY NULLS AS POSSIBLE//
            location_5.SpecialQualities.AcceptCash = null;
            location_5.SpecialQualities.AcceptDeposit = null;
            location_5.SpecialQualities.Access = null;
            location_5.SpecialQualities.AccessNotes = null;
            location_5.Address = "8071 Sunbeam Court";
            location_5.SpecialQualities.Cashless = null;
            location_5.City = "Massillon";
            location_5.CoopLocationId = null;
            location_5.Country = null;
            location_5.County = null;
            location_5.SpecialQualities.DriveThruOnly = null;
            location_5.SpecialQualities.EnvelopeRequired = null;
            location_5.Contact.Fax = "9166280006";
            location_5.SpecialQualities.HandicapAccess = null;
            location_5.Hours = null;
            location_5.DailyHours.HoursDtfriClose = null;
            location_5.DailyHours.HoursDtfriOpen = null;
            location_5.DailyHours.HoursDtmonClose = null;
            location_5.DailyHours.HoursDtmonOpen = null;
            location_5.DailyHours.HoursDtsatClose = null;
            location_5.DailyHours.HoursDtsatOpen = null;
            location_5.DailyHours.HoursDtsunClose = null;
            location_5.DailyHours.HoursDtsunOpen = null;
            location_5.DailyHours.HoursDtthuClose = null;
            location_5.DailyHours.HoursDtthuOpen = null;
            location_5.DailyHours.HoursDttueClose = null;
            location_5.DailyHours.HoursDttueOpen = null;
            location_5.DailyHours.HoursDtwedClose = null;
            location_5.DailyHours.HoursDtwedOpen = null;
            location_5.DailyHours.HoursFriClose = null;
            location_5.DailyHours.HoursFriOpen = null;
            location_5.DailyHours.HoursMonClose = null;
            location_5.DailyHours.HoursMonOpen = null;
            location_5.DailyHours.HoursSatClose = null;
            location_5.DailyHours.HoursSatOpen = null;
            location_5.DailyHours.HoursSunClose = null;
            location_5.DailyHours.HoursSunOpen = null;
            location_5.DailyHours.HoursThuClose = null;
            location_5.DailyHours.HoursThuOpen = null;
            location_5.DailyHours.HoursTueClose = null;
            location_5.DailyHours.HoursTueOpen = null;
            location_5.DailyHours.HoursWedClose = null;
            location_5.DailyHours.HoursWedOpen = null;
            location_5.SpecialQualities.InstallationType = null;
            location_5.Latitude = -20.9110M;
            location_5.SpecialQualities.LimitedTransactions = null;
            location_5.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
            location_5.LocationType = LocationTypeEnum.A.ToString();
            location_5.Longitude = -84.8988M;
            location_5.SpecialQualities.MilitaryIdRequired = null;
            location_5.Name = null;
            location_5.SpecialQualities.OnMilitaryBase = null;
            location_5.SpecialQualities.OnPremise = null;
            location_5.Contact.Phone = "9997957521";
            location_5.PostalCode = "44646";
            location_5.SpecialQualities.RestrictedAccess = null;
            location_5.RetailOutlet = null;
            location_5.SpecialQualities.SelfServiceDevice = null;
            location_5.SpecialQualities.SelfServiceOnly = null;
            location_5.SoftDelete = false;
            location_5.State = StateEnum.OH.ToString();
            location_5.SpecialQualities.Surcharge = null;
            location_5.TakeCoopData = false;
            location_5.Contact.WebAddress = null;



            // Re-Instantiate list object
            deletedLocations = new List<Locations>();
            liveLocations = new List<Locations>();


            // Add locations to list
            deletedLocations.Add(location_1);
            deletedLocations.Add(location_2);
            deletedLocations.Add(location_3);
            liveLocations.Add(location_4);
            liveLocations.Add(location_5);

            return true;
        }





        /// <summary>
        /// Returns the full list. Equivalent to a SELECT * FROM {join all tables}
        /// </summary>
        /// 
        /// 
        /// <returns> 
        /// 
        /// viewModelList: if deleted is false
        /// deletedViewModelList: If deleted is true
        /// 
        /// </returns>
        public List<Locations> GetAllViewModelList(bool deleted = false)
        {
            if (deleted)
            {
                return deletedLocations;
            }
            else
            {
                return liveLocations;
            }
        }







        /// <summary>
        /// Returns only the location records that match the given where criteria.
        /// </summary>
        /// 
        /// 
        /// <param name="whereClauses"> The list of where clauses, given as key=column name, value=column value </param>
        /// 
        /// 
        /// <returns> List<AllTablesViewModel>. List may have length of 0 or more. </returns>
        public List<Locations> Get_Where_ViewModel_List(List<KeyValuePair<string, string>> whereClauses)
        {
            List<Locations> return_list = new List<Locations>();

            if (whereClauses == null)
            {
                return_list = liveLocations;
                return return_list;
            }
            else
            {
                foreach (Locations location in liveLocations)
                {
                    bool meetsWhereCriteria = true;
                    foreach (KeyValuePair<string, string> column in whereClauses)
                    {
                        bool result = IsMatch(column, location);
                        if (!result)
                        {
                            meetsWhereCriteria = false;
                            break;
                        }
                    }

                    if (meetsWhereCriteria)
                    {
                        return_list.Add(location);
                    }
                }
                return return_list;
            }
        }







        /// <summary>
        /// Helper function to determine of the given where clause matches its corresponding column in a specified location.
        /// </summary>
        /// 
        /// 
        /// <param name="pair"> KeyValuePair<string, string> where key=column name, value=column value of the where clause. </param>
        /// <param name="location"> The AllTablesViewModel object being compared to. </param>
        /// 
        /// 
        /// <returns> true if match, else false. </returns>
        private bool IsMatch(KeyValuePair<string, string> pair, Locations location)
        {
            var valueIsNull = pair.Value is null ? true : false;

            switch (pair.Key)
            {
                case "AcceptCash":
                    return StringsAreEqual(location.SpecialQualities.AcceptCash.ToString().Trim(), pair.Value.Trim());


                case "AcceptDeposit":
                    return StringsAreEqual(location.SpecialQualities.AcceptDeposit.ToString().Trim(), pair.Value.Trim());


                case "Access":
                    return StringsAreEqual(location.SpecialQualities.Access.ToString().Trim(), pair.Value.Trim());


                case "AccessNotes":
                    return StringsAreEqual(location.SpecialQualities.AccessNotes.Trim(), pair.Value.Trim());


                case "Address":
                    return StringsAreEqual(location.Address.Trim(), pair.Value.Trim());


                case "Cashless":
                    return StringsAreEqual(location.SpecialQualities.Cashless.ToString().Trim(), pair.Value.Trim());


                case "City":
                    return StringsAreEqual(location.City.Trim(), pair.Value.Trim());


                case "CoopLocationId":
                    return StringsAreEqual(location.CoopLocationId.Trim(), pair.Value.Trim());


                case "Country":
                    return StringsAreEqual(location.Country.Trim(), pair.Value.Trim());


                case "County":
                    return StringsAreEqual(location.County.Trim(), pair.Value.Trim());


                case "DriveThruOnly":
                    return StringsAreEqual(location.SpecialQualities.DriveThruOnly.ToString().Trim(), pair.Value.Trim());


                case "EnvelopeRequired":
                    return StringsAreEqual(location.SpecialQualities.EnvelopeRequired.ToString().Trim(), pair.Value.Trim());


                case "Fax":
                    return StringsAreEqual(location.Contact.Fax.Trim(), pair.Value.Trim());


                case "HandicapAccess":
                    return StringsAreEqual(location.SpecialQualities.HandicapAccess.ToString().Trim(), pair.Value.Trim());


                case "Hours":
                    return StringsAreEqual(location.Hours.Trim(), pair.Value.Trim());


                case "HoursDtfriClose":
                    return StringsAreEqual(location.DailyHours.HoursDtfriClose.Trim(), pair.Value.Trim());


                case "HoursDtfriOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtfriOpen.Trim(), pair.Value.Trim());


                case "HoursDtmonClose":
                    return StringsAreEqual(location.DailyHours.HoursDtmonClose.Trim(), pair.Value.Trim());


                case "HoursDtmonOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtmonOpen.Trim(), pair.Value.Trim());


                case "HoursDtsatClose":
                    return StringsAreEqual(location.DailyHours.HoursDtsatClose.Trim(), pair.Value.Trim());


                case "HoursDtsatOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtsatOpen.Trim(), pair.Value.Trim());


                case "HoursDtsunClose":
                    return StringsAreEqual(location.DailyHours.HoursDtsunClose.Trim(), pair.Value.Trim());


                case "HoursDtsunOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtsunOpen.Trim(), pair.Value.Trim());


                case "HoursDtthuClose":
                    return StringsAreEqual(location.DailyHours.HoursDtthuClose.Trim(), pair.Value.Trim());


                case "HoursDtthuOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtthuOpen.Trim(), pair.Value.Trim());


                case "HoursDttueClose":
                    return StringsAreEqual(location.DailyHours.HoursDttueClose.Trim(), pair.Value.Trim());


                case "HoursDttueOpen":
                    return StringsAreEqual(location.DailyHours.HoursDttueOpen.Trim(), pair.Value.Trim());


                case "HoursDtwedClose":
                    return StringsAreEqual(location.DailyHours.HoursDtwedClose.Trim(), pair.Value.Trim());


                case "HoursDtwedOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtwedOpen.Trim(), pair.Value.Trim());


                case "HoursFriClose":
                    return StringsAreEqual(location.DailyHours.HoursFriClose.Trim(), pair.Value.Trim());


                case "HoursFriOpen":
                    return StringsAreEqual(location.DailyHours.HoursFriOpen.Trim(), pair.Value.Trim());


                case "HoursMonClose":
                    return StringsAreEqual(location.DailyHours.HoursMonClose.Trim(), pair.Value.Trim());


                case "HoursMonOpen":
                    return StringsAreEqual(location.DailyHours.HoursMonOpen.Trim(), pair.Value.Trim());


                case "HoursSatClose":
                    return StringsAreEqual(location.DailyHours.HoursSatClose.Trim(), pair.Value.Trim());


                case "HoursSatOpen":
                    return StringsAreEqual(location.DailyHours.HoursSatOpen.Trim(), pair.Value.Trim());


                case "HoursSunClose":
                    return StringsAreEqual(location.DailyHours.HoursSunClose.Trim(), pair.Value.Trim());


                case "HoursSunOpen":
                    return StringsAreEqual(location.DailyHours.HoursSunOpen.Trim(), pair.Value.Trim());


                case "HoursThuClose":
                    return StringsAreEqual(location.DailyHours.HoursThuClose.Trim(), pair.Value.Trim());


                case "HoursThuOpen":
                    return StringsAreEqual(location.DailyHours.HoursThuOpen.Trim(), pair.Value.Trim());


                case "HoursTueClose":
                    return StringsAreEqual(location.DailyHours.HoursTueClose.Trim(), pair.Value.Trim());


                case "HoursTueOpen":
                    return StringsAreEqual(location.DailyHours.HoursDtfriClose.Trim(), pair.Value.Trim());


                case "HoursWedClose":
                    return StringsAreEqual(location.DailyHours.HoursWedClose.Trim(), pair.Value.Trim());


                case "HoursWedOpen":
                    return StringsAreEqual(location.DailyHours.HoursWedOpen.Trim(), pair.Value.Trim());


                case "InstallationType":
                    return StringsAreEqual(location.SpecialQualities.InstallationType.Trim(), pair.Value.Trim());


                case "Latitude":
                    return location.Latitude == decimal.Parse(pair.Value.Trim());


                case "LimitedTransactions":
                    return StringsAreEqual(location.SpecialQualities.LimitedTransactions.ToString().Trim(), pair.Value.Trim());


                case "LocationId":
                    return StringsAreEqual(location.LocationId.Trim(), pair.Value.Trim());


                case "LocationType":
                    return StringsAreEqual(location.LocationType.ToString().Trim(), pair.Value.Trim());


                case "Longitude":
                    return location.Longitude == decimal.Parse(pair.Value.Trim());


                case "MilitaryIdRequired":
                    return StringsAreEqual(location.SpecialQualities.MilitaryIdRequired.ToString().Trim(), pair.Value.Trim());


                case "Name":
                    return StringsAreEqual(location.Name.Trim(), pair.Value.Trim());


                case "OnMilitaryBase":
                    return StringsAreEqual(location.SpecialQualities.OnMilitaryBase.ToString().Trim(), pair.Value.Trim());


                case "OnPremise":
                    return StringsAreEqual(location.SpecialQualities.OnPremise.ToString().Trim(), pair.Value.Trim());


                case "Phone":
                    return StringsAreEqual(location.Contact.Phone.Trim(), pair.Value.Trim());


                case "PostalCode":
                    return StringsAreEqual(location.PostalCode.Trim(), pair.Value.Trim());


                case "RestrictedAccess":
                    return StringsAreEqual(location.SpecialQualities.RestrictedAccess.ToString().Trim(), pair.Value.Trim());


                case "RetailOutlet":
                    return StringsAreEqual(location.RetailOutlet.Trim(), pair.Value.Trim());


                case "SelfServiceDevice":
                    return StringsAreEqual(location.SpecialQualities.SelfServiceDevice.ToString().Trim(), pair.Value.Trim());


                case "SelfServiceOnly":
                    return StringsAreEqual(location.SpecialQualities.SelfServiceOnly.ToString().Trim(), pair.Value.Trim());


                case "SoftDelete":
                    return StringsAreEqual(location.SoftDelete.ToString().Trim(), pair.Value.Trim());


                case "State":
                    return StringsAreEqual(location.State.ToString().Trim(), pair.Value.Trim());


                case "Surcharge":
                    return StringsAreEqual(location.SpecialQualities.Surcharge.ToString().Trim(), pair.Value.Trim());


                case "TakeCoopData":
                    return StringsAreEqual(location.TakeCoopData.ToString(), pair.Value.Trim());


                case "WebAddress":
                    return StringsAreEqual(location.Contact.WebAddress.Trim(), pair.Value.Trim());


                default:
                    return false;
            }
        }






        /// <summary>
        /// Compares nullable strings
        /// </summary>
        /// 
        /// 
        /// <param name="mockLocation"> Location from viewModelList </param>
        /// <param name="unitTestLocation"> Location passed in from Unit Testing class </param>
        /// 
        /// 
        /// <returns> True if equal, otherwise false </returns>
        private bool StringsAreEqual(string mockLocation, string unitTestLocation)
        {
            if (unitTestLocation is null &&
                mockLocation is null)
            {
                return true;
            }


            if (unitTestLocation is null &&
                !(mockLocation is null))
            {
                return false;
            }

            return unitTestLocation.Equals(mockLocation);
        }






        /// <summary>
        /// Same as Get_Where_ViewModel_List except will only return at most one location.
        /// </summary>
        /// 
        /// 
        /// <param name="whereClauses"> The list of where clauses, given as key=column name, value=column value </param>
        /// 
        /// 
        /// <returns> The first location that meets the where clause conditions, otherwise null </returns>
        public Locations GetOneLocation(List<KeyValuePair<string, string>> whereClauses)
        {
            if (whereClauses is null)
            {
                return liveLocations.First();
            }
            else
            {
                // Check if in viewModelList
                foreach (Locations location in liveLocations)
                {
                    bool isAMatch = true;
                    foreach (KeyValuePair<string, string> column in whereClauses)
                    {
                        bool result = IsMatch(column, location);
                        if (!result)
                        {
                            isAMatch = false;
                            break;
                        }
                    }

                    if (isAMatch)
                    {
                        return location;
                    }
                }


                // Check if in deletedViewModelList
                foreach (Locations location in deletedLocations)
                {
                    bool isAMatch = true;
                    foreach (KeyValuePair<string, string> column in whereClauses)
                    {
                        bool result = IsMatch(column, location);
                        if (!result)
                        {
                            isAMatch = false;
                            break;
                        }
                    }

                    if (isAMatch)
                    {
                        return location;
                    }
                }

                return null;
            }

        }




        /// <summary>
        /// Adds new ViewModel object to the viewModelList
        /// </summary>
        /// <param name="newLocation"></param>
        public void Create(Locations newLocation)
        {
            if (newLocation == null)
            {
                return;
            }


            foreach (var location in liveLocations) // Checks if LocationId is in 'live' list
            {
                if (location.LocationId == newLocation.LocationId)
                {
                    return;
                }
            }


            foreach (var location in deletedLocations) // Checks if LocationId is in 'deleted list'
            {
                if (location.LocationId == newLocation.LocationId)
                {
                    return;
                }
            }

            liveLocations.Add(newLocation);
        }




        /// <summary>
        /// Gets number of records in either viewModelList or deletedViewModelList.
        /// </summary>
        /// 
        ///   
        /// <param name="deleted"> Determines if we want to see 'Deleted' records or 'Live' records </param>
        /// 
        /// 
        /// <returns> The number of records in either viewModelList or deletedViewModelList </returns>
        public int GetNumberOfLocations(bool deleted = false)
        {
            if (deleted)
            {
                return deletedLocations.Count;
            }
            else
            {
                return liveLocations.Count;
            }
        }






        /// <summary>
        /// Removes Location record from viewModelList and adds it to deletedViewModelList if
        /// the LocationId exists in viewModelList.
        /// </summary>
        /// 
        /// 
        /// 
        /// <param name="location"> 
        /// The Locations object which contains the LocationId of the Locations record to delete
        /// </param>
        public void Delete(Locations location)
        {
            if (location == null)
            {
                return;
            }
            else
            {
                Locations deletedLocation = null;

                // Find the Location record
                foreach (var loc in liveLocations)
                {
                    if (loc.LocationId == location.LocationId) // Find record, break
                    {
                        deletedLocation = loc;
                        break;
                    }
                }


                // Delete the Location record
                if (deletedLocation == null)
                {
                    return;
                }
                else
                {
                    liveLocations.Remove(deletedLocation);
                }
            }
        }






        public bool EditPostAsync(Locations location, Contacts contact, SpecialQualities specialQuality, DailyHours dailyHours)
        {
            if (location == null) // Cannot have a null Locations object
            {
                return false;
            }


            // Assign foreign key tables to Locations object
            location.Contact = contact;
            location.SpecialQualities = specialQuality;
            location.DailyHours = dailyHours;


            // Find Locations Object in liveLocations
            var originalLocationRecordIndex = liveLocations.FindIndex(obj => obj.LocationId.Equals(location.LocationId));

            if (originalLocationRecordIndex == -1) // The record doesn't exist
            {
                return false;
            }


            liveLocations[originalLocationRecordIndex] = location;

            return true;
        }
    
    
    

        public void Recover(Locations location)
        {
            if  (location is null)
            {
                return;
            }

            // Look for deleted record
            var index = deletedLocations.FindIndex(obj => obj.LocationId.Equals(location.LocationId));
            
            if (index == -1) // Record hasn't been deleted or doesn't exist
            {
                return;
            }


            // Recover
            var recoveredLocation = deletedLocations[index];
            recoveredLocation.SoftDelete = false;


            // Update lists
            liveLocations.Add(recoveredLocation);
            deletedLocations.RemoveAt(index);

        }





        private Locations InstantiateLocation(Locations location)
        {
            location.Contact = new Contacts();
            location.SpecialQualities = new SpecialQualities();
            location.DailyHours = new DailyHours();
            return location;
        }
    }
}
