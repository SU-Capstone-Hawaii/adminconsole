using System;
using System.Collections.Generic;
using System.Linq;


namespace adminconsole.Models
{
    public partial class LocationsContactSpecialQualitiesViewModel
    {
        /// <summary>
        /// Default constructor. 
        /// 
        /// Allows app to access Database
        /// </summary>
        public LocationsContactSpecialQualitiesViewModel()
        {
            locations = new List<Locations>();
            dataSource = DataSourceEnum.LIVE;
        }






        /// <summary>
        /// Parameterized constructor
        /// 
        /// Allows app to use mock data class when unit testing
        /// </summary>
        /// <param name="dataSource"></param>
        public LocationsContactSpecialQualitiesViewModel(DataSourceEnum dataSource=DataSourceEnum.LIVE)
        {
            locations = new List<Locations>();
            this.dataSource = dataSource;
        }








        /// <summary>
        /// Populates a Locations Object from a View Model Object's properties.
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> A View Model Object from which to extract from </param>
        /// 
        /// 
        /// <returns> A Locations Object  </returns>
        public static Locations GetNewLocation(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation is null)
            {
                return null;
            }

            Locations location = new Locations();
            location.Address = newLocation.Address;
            location.City = newLocation.City;
            location.CoopLocationId = newLocation.CoopLocationId ?? null;
            location.Country = newLocation.Country ?? null;
            location.County = newLocation.County ?? null;
            location.Hours = newLocation.Hours ?? null;
            location.Latitude = newLocation.Latitude;
            location.LocationId = newLocation.LocationId;
            location.LocationType = ConvertLocationTypeEnumToString(newLocation.LocationType);
            location.Longitude = newLocation.Longitude;
            location.Name = newLocation.Name ?? null;
            location.PostalCode = newLocation.PostalCode;
            location.RetailOutlet = newLocation.RetailOutlet ?? null;
            location.SoftDelete = ConvertBooleanEnumToBool(newLocation.SoftDelete);
            location.State = newLocation.State.ToString();
            location.TakeCoopData = ConvertBooleanEnumToBool(newLocation.TakeCoopData);
            return location;
        }








        /// <summary>
        /// Populates a Contacts Object from a View Model Object's properties.
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> A View Model Object from which to extract from </param>
        /// 
        /// 
        /// <returns> A Contacts Object  </returns>
        public static Contacts GetNewContact(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation is null)
            {
                return null;
            }

            Contacts contact = new Contacts();
            contact.LocationId = newLocation.LocationId;
            contact.Phone = newLocation.Phone ?? null;
            contact.Fax = newLocation.Fax ?? null;
            contact.WebAddress = newLocation.WebAddress ?? null;

            return contact;
        }









        /// <summary>
        /// Populates a Special Qualities Object from a View Model Object's properties.
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> A View Model Object from which to extract from </param>
        /// 
        /// 
        /// <returns> A Special Qualities Object  </returns>
        public static SpecialQualities GetNewSpecialQualities(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            if (newLocation is null)
            {
                return null;
            }

            SpecialQualities specialQuality = new SpecialQualities();
            specialQuality.AcceptCash = ConvertBooleanEnumToString(newLocation.AcceptCash);
            specialQuality.AcceptDeposit = ConvertBooleanEnumToString(newLocation.AcceptDeposit);
            specialQuality.Access = ConvertBooleanEnumToString(newLocation.Access);
            specialQuality.AccessNotes = newLocation.AccessNotes ?? null;
            specialQuality.Cashless = ConvertBooleanEnumToString(newLocation.Cashless);
            specialQuality.DriveThruOnly = ConvertBooleanEnumToString(newLocation.DriveThruOnly);
            specialQuality.EnvelopeRequired = ConvertBooleanEnumToString(newLocation.EnvelopeRequired);
            specialQuality.HandicapAccess = ConvertBooleanEnumToString(newLocation.HandicapAccess);
            specialQuality.InstallationType = newLocation.InstallationType;
            specialQuality.LimitedTransactions = ConvertBooleanEnumToString(newLocation.LimitedTransactions);
            specialQuality.LocationId = newLocation.LocationId;
            specialQuality.MilitaryIdRequired = ConvertBooleanEnumToString(newLocation.MilitaryIdRequired);
            specialQuality.OnMilitaryBase = ConvertBooleanEnumToString(newLocation.OnMilitaryBase);
            specialQuality.OnPremise = ConvertBooleanEnumToString(newLocation.OnPremise);
            specialQuality.RestrictedAccess = ConvertBooleanEnumToString(newLocation.RestrictedAccess);
            specialQuality.SelfServiceDevice = ConvertBooleanEnumToString(newLocation.SelfServiceDevice);
            specialQuality.SelfServiceOnly = ConvertBooleanEnumToString(newLocation.SelfServiceOnly);
            specialQuality.Surcharge = ConvertBooleanEnumToString(newLocation.Surcharge);

            return specialQuality;
        }







        /// <summary>
        /// Populates a HoursPerDayOfTheWeek Object from a View Model Object's properties.
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> A View Model Object from which to extract from </param>
        /// 
        /// 
        /// <returns> A HoursPerDayOfTheWeek Object  </returns>
        public static HoursPerDayOfTheWeek GetNewHoursPerDayOfTheWeek(LocationsContactSpecialQualitiesViewModel newLocation)
        {
            // If all nulls return null
            if ((newLocation.HoursDtfriClose) == null &&
            (newLocation.HoursDtfriOpen) == null &&
            (newLocation.HoursDtmonClose) == null &&
            (newLocation.HoursDtmonOpen) == null &&
            (newLocation.HoursDtsatClose) == null &&
            (newLocation.HoursDtsatOpen) == null &&
            (newLocation.HoursDtsunClose) == null &&
            (newLocation.HoursDtsunOpen) == null &&
            (newLocation.HoursDtthuClose) == null &&
            (newLocation.HoursDtthuOpen) == null &&
            (newLocation.HoursDttueClose) == null &&
            (newLocation.HoursDttueOpen) == null &&
            (newLocation.HoursDtwedClose) == null &&
            (newLocation.HoursDtwedOpen) == null &&
            (newLocation.HoursFriClose) == null &&
            (newLocation.HoursFriOpen) == null &&
            (newLocation.HoursMonClose) == null &&
            (newLocation.HoursMonOpen) == null &&
            (newLocation.HoursSatClose) == null &&
            (newLocation.HoursSatOpen) == null &&
            (newLocation.HoursSunClose) == null &&
            (newLocation.HoursSunOpen) == null &&
            (newLocation.HoursThuClose) == null &&
            (newLocation.HoursThuOpen) == null &&
            (newLocation.HoursTueClose) == null &&
            (newLocation.HoursTueOpen) == null &&
            (newLocation.HoursWedClose) == null &&
            (newLocation.HoursWedOpen) == null)
            {
                return null;
            } else
            {
                HoursPerDayOfTheWeek hoursPerDayOfTheWeek = new HoursPerDayOfTheWeek();
                hoursPerDayOfTheWeek.LocationId = newLocation.LocationId;
                hoursPerDayOfTheWeek.HoursDtfriClose = newLocation.HoursDtfriClose;
                hoursPerDayOfTheWeek.HoursDtfriOpen = newLocation.HoursDtfriOpen;
                hoursPerDayOfTheWeek.HoursDtmonClose = newLocation.HoursDtmonClose;
                hoursPerDayOfTheWeek.HoursDtmonOpen = newLocation.HoursDtmonOpen;
                hoursPerDayOfTheWeek.HoursDtsatClose = newLocation.HoursDtsatClose;
                hoursPerDayOfTheWeek.HoursDtsatOpen = newLocation.HoursDtsatOpen;
                hoursPerDayOfTheWeek.HoursDtsunClose = newLocation.HoursDtsunClose;
                hoursPerDayOfTheWeek.HoursDtsunOpen = newLocation.HoursDtsunOpen;
                hoursPerDayOfTheWeek.HoursDtthuClose = newLocation.HoursDtthuClose;
                hoursPerDayOfTheWeek.HoursDtthuOpen = newLocation.HoursDtthuOpen;
                hoursPerDayOfTheWeek.HoursDttueClose = newLocation.HoursDttueClose;
                hoursPerDayOfTheWeek.HoursDttueOpen =newLocation.HoursDttueOpen;
                hoursPerDayOfTheWeek.HoursDtwedClose = newLocation.HoursDtwedClose;
                hoursPerDayOfTheWeek.HoursDtwedOpen = newLocation.HoursDtwedOpen;
                hoursPerDayOfTheWeek.HoursFriClose = newLocation.HoursFriClose;
                hoursPerDayOfTheWeek.HoursFriOpen = newLocation.HoursFriOpen;
                hoursPerDayOfTheWeek.HoursMonClose = newLocation.HoursMonClose;
                hoursPerDayOfTheWeek.HoursMonOpen = newLocation.HoursMonOpen;
                hoursPerDayOfTheWeek.HoursSatClose = newLocation.HoursSatClose;
                hoursPerDayOfTheWeek.HoursSatOpen = newLocation.HoursSatOpen;
                hoursPerDayOfTheWeek.HoursSunClose = newLocation.HoursSunClose;
                hoursPerDayOfTheWeek.HoursSunOpen = newLocation.HoursSunOpen;
                hoursPerDayOfTheWeek.HoursThuClose = newLocation.HoursThuClose;
                hoursPerDayOfTheWeek.HoursThuOpen = newLocation.HoursThuOpen;
                hoursPerDayOfTheWeek.HoursTueClose = newLocation.HoursTueClose;
                hoursPerDayOfTheWeek.HoursTueOpen = newLocation.HoursTueOpen;
                hoursPerDayOfTheWeek.HoursWedClose = newLocation.HoursWedClose;
                hoursPerDayOfTheWeek.HoursWedOpen = newLocation.HoursWedOpen;
                return hoursPerDayOfTheWeek;
            }
        }








        /// <summary>
        /// Converts a BooleanEnum to a String 
        /// </summary>
        /// 
        /// 
        /// <param name="booleanEnum"> The BooleanEnum type to convert </param>
        /// 
        /// <param name="returnEmptyStringInsteadOfNull"> Indicates what kind of empty value is desired </param>
        /// 
        /// 
        /// <returns>
        /// 
        ///     BooleanEnum.N    ==> "N"
        ///     BooleanEnum.Y    ==> "Y"
        ///     BooleanEnum.NULL ==> ""
        ///             or
        ///     BooleanEnum.NULL ==> null
        ///     
        /// </returns>
        private static string ConvertBooleanEnumToString(BooleanEnum? booleanEnum, bool returnEmptyStringInsteadOfNull=false)
        {
            switch (booleanEnum)
            {
                case BooleanEnum.N:
                    return "N";
                case BooleanEnum.Y:
                    return "Y";
                default:
                    if (returnEmptyStringInsteadOfNull)
                    {
                        return "";
                    }
                    return null;
            }
        }







        /// <summary>
        /// Converts a BooleanEnum to a bool 
        /// </summary>
        /// 
        /// 
        /// <param name="booleanEnum"> The BooleanEnum type to convert </param>
        /// 
        /// 
        /// <returns>
        /// 
        ///     BooleanEnum.N    ==> false
        ///     BooleanEnum.Y    ==> true
        ///     BooleanEnum.NULL ==> null
        ///     
        /// </returns>
        private static bool? ConvertBooleanEnumToBool(BooleanEnum? booleanEnum)
        {
            switch (booleanEnum)
            {
                case BooleanEnum.N:
                    return false;
                case BooleanEnum.Y:
                    return true;
                default:
                    return null;
            }
        }






        /// <summary>
        /// Converts string to BooleanEnum.
        /// </summary>
        /// 
        /// 
        /// <param name="booleanAsStringFromDb"> Y, N or null </param>
        /// 
        /// 
        /// <returns>
        /// 
        ///     "Y"  ==> BooleanEnum.Y
        ///     "N"  ==> BooleanEnum.N
        ///     null ==> BooleanEnum.NULL
        /// 
        /// </returns>
        private static BooleanEnum ConvertStringToBooleanEnum(string booleanAsStringFromDb)
        {
            switch (booleanAsStringFromDb)
            {
                case "N":
                    return BooleanEnum.N;
                case "Y":
                    return BooleanEnum.Y;
                default:
                    return BooleanEnum.NULL;
            }
        }







        /// <summary>
        /// Converts bool to BooleanEnum
        /// </summary>
        /// 
        /// 
        /// <param name="booleanValueFromDb"> bool value to convert </param>
        /// 
        /// 
        /// <returns>
        /// 
        ///     null  ==> BooleanEnum.NULL
        ///     true  ==> BooleanEnum.Y
        ///     false ==> BooleanEnum.N
        /// 
        /// </returns>
        private static BooleanEnum ConvertBoolToBooleanEnum(bool? booleanValueFromDb)
        {
            switch (booleanValueFromDb)
            {
                case (true):
                    return BooleanEnum.Y;
                case (false):
                    return BooleanEnum.N;
                default:
                    return BooleanEnum.NULL;
            }
        }







        /// <summary>
        /// Converts State code as a string to a StateEnum.
        /// </summary>
        /// 
        /// 
        /// <param name="stateValueFromDb"> State code to convert </param>
        /// 
        /// 
        /// <returns> ex. "WA" ==> StateEnum.WA </returns>
        public static StateEnum ConvertStringToStateEnum(string stateValueFromDb)
        {

            if (stateValueFromDb == "AL")
            {
                return StateEnum.AL;
            }
            else if (stateValueFromDb == "AK")
            {
                return StateEnum.AK;
            }
            else if (stateValueFromDb == "AZ")
            {
                return StateEnum.AZ;
            }
            else if (stateValueFromDb == "AR")
            {
                return StateEnum.AR;
            }
            else if (stateValueFromDb == "CA")
            {
                return StateEnum.CA;
            }
            else if (stateValueFromDb == "CO")
            {
                return StateEnum.CO;
            }
            else if (stateValueFromDb == "CT")
            {
                return StateEnum.CT;
            }
            else if (stateValueFromDb == "DE")
            {
                return StateEnum.DE;
            }
            else if (stateValueFromDb == "DC")
            {
                return StateEnum.DC;
            }
            else if (stateValueFromDb == "FL")
            {
                return StateEnum.FL;
            }
            else if (stateValueFromDb == "GA")
            {
                return StateEnum.GA;
            }
            else if (stateValueFromDb == "GU")
            {
                return StateEnum.GU;
            }
            else if (stateValueFromDb == "HI")
            {
                return StateEnum.HI;
            }
            else if (stateValueFromDb == "ID")
            {
                return StateEnum.ID;
            }
            else if (stateValueFromDb == "IL")
            {
                return StateEnum.IL;
            }
            else if (stateValueFromDb == "IN")
            {
                return StateEnum.IN;
            }
            else if (stateValueFromDb == "IA")
            {
                return StateEnum.IA;
            }
            else if (stateValueFromDb == "KS")
            {
                return StateEnum.KS;
            }
            else if (stateValueFromDb == "KY")
            {
                return StateEnum.KY;
            }
            else if (stateValueFromDb == "LA")
            { 
                return StateEnum.LA;
            }
            else if (stateValueFromDb == "ME")
            { 
                return StateEnum.ME;
            }
            else if (stateValueFromDb == "MD")
            { 
                return StateEnum.MD;
            }
            else if (stateValueFromDb == "MA")
            { 
                return StateEnum.MA;
            }
            else if (stateValueFromDb == "MI")
            { 
                return StateEnum.MI;
            }
            else if (stateValueFromDb == "MN")
            { 
                return StateEnum.MN;
            }
            else if (stateValueFromDb == "MS")
            { 
                return StateEnum.MS;
            }
            else if (stateValueFromDb == "MO")
            { 
                return StateEnum.MO;
            }
            else if (stateValueFromDb == "MT")
            { 
                return StateEnum.MT;
            }
            else if (stateValueFromDb == "NE")
            { 
                return StateEnum.NE;
            }
            else if (stateValueFromDb == "NV")
            { 
                return StateEnum.NV;
            }
            else if (stateValueFromDb == "NH")
            { 
                return StateEnum.NH;
            }
            else if (stateValueFromDb == "NJ")
            { 
                return StateEnum.NJ;
            }
            else if (stateValueFromDb == "NM")
            { 
                return StateEnum.NM;
            }
            else if (stateValueFromDb == "NY")
            { 
                return StateEnum.NY;
            }
            else if (stateValueFromDb == "NC")
            { 
                return StateEnum.NC;
            }
            else if (stateValueFromDb == "ND")
            { 
                return StateEnum.ND;
            }
            else if (stateValueFromDb == "OH")
            { 
                return StateEnum.OH;
            }
            else if (stateValueFromDb == "OK")
            { 
                return StateEnum.OK;
            }
            else if (stateValueFromDb == "OR")
            { 
                return StateEnum.OR;
            }
            else if (stateValueFromDb == "PA")
            { 
                return StateEnum.PA;
            }
            else if (stateValueFromDb == "RI")
            { 
                return StateEnum.RI;
            }
            else if (stateValueFromDb == "SC")
            { 
                return StateEnum.SC;
            }
            else if (stateValueFromDb == "SD")
            { 
                return StateEnum.SD;
            }
            else if (stateValueFromDb == "TN")
            { 
                return StateEnum.TN;
            }
            else if (stateValueFromDb == "TX")
            { 
                return StateEnum.TX;
            }
            else if (stateValueFromDb == "UT")
            { 
                return StateEnum.UT;
            }
            else if (stateValueFromDb == "VT")
            { 
                return StateEnum.VT;
            }
            else if (stateValueFromDb == "VA")
            { 
                return StateEnum.VA;
            }
            else if (stateValueFromDb == "WA")
            { 
                return StateEnum.WA;
            }
            else if (stateValueFromDb == "WV")
            { 
                return StateEnum.WV;
            }
            else if (stateValueFromDb == "WI")
            { 
                return StateEnum.WI;
            }
            else if (stateValueFromDb == "WY")
            { 
                return StateEnum.WY;
            }
            else if (stateValueFromDb == "AB")
            { 
                return StateEnum.AB;
            }
            else if (stateValueFromDb == "BC")
            { 
                return StateEnum.BC;
            }
            else if (stateValueFromDb == "MB")
            { 
                return StateEnum.MB;
            }
            else if (stateValueFromDb == "NB")
            { 
                return StateEnum.NB;
            }
            else if (stateValueFromDb == "NL")
            { 
                return StateEnum.NL;
            }
            else if (stateValueFromDb == "NS")
            { 
                return StateEnum.NS;
            }
            else if (stateValueFromDb == "ON")
            { 
                return StateEnum.ON;
            }
            else if (stateValueFromDb == "QC")
            { 
                return StateEnum.QC;
            }
            else if (stateValueFromDb == "SK")
            { 
                return StateEnum.SK;
            }
            else if (stateValueFromDb == "AE")
            { 
                return StateEnum.AE;
            }
            else
            { 
                return StateEnum.PR;
            }
        }






        /// <summary>
        /// Converts "A" and "S" to LocationTypeEnum
        /// </summary>
        /// 
        /// 
        /// <param name="locationTypeValueFromDb"> String to convert </param>
        /// <returns>
        ///     
        ///     "A" ==> LocationTypeEnum.A
        ///     "S" ==> LocationTypeEnum.S
        ///     
        /// </returns>
        public static LocationTypeEnum ConvertStringToLocationTypeEnum(string locationTypeValueFromDb)
        {
            if (locationTypeValueFromDb == "A")
            {
                return LocationTypeEnum.A;
            } else
            {
                return LocationTypeEnum.S;
            }
        }






        /// <summary>
        /// Converts a LocationTypeEnum to a string
        /// </summary>
        /// 
        /// 
        /// <param name="locationTypeEnum"> LocationTypeEnum to convert </param>
        /// 
        /// 
        /// <returns> 
        /// 
        ///     LocationTypeEnum.A ==> "A"
        ///     LocationTypeEnum.S ==> "S"
        /// </returns>
        private static string ConvertLocationTypeEnumToString(LocationTypeEnum locationTypeEnum)
        {
            if (locationTypeEnum == LocationTypeEnum.A)
            {
                return "A";
            } else
            {
                return "S";
            }
        }








        /// <summary>
        /// Converts a Locations Object to a View Model Object.
        /// 
        /// Is used when a user is editing a Location's information
        /// </summary>
        /// 
        /// 
        /// <param name="referenceLocation"> The Locations Object to convert </param>
        /// 
        /// 
        /// <returns> A ViewModel Object populated with the Locations Object's data </returns>
        public bool InstatiateViewModelPropertiesWithOneLocation(Locations referenceLocation = null)
        {
            if (referenceLocation == null) // get first location
            {
                referenceLocation = locations.First();
            }
            AcceptCash = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.AcceptCash);
            AcceptDeposit = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.AcceptDeposit);
            Access = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.Access);
            AccessNotes = referenceLocation.SpecialQualities.AccessNotes;
            Address = referenceLocation.Address;
            Cashless = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.Cashless);
            City = referenceLocation.City;
            CoopLocationId = referenceLocation.CoopLocationId;
            Country = referenceLocation.Country;
            County = referenceLocation.County;
            DriveThruOnly = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.DriveThruOnly);
            EnvelopeRequired = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.EnvelopeRequired);
            Fax = referenceLocation.Contact.Fax;
            HandicapAccess = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.HandicapAccess);
            Hours = referenceLocation.Hours;
            if (referenceLocation.HoursPerDayOfTheWeek != null) // if there is an entry in the HoursPerDayOfTheWeek table for this record
            {
                HoursDtfriClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtfriClose;
                HoursDtfriOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtfriOpen;
                HoursDtmonClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtmonClose;
                HoursDtmonOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtmonOpen;
                HoursDtsatClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtsatClose;
                HoursDtsatOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtsatOpen;
                HoursDtsunClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtsunClose;
                HoursDtsunOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtsunOpen;
                HoursDtthuClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtthuClose;
                HoursDtthuOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtthuOpen;
                HoursDttueClose = referenceLocation.HoursPerDayOfTheWeek.HoursDttueClose;
                HoursDttueOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDttueOpen;
                HoursDtwedClose = referenceLocation.HoursPerDayOfTheWeek.HoursDtwedClose;
                HoursDtwedOpen = referenceLocation.HoursPerDayOfTheWeek.HoursDtwedOpen;
                HoursFriClose = referenceLocation.HoursPerDayOfTheWeek.HoursFriClose;
                HoursFriOpen = referenceLocation.HoursPerDayOfTheWeek.HoursFriOpen;
                HoursMonClose = referenceLocation.HoursPerDayOfTheWeek.HoursMonClose;
                HoursMonOpen = referenceLocation.HoursPerDayOfTheWeek.HoursMonOpen;
                HoursSatClose = referenceLocation.HoursPerDayOfTheWeek.HoursSatClose;
                HoursSatOpen = referenceLocation.HoursPerDayOfTheWeek.HoursSatOpen;
                HoursSunClose = referenceLocation.HoursPerDayOfTheWeek.HoursSunClose;
                HoursSunOpen = referenceLocation.HoursPerDayOfTheWeek.HoursSunOpen;
                HoursThuClose = referenceLocation.HoursPerDayOfTheWeek.HoursThuClose;
                HoursThuOpen = referenceLocation.HoursPerDayOfTheWeek.HoursThuOpen;
                HoursTueClose = referenceLocation.HoursPerDayOfTheWeek.HoursTueClose;
                HoursTueOpen = referenceLocation.HoursPerDayOfTheWeek.HoursTueOpen;
                HoursWedClose = referenceLocation.HoursPerDayOfTheWeek.HoursWedClose;
                HoursWedOpen = referenceLocation.HoursPerDayOfTheWeek.HoursWedOpen;
            }
            InstallationType = referenceLocation.SpecialQualities.InstallationType;
            Latitude = referenceLocation.Latitude;
            LimitedTransactions = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.LimitedTransactions);
            LocationId = referenceLocation.LocationId;
            LocationType = ConvertStringToLocationTypeEnum(referenceLocation.LocationType);
            Longitude = referenceLocation.Longitude;
            MilitaryIdRequired = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.MilitaryIdRequired);
            Name = referenceLocation.Name;
            OnMilitaryBase = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.OnMilitaryBase);
            OnPremise = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.OnPremise);
            Phone = referenceLocation.Contact.Phone;
            PostalCode = referenceLocation.PostalCode;
            RestrictedAccess = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.RestrictedAccess);
            RetailOutlet = referenceLocation.RetailOutlet;
            SelfServiceDevice = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.SelfServiceDevice);
            SelfServiceOnly = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.SelfServiceOnly);
            SoftDelete = ConvertBoolToBooleanEnum(referenceLocation.SoftDelete);
            State = ConvertStringToStateEnum(referenceLocation.State);
            Surcharge = ConvertStringToBooleanEnum(referenceLocation.SpecialQualities.Surcharge);
            TakeCoopData = ConvertBoolToBooleanEnum(referenceLocation.TakeCoopData);
            WebAddress = referenceLocation.Contact.WebAddress;
            return true;
        }
    }
}
