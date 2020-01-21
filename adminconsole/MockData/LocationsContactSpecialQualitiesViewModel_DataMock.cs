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
                location_1.City = "Starkville";
                location_1.contacts = new List<Contact>();
                location_1.Hours = "24 HOURS ACCESS";
                location_1.InstitutionName = "BECU";
                location_1.Lat = 13.3108M;
                location_1.LocationId = "11170401-4112-43c1-aa4e-f73370e1014a";
                location_1.Long = -132.8851M;
                location_1.RetailOutlet = "Northgate";
                location_1.State = StateEnum.MS;
                location_1.Street = "362 Oxford Dr.";
                location_1.TypeName = "A";
                location_1.Zipcode = "39759";
                location_1.Phone = "4896771019";
                location_1.Fax = "8058451931";
                location_1.Terminal = "https://trypap.com/";
                location_1.locations = new List<Locations>();
                location_1.AcceptsCash = BooleanEnum.Y;
                location_1.AdditionalDetail = "Lobby";
                location_1.Cashless = BooleanEnum.Y;
                location_1.DepositTaking = BooleanEnum.Y;
                location_1.HandicapAccess = BooleanEnum.Y;
                location_1.LimitedTransactions = BooleanEnum.Y;
                location_1.MilitaryIdRequired = BooleanEnum.Y;
                location_1.OnMilitaryBase = BooleanEnum.Y;
                location_1.RestrictedAccess = BooleanEnum.Y;
                location_1.SelfServiceOnly = BooleanEnum.Y;
                location_1.Surcharge = BooleanEnum.Y;

                //---------LOCATION 2--------- ALL SPECIAL QUALITIES NULL//
                location_1.City = "Gulfport";
                location_1.contacts = new List<Contact>();
                location_1.Hours = "BUSINESS HOURS ACCESS";
                location_1.InstitutionName = "SoundCU";
                location_1.Lat = 64.4829M;
                location_1.LocationId = "2f104551-5140-4394-bce7-11a6a5b53db9";
                location_1.Long = 87.9330M;
                location_1.RetailOutlet = "Ala Moana";
                location_1.specialQualities = new List<SpecialQualities>();
                location_1.State = StateEnum.MS;
                location_1.Street = "7520 S. Edgewood Road";
                location_1.TypeName = "S";
                location_1.Zipcode = "39503";
                location_1.Phone = "4153066399";
                location_1.Fax = "2429781246";
                location_1.Terminal = "http://corndog.io/";
                location_1.locations = new List<Locations>();
                location_1.AcceptsCash = null;
                location_1.AdditionalDetail = null;
                location_1.Cashless = null;
                location_1.DepositTaking = null;
                location_1.HandicapAccess = null;
                location_1.LimitedTransactions = null;
                location_1.MilitaryIdRequired = null;
                location_1.OnMilitaryBase = null;
                location_1.RestrictedAccess = null;
                location_1.SelfServiceOnly = null;
                location_1.Surcharge = null;

                //---------LOCATION 3---------ALL CONTACT NULL//

                location_1.City = "Palos Verdes Peninsula";
                location_1.contacts = new List<Contact>();
                location_1.Hours = "24 HOURS ACCESS";
                location_1.InstitutionName = "VerityCU";
                location_1.Lat = -66.4245M;
                location_1.LocationId = "6cc2244b-ff5b-4860-8464-2e5186b7060f";
                location_1.Long = -17.9152M;
                location_1.RetailOutlet = "Pearl Ridge";
                location_1.specialQualities = new List<SpecialQualities>();
                location_1.State = StateEnum.CA;
                location_1.Street = "8966C Henry Smith Lane";
                location_1.TypeName = "S";
                location_1.Zipcode = "90274";
                location_1.Phone = null;
                location_1.Fax = null;
                location_1.Terminal = null;
                location_1.locations = new List<Locations>();
                location_1.AcceptsCash = BooleanEnum.N;
                location_1.AdditionalDetail = "No bills larger than 20";
                location_1.Cashless = BooleanEnum.N;
                location_1.DepositTaking = BooleanEnum.N;
                location_1.HandicapAccess = BooleanEnum.N;
                location_1.LimitedTransactions = BooleanEnum.N;
                location_1.MilitaryIdRequired = BooleanEnum.N;
                location_1.OnMilitaryBase = BooleanEnum.N;
                location_1.RestrictedAccess = BooleanEnum.N;
                location_1.SelfServiceOnly = BooleanEnum.N;
                location_1.Surcharge = BooleanEnum.N;

                //---------LOCATION 4---------ALL OPTIONAL IN LOCATIONS NULL//
                location_1.City = "West Bloomfield";
                location_1.contacts = new List<Contact>();
                location_1.Hours = null;
                location_1.InstitutionName = null;
                location_1.Lat = -53.0338M;
                location_1.LocationId = "a91be80e-ed05-4157-bb95-aa3494663d2a";
                location_1.Long = -40.3143M;
                location_1.RetailOutlet = null;
                location_1.specialQualities = new List<SpecialQualities>();
                location_1.State = StateEnum.MI;
                location_1.Street = "7307 Poor House Ave.";
                location_1.TypeName = "A";
                location_1.Zipcode = "48322";
                location_1.Phone = "9997957521";
                location_1.Fax = "9166280006";
                location_1.Terminal = "https://www.movenowthinklater.com/";
                location_1.locations = new List<Locations>();
                location_1.AcceptsCash = BooleanEnum.Y;
                location_1.AdditionalDetail = "Public entry on noth-side of 34th St.";
                location_1.Cashless = BooleanEnum.Y;
                location_1.DepositTaking = BooleanEnum.Y;
                location_1.HandicapAccess = BooleanEnum.Y;
                location_1.LimitedTransactions = BooleanEnum.Y;
                location_1.MilitaryIdRequired = BooleanEnum.Y;
                location_1.OnMilitaryBase = BooleanEnum.Y;
                location_1.RestrictedAccess = BooleanEnum.Y;
                location_1.SelfServiceOnly = BooleanEnum.Y;
                location_1.Surcharge = BooleanEnum.Y;

                //---------LOCATION 5---------AS MANY NULLS AS POSSIBLE//
                location_1.City = "Massillon";
                location_1.contacts = null;
                location_1.Hours = null;
                location_1.InstitutionName = null;
                location_1.Lat = -20.9110M;
                location_1.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
                location_1.Long = -84.8988M;
                location_1.RetailOutlet = null;
                location_1.specialQualities = null;
                location_1.State = StateEnum.OH;
                location_1.Street = "8071 Sunbeam Court";
                location_1.TypeName = "A";
                location_1.Zipcode = "44646";
                location_1.Phone = null;
                location_1.Fax = null;
                location_1.Terminal = null;
                location_1.locations = null;
                location_1.AcceptsCash = null;
                location_1.AdditionalDetail = null;
                location_1.Cashless = null;
                location_1.DepositTaking = null;
                location_1.HandicapAccess = null;
                location_1.LimitedTransactions = null;
                location_1.MilitaryIdRequired = null;
                location_1.OnMilitaryBase = null;
                location_1.RestrictedAccess = null;
                location_1.SelfServiceOnly = null;
                location_1.Surcharge = null;

                // Add locations to list
                viewModelList.Add(location_1);
                viewModelList.Add(location_2);
                viewModelList.Add(location_3);
                viewModelList.Add(location_4);
                viewModelList.Add(location_5);

                return true;
            } catch (Exception)
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
                case "City":
                    return location.City.Trim() == pair.Value.Trim();
                case "Hours":
                    return location.Hours.Trim() == pair.Value.Trim();
                case "InstitutionName":
                    return location.InstitutionName.Trim() == pair.Value.Trim();
                case "Lat":
                    return location.Lat == decimal.Parse(pair.Value.Trim());
                case "LocationId":
                    return location.LocationId.Trim() == pair.Value.Trim();
                case "Long":
                    return location.Long == decimal.Parse(pair.Value.Trim());
                case "RetailOutlet":
                    return location.RetailOutlet.Trim() == pair.Value.Trim();
                case "State":
                    return location.State.ToString().Trim() == pair.Value.Trim();
                case "Street":
                    return location.Street.Trim() == pair.Value.Trim();
                case "TypeName":
                    return location.TypeName.Trim() == pair.Value.Trim();
                case "Zipcode":
                    return location.Zipcode.Trim() == pair.Value.Trim();
                case "Phone":
                    return location.Phone.Trim() == pair.Value.Trim();
                case "Fax":
                    return location.Fax.Trim() == pair.Value.Trim();
                case "Terminal":
                    return location.Terminal.Trim() == pair.Value.Trim();
                case "AcceptsCash":
                    return location.AcceptsCash.ToString().Trim() == pair.Value.Trim();
                case "AdditionalDetail":
                    return location.AdditionalDetail.Trim() == pair.Value.Trim();
                case "Cashless":
                    return location.Cashless.ToString().Trim() == pair.Value.Trim();
                case "DepositTaking":
                    return location.DepositTaking.ToString().Trim() == pair.Value.Trim();
                case "HandicapAccess":
                    return location.HandicapAccess.ToString().Trim() == pair.Value.Trim();
                case "LimitedTransactions":
                    return location.LimitedTransactions.ToString().Trim() == pair.Value.Trim();
                case "MilitaryIdRequired":
                    return location.MilitaryIdRequired.ToString().Trim() == pair.Value.Trim();
                case "OnMilitaryBase":
                    return location.OnMilitaryBase.ToString().Trim() == pair.Value.Trim();
                case "RestrictedAccess":
                    return location.RestrictedAccess.ToString().Trim() == pair.Value.Trim();
                case "SelfServiceOnly":
                    return location.SelfServiceOnly.ToString().Trim() == pair.Value.Trim();
                case "Surcharge":
                    return location.Surcharge.ToString().Trim() == pair.Value.Trim();
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
