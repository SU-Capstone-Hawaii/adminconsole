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
        public LocationsContactSpecialQualitiesViewModel(DataSourceEnum dataSource=DataSourceEnum.LIVE)
        {
            this.dataSource = dataSource;
        }

        public LocationsContactSpecialQualitiesViewModel(MaphawksContext context, DataSourceEnum dataSource = DataSourceEnum.LIVE)
        {
            this.context = context;
            locations = new List<Locations>();
            contacts = new List<Contacts>();
            specialQualities = new List<SpecialQualities>();
            this.dataSource = dataSource;
        }

        public bool Index()
        {
            try
            {
                locations = context.Locations.Include(x => x.Contact).Include(x => x.SpecialQualities).ToList();
            } catch (Exception e)
            {
                return false;
            }
            return true;
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
            HoursPerDayOfTheWeek hoursPerDayOfTheWeek = new HoursPerDayOfTheWeek();
            Type type = hoursPerDayOfTheWeek.GetType();
            PropertyInfo[] properties = type.GetProperties();

            bool allNulls = true;

            foreach (PropertyInfo property in properties)
            {
                if ((property.GetValue(newLocation) != null) 
                    && allNulls)
                {
                    allNulls = false;
                }
                property.SetValue(hoursPerDayOfTheWeek, property.GetValue(newLocation));
            }

            if (allNulls)
            {
                return null;
            } else
            {
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
    }
}
