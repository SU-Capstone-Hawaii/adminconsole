using adminconsole.Backend;
using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace adminconsoletest
{
    [TestClass]
    public class LocationsContactSpecialQualitiesViewModelTest
    {
        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Constructor_With_Context_Parameter_Should_Pass()
        {
            // Arrange
            MaphawksContext context = new MaphawksContext();

            // Act
            var result = new LocationsContactSpecialQualitiesViewModel(context);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.context);
            Assert.IsNotNull(result.locations);
            Assert.IsNotNull(result.locations);
            Assert.IsNotNull(result.specialQualities);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Get_Property_Defaults_Should_Pass()
        {
            // Arrange
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Act

            // Assert
            // Locations
            Assert.IsNull(result.Address);
            Assert.IsNull(result.City);
            Assert.IsNull(result.contacts);
            Assert.IsNull(result.CoopLocationId);
            Assert.IsNull(result.Country);
            Assert.IsNull(result.County);
            Assert.IsNull(result.Hours);
            Assert.IsNull(result.Latitude);
            Assert.IsNull(result.LocationId);
            Assert.IsNull(result.LocationType);
            Assert.IsNull(result.Longitude);
            Assert.IsNull(result.Name);
            Assert.IsNull(result.PostalCode);
            Assert.IsNull(result.RetailOutlet);
            Assert.IsNull(result.SoftDelete);
            Assert.IsNull(result.specialQualities);
            Assert.IsNull(result.State);
            Assert.IsNull(result.TakeCoopData);

            // Contacts
            Assert.IsNull(result.Phone);
            Assert.IsNull(result.Fax);
            Assert.IsNull(result.WebAddress);

            // Special Qualities
            Assert.IsNull(result.AcceptCash);
            Assert.IsNull(result.AcceptDeposit);
            Assert.IsNull(result.Access);
            Assert.IsNull(result.AccessNotes);
            Assert.IsNull(result.Cashless);
            Assert.IsNull(result.DriveThruOnly);
            Assert.IsNull(result.EnvelopeRequired);
            Assert.IsNull(result.HandicapAccess);
            Assert.IsNull(result.InstallationType);
            Assert.IsNull(result.LimitedTransactions);
            Assert.IsNull(result.locations);
            Assert.IsNull(result.MilitaryIdRequired);
            Assert.IsNull(result.OnMilitaryBase);
            Assert.IsNull(result.OnPremise);
            Assert.IsNull(result.RestrictedAccess);
            Assert.IsNull(result.SelfServiceDevice);
            Assert.IsNull(result.SelfServiceOnly);
            Assert.IsNull(result.State);
            Assert.IsNull(result.Surcharge);

            // Hours Per Day Of The Week
            Assert.IsNull(result.HoursDtfriClose);
            Assert.IsNull(result.HoursDtfriOpen);
            Assert.IsNull(result.HoursDtmonClose);
            Assert.IsNull(result.HoursDtmonOpen);
            Assert.IsNull(result.HoursDtsatClose);
            Assert.IsNull(result.HoursDtsatOpen);
            Assert.IsNull(result.HoursDtsunClose);
            Assert.IsNull(result.HoursDtsunOpen);
            Assert.IsNull(result.HoursDtthuClose);
            Assert.IsNull(result.HoursDtthuOpen);
            Assert.IsNull(result.HoursDttueClose);
            Assert.IsNull(result.HoursDttueOpen);
            Assert.IsNull(result.HoursDtwedClose);
            Assert.IsNull(result.HoursDtwedOpen);
            Assert.IsNull(result.HoursFriClose);
            Assert.IsNull(result.HoursFriOpen);
            Assert.IsNull(result.HoursMonClose);
            Assert.IsNull(result.HoursMonOpen);
            Assert.IsNull(result.HoursSatClose);
            Assert.IsNull(result.HoursSatOpen);
            Assert.IsNull(result.HoursSunClose);
            Assert.IsNull(result.HoursSunOpen);
            Assert.IsNull(result.HoursThuClose);
            Assert.IsNull(result.HoursThuOpen);
            Assert.IsNull(result.HoursTueClose);
            Assert.IsNull(result.HoursTueOpen);
            Assert.IsNull(result.HoursWedClose);
            Assert.IsNull(result.HoursWedOpen);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Act
            // Locations
            result.AcceptCash = BooleanEnum.Y;
            result.AcceptDeposit = BooleanEnum.Y;
            result.Access = BooleanEnum.Y;
            result.AccessNotes = "Lobby";
            result.Address = "362 Oxford Dr.";
            result.Cashless = BooleanEnum.Y;
            result.City = "Starkville";
            result.contacts = new List<Contacts>();
            result.CoopLocationId = "WA9820-174920573";
            result.Country = "US";
            result.County = "King County";
            result.DriveThruOnly = BooleanEnum.Y;
            result.EnvelopeRequired = BooleanEnum.Y;
            result.Fax = "8058451931";
            result.HandicapAccess = BooleanEnum.Y;
            result.Hours = "24 HOURS ACCESS";
            result.HoursDtfriClose = "9";
            result.HoursDtfriOpen = "9";
            result.HoursDtmonClose = "9";
            result.HoursDtmonOpen = "9";
            result.HoursDtsatClose = "9";
            result.HoursDtsatOpen = "9";
            result.HoursDtsunClose = "9";
            result.HoursDtsunOpen = "9";
            result.HoursDtthuClose = "9";
            result.HoursDtthuOpen = "9";
            result.HoursDttueClose = "9";
            result.HoursDttueOpen = "9";
            result.HoursDtwedClose = "9";
            result.HoursDtwedOpen = "9";
            result.HoursFriClose = "9";
            result.HoursFriOpen = "9";
            result.HoursMonClose = "9";
            result.HoursMonOpen = "9";
            result.HoursSatClose = "9";
            result.HoursSatOpen = "9";
            result.HoursSunClose = "9";
            result.HoursSunOpen = "9";
            result.HoursThuClose = "9";
            result.HoursThuOpen = "9";
            result.HoursTueClose = "9";
            result.HoursTueOpen = "9";
            result.HoursWedClose = "9";
            result.HoursWedOpen = "9";
            result.InstallationType = "Walk-Up";
            result.Latitude = 13.3108M;
            result.LimitedTransactions = BooleanEnum.Y;
            result.LocationId = "11170401-4112-43c1-aa4e-f73370e1014a";
            result.locations = new List<Locations>();
            result.LocationType = "A";
            result.Longitude = -132.8851M;
            result.MilitaryIdRequired = BooleanEnum.Y;
            result.Name = "BECU";
            result.OnMilitaryBase = BooleanEnum.Y;
            result.OnPremise = BooleanEnum.Y;
            result.Phone = "4896771019";
            result.PostalCode = "39759";
            result.RestrictedAccess = BooleanEnum.Y;
            result.RetailOutlet = "Northgate";
            result.SelfServiceDevice = BooleanEnum.Y;
            result.SelfServiceOnly = BooleanEnum.Y;
            result.SoftDelete = BooleanEnum.Y;
            result.specialQualities = new List<SpecialQualities>();
            result.State = StateEnum.MS;
            result.Surcharge = BooleanEnum.Y;
            result.TakeCoopData = BooleanEnum.Y;
            result.WebAddress = "https://trypap.com/";

            // Assert
            // Locations
            Assert.AreEqual(BooleanEnum.Y, result.AcceptCash);
            Assert.AreEqual(BooleanEnum.Y, result.AcceptDeposit);
            Assert.AreEqual(BooleanEnum.Y, result.Access);
            Assert.AreEqual("Lobby", result.AccessNotes);
            Assert.AreEqual("362 Oxford Dr.", result.Address);
            Assert.AreEqual(BooleanEnum.Y, result.Cashless);
            Assert.AreEqual("Starkville", result.City);
            Assert.IsNotNull(result.contacts);
            Assert.AreEqual("WA9820-174920573", result.CoopLocationId);
            Assert.AreEqual("US", result.Country);
            Assert.AreEqual("King County", result.County);
            Assert.AreEqual(BooleanEnum.Y, result.DriveThruOnly);
            Assert.AreEqual(BooleanEnum.Y, result.EnvelopeRequired);
            Assert.AreEqual("8058451931", result.Fax);
            Assert.AreEqual(BooleanEnum.Y, result.HandicapAccess);
            Assert.AreEqual("24 HOURS ACCESS", result.Hours);
            Assert.AreEqual("9", result.HoursDtfriClose);
            Assert.AreEqual("9", result.HoursDtfriOpen);
            Assert.AreEqual("9", result.HoursDtmonClose);
            Assert.AreEqual("9", result.HoursDtmonOpen);
            Assert.AreEqual("9", result.HoursDtsatClose);
            Assert.AreEqual("9", result.HoursDtsatOpen);
            Assert.AreEqual("9", result.HoursDtsunClose);
            Assert.AreEqual("9", result.HoursDtsunOpen);
            Assert.AreEqual("9", result.HoursDtthuClose);
            Assert.AreEqual("9", result.HoursDtthuOpen);
            Assert.AreEqual("9", result.HoursDttueClose);
            Assert.AreEqual("9", result.HoursDttueOpen);
            Assert.AreEqual("9", result.HoursDtwedClose);
            Assert.AreEqual("9", result.HoursDtwedOpen);
            Assert.AreEqual("9", result.HoursFriClose);
            Assert.AreEqual("9", result.HoursFriOpen);
            Assert.AreEqual("9", result.HoursMonClose);
            Assert.AreEqual("9", result.HoursMonOpen);
            Assert.AreEqual("9", result.HoursSatClose);
            Assert.AreEqual("9", result.HoursSatOpen);
            Assert.AreEqual("9", result.HoursSunClose);
            Assert.AreEqual("9", result.HoursSunOpen);
            Assert.AreEqual("9", result.HoursThuClose);
            Assert.AreEqual("9", result.HoursThuOpen);
            Assert.AreEqual("9", result.HoursTueClose);
            Assert.AreEqual("9", result.HoursTueOpen);
            Assert.AreEqual("9", result.HoursWedClose);
            Assert.AreEqual("9", result.HoursWedOpen);
            Assert.AreEqual("Walk-Up", result.InstallationType);
            Assert.AreEqual(13.3108M, result.Latitude);
            Assert.AreEqual(BooleanEnum.Y, result.LimitedTransactions);
            Assert.AreEqual("11170401-4112-43c1-aa4e-f73370e1014a", result.LocationId);
            Assert.IsNotNull(result.locations);
            Assert.AreEqual("A", result.LocationType);
            Assert.AreEqual(-132.8851M, result.Longitude);
            Assert.AreEqual(BooleanEnum.Y, result.MilitaryIdRequired);
            Assert.AreEqual("BECU", result.Name);
            Assert.AreEqual(BooleanEnum.Y, result.OnMilitaryBase);
            Assert.AreEqual(BooleanEnum.Y, result.OnPremise);
            Assert.AreEqual("4896771019", result.Phone);
            Assert.AreEqual("39759", result.PostalCode);
            Assert.AreEqual(BooleanEnum.Y, result.RestrictedAccess);
            Assert.AreEqual("Northgate", result.RetailOutlet);
            Assert.AreEqual(BooleanEnum.Y, result.SelfServiceDevice);
            Assert.AreEqual(BooleanEnum.Y, result.SelfServiceOnly);
            Assert.AreEqual(BooleanEnum.Y, result.SoftDelete);
            Assert.IsNotNull(result.specialQualities);
            Assert.AreEqual(StateEnum.MS, result.State);
            Assert.AreEqual(BooleanEnum.Y, result.Surcharge);
            Assert.AreEqual(BooleanEnum.Y, result.TakeCoopData);
            Assert.AreEqual("https://trypap.com/", result.WebAddress);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Index_Should_Pass()
        {
          
        }
    }
}
