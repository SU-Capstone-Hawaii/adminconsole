using System;
using System.Collections.Generic;
using System.Linq;

namespace adminconsole.Models
{
    /// <summary>
    /// Acts in place of DB. Assumes the query will conduct a join on all tables.
    /// </summary>
    public class LocationsContactSpecialQualitiesViewModelDataMock
    {
        // List of DB rows
        private List<LocationsContactSpecialQualitiesViewModel> viewModelList;

        /// <summary>
        /// Constructor. Puts object in a valid state.
        /// </summary>
        public LocationsContactSpecialQualitiesViewModelDataMock()
        {
            viewModelList = new List<LocationsContactSpecialQualitiesViewModel>();
            SetDefaultValues();
        }

        /// <summary>
        /// Returns viewModelList elements to their original values
        /// </summary>
        /// <returns> true if no error. else false </returns>
        public bool ResetDefaultValues()
        {
            viewModelList = null;
            return SetDefaultValues();
        }

        /// <summary>
        /// Helper method to repopulate viewModelList with default data.
        /// </summary>
        /// <returns></returns>
        private bool SetDefaultValues()
        {
            try
            {
                // Create ViewModel Objects
                LocationsContactSpecialQualitiesViewModel location_1 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_2 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_3 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_4 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_5 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_6 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_7 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_8 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_9 = new LocationsContactSpecialQualitiesViewModel();
                LocationsContactSpecialQualitiesViewModel location_10 = new LocationsContactSpecialQualitiesViewModel();

                // Set each object's properties
                //---------LOCATION 1---------NO NULL//
                location_1.AcceptCash = BooleanEnum.Y;
                location_1.AcceptDeposit = BooleanEnum.Y;
                location_1.Access = BooleanEnum.Y;
                location_1.AccessNotes = "Lobby";
                location_1.Address = "362 Oxford Dr.";
                location_1.Cashless = BooleanEnum.Y;
                location_1.City = "Starkville";
                location_1.CoopLocationId = "WA9820-174920573";
                location_1.Country = "US";
                location_1.County = "King County";
                location_1.DriveThruOnly = BooleanEnum.Y;
                location_1.EnvelopeRequired = BooleanEnum.Y;
                location_1.Fax = "8058451931";
                location_1.HandicapAccess = BooleanEnum.Y;
                location_1.Hours = "24 HOURS ACCESS";
                location_1.HoursDtfriClose = "9";
                location_1.HoursDtfriOpen = "9";
                location_1.HoursDtmonClose = "9";
                location_1.HoursDtmonOpen = "9";
                location_1.HoursDtsatClose = "9";
                location_1.HoursDtsatOpen = "9";
                location_1.HoursDtsunClose = "9";
                location_1.HoursDtsunOpen = "9";
                location_1.HoursDtthuClose = "9";
                location_1.HoursDtthuOpen = "9";
                location_1.HoursDttueClose = "9";
                location_1.HoursDttueOpen = "9";
                location_1.HoursDtwedClose = "9";
                location_1.HoursDtwedOpen = "9";
                location_1.HoursFriClose = "9";
                location_1.HoursFriOpen = "9";
                location_1.HoursMonClose = "9";
                location_1.HoursMonOpen = "9";
                location_1.HoursSatClose = "9";
                location_1.HoursSatOpen = "9";
                location_1.HoursSunClose = "9";
                location_1.HoursSunOpen = "9";
                location_1.HoursThuClose = "9";
                location_1.HoursThuOpen = "9";
                location_1.HoursTueClose = "9";
                location_1.HoursTueOpen = "9";
                location_1.HoursWedClose = "9";
                location_1.HoursWedOpen = "9";
                location_1.InstallationType = "Walk-Up";
                location_1.Latitude = 13.3108M;
                location_1.LimitedTransactions = BooleanEnum.Y;
                location_1.LocationId = "11170401-4112-43c1-aa4e-f73370e1014a";
                location_1.locations = new List<Locations>();
                location_1.LocationType = LocationTypeEnum.A;
                location_1.Longitude = -132.8851M;
                location_1.MilitaryIdRequired = BooleanEnum.Y;
                location_1.Name = "BECU";
                location_1.OnMilitaryBase = BooleanEnum.Y;
                location_1.OnPremise = BooleanEnum.Y;
                location_1.Phone = "4896771019";
                location_1.PostalCode = "39759";
                location_1.RestrictedAccess = BooleanEnum.Y;
                location_1.RetailOutlet = "Northgate";
                location_1.SelfServiceDevice = BooleanEnum.Y;
                location_1.SelfServiceOnly = BooleanEnum.Y;
                location_1.SoftDelete = BooleanEnum.Y;
                location_1.State = StateEnum.MS;
                location_1.Surcharge = BooleanEnum.Y;
                location_1.TakeCoopData = BooleanEnum.Y;
                location_1.WebAddress = "https://trypap.com/";

                //---------LOCATION 2--------- ALL SPECIAL QUALITIES NULL//
                location_2.AcceptCash = BooleanEnum.NULL;
                location_2.AcceptDeposit = BooleanEnum.NULL;
                location_2.Access = BooleanEnum.NULL;
                location_2.AccessNotes = null;
                location_2.Address = "7520 S. Edgewood Road";
                location_2.Cashless = BooleanEnum.NULL;
                location_2.City = "Gulfport";
                location_2.CoopLocationId = "WA9820-174920573";
                location_2.Country = "US";
                location_2.County = "King County";
                location_2.DriveThruOnly = BooleanEnum.NULL;
                location_2.EnvelopeRequired = BooleanEnum.NULL;
                location_2.Fax = "2429781246";
                location_2.HandicapAccess = BooleanEnum.NULL;
                location_2.Hours = "BUSINESS HOURS ACCESS";
                location_2.HoursDtfriClose = "9";
                location_2.HoursDtfriOpen = "9";
                location_2.HoursDtmonClose = "9";
                location_2.HoursDtmonOpen = "9";
                location_2.HoursDtsatClose = "9";
                location_2.HoursDtsatOpen = "9";
                location_2.HoursDtsunClose = "9";
                location_2.HoursDtsunOpen = "9";
                location_2.HoursDtthuClose = "9";
                location_2.HoursDtthuOpen = "9";
                location_2.HoursDttueClose = "9";
                location_2.HoursDttueOpen = "9";
                location_2.HoursDtwedClose = "9";
                location_2.HoursDtwedOpen = "9";
                location_2.HoursFriClose = "9";
                location_2.HoursFriOpen = "9";
                location_2.HoursMonClose = "9";
                location_2.HoursMonOpen = "9";
                location_2.HoursSatClose = "9";
                location_2.HoursSatOpen = "9";
                location_2.HoursSunClose = "9";
                location_2.HoursSunOpen = "9";
                location_2.HoursThuClose = "9";
                location_2.HoursThuOpen = "9";
                location_2.HoursTueClose = "9";
                location_2.HoursTueOpen = "9";
                location_2.HoursWedClose = "9";
                location_2.HoursWedOpen = "9";
                location_2.InstallationType = "Walk-Up";
                location_2.Latitude = 64.4829M;
                location_2.LimitedTransactions = BooleanEnum.NULL;
                location_2.LocationId = "2f104551-5140-4394-bce7-11a6a5b53db9";
                location_2.locations = new List<Locations>();
                location_2.LocationType = LocationTypeEnum.S;
                location_2.Longitude = 87.9330M;
                location_2.MilitaryIdRequired = BooleanEnum.NULL;
                location_2.Name = "SoundCU";
                location_2.OnMilitaryBase = BooleanEnum.NULL;
                location_2.OnPremise = BooleanEnum.NULL;
                location_2.Phone = "4153066399";
                location_2.PostalCode = "39503";
                location_2.RestrictedAccess = BooleanEnum.NULL;
                location_2.RetailOutlet = "Ala Moana";
                location_2.SelfServiceDevice = BooleanEnum.NULL;
                location_2.SelfServiceOnly = BooleanEnum.NULL;
                location_2.SoftDelete = BooleanEnum.Y;
                location_2.State = StateEnum.MS;
                location_2.Surcharge = BooleanEnum.NULL;
                location_2.TakeCoopData = BooleanEnum.Y;
                location_2.WebAddress = "http://corndog.io/";

                //---------LOCATION 3---------ALL CONTACT NULL//
                location_3.AcceptCash = BooleanEnum.N;
                location_3.AcceptDeposit = BooleanEnum.N;
                location_3.Access = BooleanEnum.N;
                location_3.AccessNotes = "No bills larger than 20";
                location_3.Address = "8966C Henry Smith Lane";
                location_3.Cashless = BooleanEnum.N;
                location_3.City = "Palos Verdes Peninsula";
                location_3.CoopLocationId = "WA9820-174920573";
                location_3.Country = "US";
                location_3.County = "King County";
                location_3.DriveThruOnly = BooleanEnum.N;
                location_3.EnvelopeRequired = BooleanEnum.N;
                location_3.Fax = null;
                location_3.HandicapAccess = BooleanEnum.N;
                location_3.Hours = "24 HOURS ACCESS";
                location_3.HoursDtfriClose = "9";
                location_3.HoursDtfriOpen = "9";
                location_3.HoursDtmonClose = "9";
                location_3.HoursDtmonOpen = "9";
                location_3.HoursDtsatClose = "9";
                location_3.HoursDtsatOpen = "9";
                location_3.HoursDtsunClose = "9";
                location_3.HoursDtsunOpen = "9";
                location_3.HoursDtthuClose = "9";
                location_3.HoursDtthuOpen = "9";
                location_3.HoursDttueClose = "9";
                location_3.HoursDttueOpen = "9";
                location_3.HoursDtwedClose = "9";
                location_3.HoursDtwedOpen = "9";
                location_3.HoursFriClose = "9";
                location_3.HoursFriOpen = "9";
                location_3.HoursMonClose = "9";
                location_3.HoursMonOpen = "9";
                location_3.HoursSatClose = "9";
                location_3.HoursSatOpen = "9";
                location_3.HoursSunClose = "9";
                location_3.HoursSunOpen = "9";
                location_3.HoursThuClose = "9";
                location_3.HoursThuOpen = "9";
                location_3.HoursTueClose = "9";
                location_3.HoursTueOpen = "9";
                location_3.HoursWedClose = "9";
                location_3.HoursWedOpen = "9";
                location_3.InstallationType = "Walk-Up";
                location_3.Latitude = -66.4245M;
                location_3.LimitedTransactions = BooleanEnum.N;
                location_3.LocationId = "6cc2244b-ff5b-4860-8464-2e5186b7060f";
                location_3.locations = new List<Locations>();
                location_3.LocationType = LocationTypeEnum.S;
                location_3.Longitude = -17.9152M;
                location_3.MilitaryIdRequired = BooleanEnum.N;
                location_3.Name = "VerityCU";
                location_3.OnMilitaryBase = BooleanEnum.N;
                location_3.OnPremise = BooleanEnum.N;
                location_3.Phone = null;
                location_3.PostalCode = "90274";
                location_3.RestrictedAccess = BooleanEnum.N;
                location_3.RetailOutlet = "Pearl Ridge";
                location_3.SelfServiceDevice = BooleanEnum.N;
                location_3.SelfServiceOnly = BooleanEnum.N;
                location_3.SoftDelete = BooleanEnum.Y;
                location_3.State = StateEnum.CA;
                location_3.Surcharge = BooleanEnum.N;
                location_3.TakeCoopData = BooleanEnum.Y;
                location_3.WebAddress = null;


                //---------LOCATION 4---------ALL OPTIONAL IN LOCATIONS NULL//
                location_4.AcceptCash = BooleanEnum.Y;
                location_4.AcceptDeposit = BooleanEnum.Y;
                location_4.Access = BooleanEnum.Y;
                location_4.AccessNotes = "Public entry on noth-side of 34th St.";
                location_4.Address = "7307 Poor House Ave.";
                location_4.Cashless = BooleanEnum.Y;
                location_4.City = "West Bloomfield";
                location_4.CoopLocationId = null;
                location_4.Country = null;
                location_4.County = null;
                location_4.DriveThruOnly = BooleanEnum.Y;
                location_4.EnvelopeRequired = BooleanEnum.Y;
                location_4.Fax = "9166280006";
                location_4.HandicapAccess = BooleanEnum.Y;
                location_4.Hours = null;
                location_4.HoursDtfriClose = "9";
                location_4.HoursDtfriOpen = "9";
                location_4.HoursDtmonClose = "9";
                location_4.HoursDtmonOpen = "9";
                location_4.HoursDtsatClose = "9";
                location_4.HoursDtsatOpen = "9";
                location_4.HoursDtsunClose = "9";
                location_4.HoursDtsunOpen = "9";
                location_4.HoursDtthuClose = "9";
                location_4.HoursDtthuOpen = "9";
                location_4.HoursDttueClose = "9";
                location_4.HoursDttueOpen = "9";
                location_4.HoursDtwedClose = "9";
                location_4.HoursDtwedOpen = "9";
                location_4.HoursFriClose = "9";
                location_4.HoursFriOpen = "9";
                location_4.HoursMonClose = "9";
                location_4.HoursMonOpen = "9";
                location_4.HoursSatClose = "9";
                location_4.HoursSatOpen = "9";
                location_4.HoursSunClose = "9";
                location_4.HoursSunOpen = "9";
                location_4.HoursThuClose = "9";
                location_4.HoursThuOpen = "9";
                location_4.HoursTueClose = "9";
                location_4.HoursTueOpen = "9";
                location_4.HoursWedClose = "9";
                location_4.HoursWedOpen = "9";
                location_4.InstallationType = "Walk-Up";
                location_4.Latitude = -53.0338M;
                location_4.LimitedTransactions = BooleanEnum.Y;
                location_4.LocationId = "a91be80e-ed05-4157-bb95-aa3494663d2a";
                location_4.locations = new List<Locations>();
                location_4.LocationType = LocationTypeEnum.A;
                location_4.Longitude = -40.3143M;
                location_4.MilitaryIdRequired = BooleanEnum.Y;
                location_4.Name = null;
                location_4.OnMilitaryBase = BooleanEnum.Y;
                location_4.OnPremise = BooleanEnum.Y;
                location_4.Phone = "9997957521";
                location_4.PostalCode = "48322";
                location_4.RestrictedAccess = BooleanEnum.Y;
                location_4.RetailOutlet = null;
                location_4.SelfServiceDevice = BooleanEnum.Y;
                location_4.SelfServiceOnly = BooleanEnum.Y;
                location_4.SoftDelete = null;
                location_4.State = StateEnum.MI;
                location_4.Surcharge = BooleanEnum.Y;
                location_4.TakeCoopData = null;
                location_4.WebAddress = "https://www.movenowthinklater.com/";

                //---------LOCATION 5---------AS MANY NULLS AS POSSIBLE//
                location_5.AcceptCash = BooleanEnum.NULL;
                location_5.AcceptDeposit = BooleanEnum.NULL;
                location_5.Access = BooleanEnum.NULL;
                location_5.AccessNotes = null;
                location_5.Address = "8071 Sunbeam Court";
                location_5.Cashless = BooleanEnum.NULL;
                location_5.City = "Massillon";
                location_5.CoopLocationId = null;
                location_5.Country = null;
                location_5.County = null;
                location_5.DriveThruOnly = BooleanEnum.NULL;
                location_5.EnvelopeRequired = BooleanEnum.NULL;
                location_5.Fax = "9166280006";
                location_5.HandicapAccess = BooleanEnum.NULL;
                location_5.Hours = null;
                location_5.HoursDtfriClose = null;
                location_5.HoursDtfriOpen = null;
                location_5.HoursDtmonClose = null;
                location_5.HoursDtmonOpen = null;
                location_5.HoursDtsatClose = null;
                location_5.HoursDtsatOpen = null;
                location_5.HoursDtsunClose = null;
                location_5.HoursDtsunOpen = null;
                location_5.HoursDtthuClose = null;
                location_5.HoursDtthuOpen = null;
                location_5.HoursDttueClose = null;
                location_5.HoursDttueOpen = null;
                location_5.HoursDtwedClose = null;
                location_5.HoursDtwedOpen = null;
                location_5.HoursFriClose = null;
                location_5.HoursFriOpen = null;
                location_5.HoursMonClose = null;
                location_5.HoursMonOpen = null;
                location_5.HoursSatClose = null;
                location_5.HoursSatOpen = null;
                location_5.HoursSunClose = null;
                location_5.HoursSunOpen = null;
                location_5.HoursThuClose = null;
                location_5.HoursThuOpen = null;
                location_5.HoursTueClose = null;
                location_5.HoursTueOpen = null;
                location_5.HoursWedClose = null;
                location_5.HoursWedOpen = null;
                location_5.InstallationType = null;
                location_5.Latitude = -20.9110M;
                location_5.LimitedTransactions = BooleanEnum.NULL;
                location_5.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
                location_5.locations = null;
                location_5.LocationType = LocationTypeEnum.A;
                location_5.Longitude = -84.8988M;
                location_5.MilitaryIdRequired = BooleanEnum.NULL;
                location_5.Name = null;
                location_5.OnMilitaryBase = BooleanEnum.NULL;
                location_5.OnPremise = BooleanEnum.NULL;
                location_5.Phone = "9997957521";
                location_5.PostalCode = "44646";
                location_5.RestrictedAccess = BooleanEnum.NULL;
                location_5.RetailOutlet = null;
                location_5.SelfServiceDevice = BooleanEnum.NULL;
                location_5.SelfServiceOnly = BooleanEnum.NULL;
                location_5.SoftDelete = null;
                location_5.State = StateEnum.OH;
                location_5.Surcharge = BooleanEnum.NULL;
                location_5.TakeCoopData = null;
                location_5.WebAddress = null;

                // Add locations to list
                viewModelList.Add(location_1);
                viewModelList.Add(location_2);
                viewModelList.Add(location_3);
                viewModelList.Add(location_4);
                viewModelList.Add(location_5);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the full list. Equivalent to a SELECT * FROM {join all tables}
        /// </summary>
        /// <returns> viewModelList </returns>
        public List<LocationsContactSpecialQualitiesViewModel> Get_All_ViewModel_List()
        {
            return viewModelList;
        }

        /// <summary>
        /// Returns only the location records that match the given where criteria.
        /// </summary>
        /// <param name="whereClauses"> The list of where clauses, given as key=column name, value=column value </param>
        /// <returns> List<LocationsContactSpecialQualitiesViewModel>. List may have length of 0 or more. </returns>
        public List<LocationsContactSpecialQualitiesViewModel> Get_Where_ViewModel_List(List<KeyValuePair<string, string>> whereClauses)
        {
            List<LocationsContactSpecialQualitiesViewModel> return_list = new List<LocationsContactSpecialQualitiesViewModel>();

            if (whereClauses == null)
            {
                return_list = viewModelList;
                return return_list;
            }
            else
            {
                foreach (LocationsContactSpecialQualitiesViewModel location in viewModelList)
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
        /// <param name="pair"> KeyValuePair<string, string> where key=column name, value=column value of the where clause. </param>
        /// <param name="location"> The LocationsContactSpecialQualitiesViewModel object being compared to. </param>
        /// <returns> true if match, else false. </returns>
        private bool IsMatch(KeyValuePair<string, string> pair, LocationsContactSpecialQualitiesViewModel location)
        {
            switch (pair.Key)
            {
                case "AcceptCash":
                    return location.AcceptCash.ToString().Trim() == pair.Value.Trim();
                case "AcceptDeposit":
                    return location.AcceptDeposit.ToString().Trim() == pair.Value.Trim();
                case "Access":
                    return location.Access.ToString().Trim() == pair.Value.Trim();
                case "AccessNotes":
                    return location.AccessNotes.Trim() == pair.Value.Trim();
                case "Address":
                    return location.Address.Trim() == pair.Value.Trim();
                case "Cashless":
                    return location.Cashless.ToString().Trim() == pair.Value.Trim();
                case "City":
                    return location.City.Trim() == pair.Value.Trim();
                case "CoopLocationId":
                    return location.CoopLocationId.Trim() == pair.Value.Trim();
                case "Country":
                    return location.Country.Trim() == pair.Value.Trim();
                case "County":
                    return location.County.Trim() == pair.Value.Trim();
                case "DriveThruOnly":
                    return location.DriveThruOnly.ToString().Trim() == pair.Value.Trim();
                case "EnvelopeRequired":
                    return location.EnvelopeRequired.ToString().Trim() == pair.Value.Trim();
                case "Fax":
                    return location.Fax.Trim() == pair.Value.Trim();
                case "HandicapAccess":
                    return location.HandicapAccess.ToString().Trim() == pair.Value.Trim();
                case "Hours":
                    return location.Hours.Trim() == pair.Value.Trim();
                case "HoursDtfriClose":
                    return location.HoursDtfriClose.Trim() == pair.Value.Trim();
                case "HoursDtfriOpen":
                    return location.HoursDtfriOpen.Trim() == pair.Value.Trim();
                case "HoursDtmonClose":
                    return location.HoursDtmonClose.Trim() == pair.Value.Trim();
                case "HoursDtmonOpen":
                    return location.HoursDtmonOpen.Trim() == pair.Value.Trim();
                case "HoursDtsatClose":
                    return location.HoursDtsatClose.Trim() == pair.Value.Trim();
                case "HoursDtsatOpen":
                    return location.HoursDtsatOpen.Trim() == pair.Value.Trim();
                case "HoursDtsunClose":
                    return location.HoursDtsunClose.Trim() == pair.Value.Trim();
                case "HoursDtsunOpen":
                    return location.HoursDtsunOpen.Trim() == pair.Value.Trim();
                case "HoursDtthuClose":
                    return location.HoursDtthuClose.Trim() == pair.Value.Trim();
                case "HoursDtthuOpen":
                    return location.HoursDtthuOpen.Trim() == pair.Value.Trim();
                case "HoursDttueClose":
                    return location.HoursDttueClose.Trim() == pair.Value.Trim();
                case "HoursDttueOpen":
                    return location.HoursDttueOpen.Trim() == pair.Value.Trim();
                case "HoursDtwedClose":
                    return location.HoursDtwedClose.Trim() == pair.Value.Trim();
                case "HoursDtwedOpen":
                    return location.HoursDtwedOpen.Trim() == pair.Value.Trim();
                case "HoursFriClose":
                    return location.HoursFriClose.Trim() == pair.Value.Trim();
                case "HoursFriOpen":
                    return location.HoursFriOpen.Trim() == pair.Value.Trim();
                case "HoursMonClose":
                    return location.HoursMonClose.Trim() == pair.Value.Trim();
                case "HoursMonOpen":
                    return location.HoursMonOpen.Trim() == pair.Value.Trim();
                case "HoursSatClose":
                    return location.HoursSatClose.Trim() == pair.Value.Trim();
                case "HoursSatOpen":
                    return location.HoursSatOpen.Trim() == pair.Value.Trim();
                case "HoursSunClose":
                    return location.HoursSunClose.Trim() == pair.Value.Trim();
                case "HoursSunOpen":
                    return location.HoursSunOpen.Trim() == pair.Value.Trim();
                case "HoursThuClose":
                    return location.HoursThuClose.Trim() == pair.Value.Trim();
                case "HoursThuOpen":
                    return location.HoursThuOpen.Trim() == pair.Value.Trim();
                case "HoursTueClose":
                    return location.HoursTueClose.Trim() == pair.Value.Trim();
                case "HoursTueOpen":
                    return location.HoursDtfriClose.Trim() == pair.Value.Trim();
                case "HoursWedClose":
                    return location.HoursWedClose.Trim() == pair.Value.Trim();
                case "HoursWedOpen":
                    return location.HoursWedOpen.Trim() == pair.Value.Trim();
                case "InstallationType":
                    return location.InstallationType.Trim() == pair.Value.Trim();
                case "Latitude":
                    return location.Latitude == decimal.Parse(pair.Value.Trim());
                case "LimitedTransactions":
                    return location.LimitedTransactions.ToString().Trim() == pair.Value.Trim();
                case "LocationId":
                    return location.LocationId.Trim() == pair.Value.Trim();
                case "LocationType":
                    return location.LocationType.ToString().Trim() == pair.Value.Trim();
                case "Longitude":
                    return location.Longitude == decimal.Parse(pair.Value.Trim());
                case "MilitaryIdRequired":
                    return location.MilitaryIdRequired.ToString().Trim() == pair.Value.Trim();
                case "Name":
                    return location.Name.Trim() == pair.Value.Trim();
                case "OnMilitaryBase":
                    return location.OnMilitaryBase.ToString().Trim() == pair.Value.Trim();
                case "OnPremise":
                    return location.OnPremise.ToString().Trim() == pair.Value.Trim();
                case "Phone":
                    return location.Phone.Trim() == pair.Value.Trim();
                case "PostalCode":
                    return location.PostalCode.Trim() == pair.Value.Trim();
                case "RestrictedAccess":
                    return location.RestrictedAccess.ToString().Trim() == pair.Value.Trim();
                case "RetailOutlet":
                    return location.RetailOutlet.Trim() == pair.Value.Trim();
                case "SelfServiceDevice":
                    return location.SelfServiceDevice.ToString().Trim() == pair.Value.Trim();
                case "SelfServiceOnly":
                    return location.SelfServiceOnly.ToString().Trim() == pair.Value.Trim();
                case "SoftDelete":
                    return location.SoftDelete.ToString().Trim() == pair.Value.Trim();
                case "State":
                    return location.State.ToString().Trim() == pair.Value.Trim();
                case "Surcharge":
                    return location.Surcharge.ToString().Trim() == pair.Value.Trim();
                case "TakeCoopData":
                    return location.TakeCoopData.ToString().Trim() == pair.Value.Trim();
                case "WebAddress":
                    return location.WebAddress.Trim() == pair.Value.Trim();
            }
            return false;
        }

        /// <summary>
        /// Same as Get_Where_ViewModel_List except will only return at most one location.
        /// </summary>
        /// <param name="whereClauses"> The list of where clauses, given as key=column name, value=column value </param>
        /// <returns> The first location that meets the where clause conditions, otherwise null </returns>
        public LocationsContactSpecialQualitiesViewModel? GetOneLocation(List<KeyValuePair<string, string>> whereClauses)
        {
            if (whereClauses is null)
            {
                return viewModelList.First();
            }
            else
            {
                foreach (LocationsContactSpecialQualitiesViewModel location in viewModelList)
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
    }
}
