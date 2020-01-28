using adminconsole.Backend;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace adminconsole.Models
{
    public partial class LocationsContactSpecialQualitiesViewModel
    {
        public LocationsContactSpecialQualitiesViewModel()
        {
            locations = new List<Locations>();
            contacts = new List<Contacts>();
            specialQualities = new List<SpecialQualities>();
            dataSource = DataSourceEnum.LIVE;
        }
        public LocationsContactSpecialQualitiesViewModel(DataSourceEnum dataSource=DataSourceEnum.LIVE)
        {
            locations = new List<Locations>();
            contacts = new List<Contacts>();
            specialQualities = new List<SpecialQualities>();
            this.dataSource = dataSource;
        }

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
            location.LocationType = newLocation.LocationType;
            location.Longitude = newLocation.Longitude;
            location.Name = newLocation.Name ?? null;
            location.PostalCode = newLocation.PostalCode;
            location.RetailOutlet = newLocation.RetailOutlet ?? null;
            location.SoftDelete = ConvertBooleanEnumToBool(newLocation.SoftDelete);
            location.State = newLocation.State.ToString();
            location.TakeCoopData = ConvertBooleanEnumToBool(newLocation.TakeCoopData);
            return location;
        }

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

        public static StateEnum? ConvertStringToStateEnum(string stateValueFromDb)
        {
            switch (stateValueFromDb)
            {
                case ("AL"):
                    return StateEnum.AL;
                case ("AK"):
                    return StateEnum.AK;
                case ("AZ"):
                    return StateEnum.AZ;
                case ("AR"):
                    return StateEnum.AR;
                case ("CA"):
                    return StateEnum.CA;
                case ("CO"):
                    return StateEnum.CO;
                case ("CT"):
                    return StateEnum.CT;
                case ("DE"):
                    return StateEnum.DE;
                case ("DC"):
                    return StateEnum.DC;
                case ("FL"):
                    return StateEnum.FL;
                case ("GA"):
                    return StateEnum.GA;
                case ("GU"):
                    return StateEnum.GU;
                case ("HI"):
                    return StateEnum.HI;
                case ("ID"):
                    return StateEnum.ID;
                case ("IL"):
                    return StateEnum.IL;
                case ("IN"):
                    return StateEnum.IN;
                case ("IA"):
                    return StateEnum.IA;
                case ("KS"):
                    return StateEnum.KS;
                case ("KY"):
                    return StateEnum.KY;
                case ("LA"):
                    return StateEnum.LA;
                case ("ME"):
                    return StateEnum.ME;
                case ("MD"):
                    return StateEnum.MD;
                case ("MA"):
                    return StateEnum.MA;
                case ("MI"):
                    return StateEnum.MI;
                case ("MN"):
                    return StateEnum.MN;
                case ("MS"):
                    return StateEnum.MS;
                case ("MO"):
                    return StateEnum.MO;
                case ("MT"):
                    return StateEnum.MT;
                case ("NE"):
                    return StateEnum.NE;
                case ("NV"):
                    return StateEnum.NV;
                case ("NH"):
                    return StateEnum.NH;
                case ("NJ"):
                    return StateEnum.NJ;
                case ("NM"):
                    return StateEnum.NM;
                case ("NY"):
                    return StateEnum.NY;
                case ("NC"):
                    return StateEnum.NC;
                case ("ND"):
                    return StateEnum.ND;
                case ("OH"):
                    return StateEnum.OH;
                case ("OK"):
                    return StateEnum.OK;
                case ("OR"):
                    return StateEnum.OR;
                case ("PA"):
                    return StateEnum.PA;
                case ("RI"):
                    return StateEnum.RI;
                case ("SC"):
                    return StateEnum.SC;
                case ("SD"):
                    return StateEnum.SD;
                case ("TN"):
                    return StateEnum.TN;
                case ("TX"):
                    return StateEnum.TX;
                case ("UT"):
                    return StateEnum.UT;
                case ("VT"):
                    return StateEnum.VT;
                case ("VA"):
                    return StateEnum.VA;
                case ("WA"):
                    return StateEnum.WA;
                case ("WV"):
                    return StateEnum.WV;
                case ("WI"):
                    return StateEnum.WI;
                case ("WY"):
                    return StateEnum.WY;
                case ("AB"):
                    return StateEnum.AB;
                case ("BC"):
                    return StateEnum.BC;
                case ("MB"):
                    return StateEnum.MB;
                case ("NB"):
                    return StateEnum.NB;
                case ("NL"):
                    return StateEnum.NL;
                case ("NS"):
                    return StateEnum.NS;
                case ("ON"):
                    return StateEnum.ON;
                case ("QC"):
                    return StateEnum.QC;
                case ("SK"):
                    return StateEnum.SK;
                case ("AE"):
                    return StateEnum.AE;
                case ("PR"):
                    return StateEnum.PR;
                default:
                    return null; // should never happen as this is a required field in db
            }
        }

        public static LocationTypeEnum? ConvertStringToLocationTypeEnum(string locationTypeValueFromDb)
        {
            switch (locationTypeValueFromDb)
            {
                case ("A"):
                    return LocationTypeEnum.A;
                case ("S"):
                    return LocationTypeEnum.S;
                default:
                    return null;
            }
        }

        public bool InstatiateViewModelPropertiesWithOneLocation(Locations referenceLocation = null)
        {
            try
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
                LocationType = referenceLocation.LocationType;
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
            catch (Exception)
            {
                return false;
            }

        }
    }
}
