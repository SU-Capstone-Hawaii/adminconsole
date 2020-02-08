﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace adminconsole.Models
{
    public partial class AllTablesViewModel
    {
        /// <summary>
        /// Default constructor. 
        /// 
        /// Allows app to access Database
        /// </summary>
        public AllTablesViewModel()
        {
            locations = new List<Locations>();
        }






        /// <summary>
        /// Parameterized constructor
        /// 
        /// 
        /// Allows app to create a ViewModel object out of a Locations object
        /// Allows app to use mock data class when unit testing 
        /// </summary>
        /// <param name="dataSource"></param>
        public AllTablesViewModel(Locations location = null)
        {
            locations = new List<Locations>();

            if (location is null)
            {
                return;
            }



            //Begin translating location properties to ViewModel



            // Locations Properties
            Address = location.Address;
            City = location.City;
            CoopLocationId = location.CoopLocationId;
            Country = location.Country;
            County = location.County;
            Hours = location.Hours;
            Latitude = location.Latitude;
            LocationId = location.LocationId;
            LocationType = ConvertStringToLocationTypeEnum(location.LocationType);
            Longitude = location.Longitude;
            Name = location.Name;
            PostalCode = location.PostalCode;
            RetailOutlet = location.RetailOutlet;
            SoftDelete = ConvertBoolToBooleanEnum(location.SoftDelete);
            State = ConvertStringToStateEnum(location.State);
            TakeCoopData = ConvertBoolToBooleanEnum(location.TakeCoopData);



            // Contacts Properties
            if (!(location.Contact is null))
            {
                Fax = location.Contact.Fax;
                Phone = location.Contact.Phone;
                WebAddress = location.Contact.WebAddress;
            }




            // SpecialQualities Properties 
            if (!(location.SpecialQualities is null))
            {
                AcceptCash = ConvertStringToBooleanEnum(location.SpecialQualities.AcceptCash);
                AcceptDeposit = ConvertStringToBooleanEnum(location.SpecialQualities.AcceptDeposit);
                Access = ConvertStringToBooleanEnum(location.SpecialQualities.Access);
                AccessNotes = location.SpecialQualities.AccessNotes;
                Cashless = ConvertStringToBooleanEnum(location.SpecialQualities.Cashless);
                DriveThruOnly = ConvertStringToBooleanEnum(location.SpecialQualities.DriveThruOnly);
                EnvelopeRequired = ConvertStringToBooleanEnum(location.SpecialQualities.EnvelopeRequired);
                HandicapAccess = ConvertStringToBooleanEnum(location.SpecialQualities.HandicapAccess);
                InstallationType = location.SpecialQualities.InstallationType;
                LimitedTransactions = ConvertStringToBooleanEnum(location.SpecialQualities.LimitedTransactions);
                MilitaryIdRequired = ConvertStringToBooleanEnum(location.SpecialQualities.MilitaryIdRequired);
                OnMilitaryBase = ConvertStringToBooleanEnum(location.SpecialQualities.OnMilitaryBase);
                OnPremise = ConvertStringToBooleanEnum(location.SpecialQualities.OnPremise);
                RestrictedAccess = ConvertStringToBooleanEnum(location.SpecialQualities.RestrictedAccess);
                SelfServiceDevice = ConvertStringToBooleanEnum(location.SpecialQualities.SelfServiceDevice);
                SelfServiceOnly = ConvertStringToBooleanEnum(location.SpecialQualities.SelfServiceOnly);
                Surcharge = ConvertStringToBooleanEnum(location.SpecialQualities.Surcharge);
            }





            // DailyHours Properties
            if (location.DailyHours != null)
            {
                HoursDtfriClose = location.DailyHours.HoursDtfriClose;
                HoursDtfriOpen = location.DailyHours.HoursDtfriOpen;
                HoursDtmonClose = location.DailyHours.HoursDtmonClose;
                HoursDtmonOpen = location.DailyHours.HoursDtmonOpen;
                HoursDtsatClose = location.DailyHours.HoursDtsatClose;
                HoursDtsatOpen = location.DailyHours.HoursDtsatOpen;
                HoursDtsunClose = location.DailyHours.HoursDtsunClose;
                HoursDtsunOpen = location.DailyHours.HoursDtsunOpen;
                HoursDtthuClose = location.DailyHours.HoursDtthuClose;
                HoursDtthuOpen = location.DailyHours.HoursDtthuOpen;
                HoursDttueClose = location.DailyHours.HoursDttueClose;
                HoursDttueOpen = location.DailyHours.HoursDttueOpen;
                HoursDtwedClose = location.DailyHours.HoursDtwedClose;
                HoursDtwedOpen = location.DailyHours.HoursDtwedOpen;
                HoursFriClose = location.DailyHours.HoursFriClose;
                HoursFriOpen = location.DailyHours.HoursFriOpen;
                HoursMonClose = location.DailyHours.HoursMonClose;
                HoursMonOpen = location.DailyHours.HoursMonOpen;
                HoursSatClose = location.DailyHours.HoursSatClose;
                HoursSatOpen = location.DailyHours.HoursSatOpen;
                HoursSunClose = location.DailyHours.HoursSunClose;
                HoursSunOpen = location.DailyHours.HoursSunOpen;
                HoursThuClose = location.DailyHours.HoursThuClose;
                HoursThuOpen = location.DailyHours.HoursThuOpen;
                HoursTueClose = location.DailyHours.HoursTueClose;
                HoursTueOpen = location.DailyHours.HoursTueOpen;
                HoursWedClose = location.DailyHours.HoursWedClose;
                HoursWedOpen = location.DailyHours.HoursWedOpen;
            }
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
        public static Locations GetNewLocation(AllTablesViewModel newLocation)
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
        public static Contacts GetNewContact(AllTablesViewModel newLocation)
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
        public static SpecialQualities GetNewSpecialQualities(AllTablesViewModel newLocation)
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
        /// Populates a DailyHours Object from a View Model Object's properties.
        /// </summary>
        /// 
        /// 
        /// <param name="newLocation"> A View Model Object from which to extract from </param>
        /// 
        /// 
        /// <returns> A DailyHours Object or null if all properties are null </returns>
        public static DailyHours GetNewDailyHours(AllTablesViewModel newLocation)
        {
            if (newLocation is null)
            {
                return null;
            }

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
            }


            DailyHours DailyHours = new DailyHours();
            DailyHours.LocationId = newLocation.LocationId;
            DailyHours.HoursDtfriClose = newLocation.HoursDtfriClose;
            DailyHours.HoursDtfriOpen = newLocation.HoursDtfriOpen;
            DailyHours.HoursDtmonClose = newLocation.HoursDtmonClose;
            DailyHours.HoursDtmonOpen = newLocation.HoursDtmonOpen;
            DailyHours.HoursDtsatClose = newLocation.HoursDtsatClose;
            DailyHours.HoursDtsatOpen = newLocation.HoursDtsatOpen;
            DailyHours.HoursDtsunClose = newLocation.HoursDtsunClose;
            DailyHours.HoursDtsunOpen = newLocation.HoursDtsunOpen;
            DailyHours.HoursDtthuClose = newLocation.HoursDtthuClose;
            DailyHours.HoursDtthuOpen = newLocation.HoursDtthuOpen;
            DailyHours.HoursDttueClose = newLocation.HoursDttueClose;
            DailyHours.HoursDttueOpen =newLocation.HoursDttueOpen;
            DailyHours.HoursDtwedClose = newLocation.HoursDtwedClose;
            DailyHours.HoursDtwedOpen = newLocation.HoursDtwedOpen;
            DailyHours.HoursFriClose = newLocation.HoursFriClose;
            DailyHours.HoursFriOpen = newLocation.HoursFriOpen;
            DailyHours.HoursMonClose = newLocation.HoursMonClose;
            DailyHours.HoursMonOpen = newLocation.HoursMonOpen;
            DailyHours.HoursSatClose = newLocation.HoursSatClose;
            DailyHours.HoursSatOpen = newLocation.HoursSatOpen;
            DailyHours.HoursSunClose = newLocation.HoursSunClose;
            DailyHours.HoursSunOpen = newLocation.HoursSunOpen;
            DailyHours.HoursThuClose = newLocation.HoursThuClose;
            DailyHours.HoursThuOpen = newLocation.HoursThuOpen;
            DailyHours.HoursTueClose = newLocation.HoursTueClose;
            DailyHours.HoursTueOpen = newLocation.HoursTueOpen;
            DailyHours.HoursWedClose = newLocation.HoursWedClose;
            DailyHours.HoursWedOpen = newLocation.HoursWedOpen;
            return DailyHours;
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
            if (referenceLocation.DailyHours != null) // if there is an entry in the DailyHours table for this record
            {
                HoursDtfriClose = referenceLocation.DailyHours.HoursDtfriClose;
                HoursDtfriOpen = referenceLocation.DailyHours.HoursDtfriOpen;
                HoursDtmonClose = referenceLocation.DailyHours.HoursDtmonClose;
                HoursDtmonOpen = referenceLocation.DailyHours.HoursDtmonOpen;
                HoursDtsatClose = referenceLocation.DailyHours.HoursDtsatClose;
                HoursDtsatOpen = referenceLocation.DailyHours.HoursDtsatOpen;
                HoursDtsunClose = referenceLocation.DailyHours.HoursDtsunClose;
                HoursDtsunOpen = referenceLocation.DailyHours.HoursDtsunOpen;
                HoursDtthuClose = referenceLocation.DailyHours.HoursDtthuClose;
                HoursDtthuOpen = referenceLocation.DailyHours.HoursDtthuOpen;
                HoursDttueClose = referenceLocation.DailyHours.HoursDttueClose;
                HoursDttueOpen = referenceLocation.DailyHours.HoursDttueOpen;
                HoursDtwedClose = referenceLocation.DailyHours.HoursDtwedClose;
                HoursDtwedOpen = referenceLocation.DailyHours.HoursDtwedOpen;
                HoursFriClose = referenceLocation.DailyHours.HoursFriClose;
                HoursFriOpen = referenceLocation.DailyHours.HoursFriOpen;
                HoursMonClose = referenceLocation.DailyHours.HoursMonClose;
                HoursMonOpen = referenceLocation.DailyHours.HoursMonOpen;
                HoursSatClose = referenceLocation.DailyHours.HoursSatClose;
                HoursSatOpen = referenceLocation.DailyHours.HoursSatOpen;
                HoursSunClose = referenceLocation.DailyHours.HoursSunClose;
                HoursSunOpen = referenceLocation.DailyHours.HoursSunOpen;
                HoursThuClose = referenceLocation.DailyHours.HoursThuClose;
                HoursThuOpen = referenceLocation.DailyHours.HoursThuOpen;
                HoursTueClose = referenceLocation.DailyHours.HoursTueClose;
                HoursTueOpen = referenceLocation.DailyHours.HoursTueOpen;
                HoursWedClose = referenceLocation.DailyHours.HoursWedClose;
                HoursWedOpen = referenceLocation.DailyHours.HoursWedOpen;
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





        private static AllTablesViewModel? CreateTableObjectIfNotAllNulls(Locations referenceLocation, Type tableTypeReference)
        {
            // Reference types
            Contacts contact = new Contacts();
            SpecialQualities specialQualities = new SpecialQualities();
            DailyHours DailyHours = new DailyHours();


            bool allNulls = false;


            Type locationsType = referenceLocation.GetType();

            var properties = locationsType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(referenceLocation, null);

                if (value is null) //Check next property if null field in Locations
                {

                    continue;

                }

                var valueString = value.ToString();
                if (string.IsNullOrEmpty(valueString) || string.IsNullOrWhiteSpace(valueString)) // Check next property if null field in Locations
                {

                    continue;

                }
            }

            return null;

        }
    }
}