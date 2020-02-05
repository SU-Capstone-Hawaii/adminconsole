using adminconsole.Backend;
using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace adminconsoletest
{
    /// <summary>
    /// Tests default constructor
    /// </summary>
    [TestClass]
    public class LocationsContactSpecialQualitiesBackendTest
    {

        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new LocationsContactSpecialQualitiesBackend();

            // Assert
            Assert.IsNotNull(result);
        }




        /// <summary>
        /// Tests constructor with Context parameter.
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_Constructor_With_Context_Parameter_Should_Pass()
        {
            // Arrange
            MaphawksContext context = new MaphawksContext();

            // Act
            var result = new LocationsContactSpecialQualitiesBackend(context);

            // Assert
            Assert.IsNotNull(result);
        }





        /// <summary>
        /// Tests Backend IndexAsync for deleted locations.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_Index_Deleted_Locations_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);


            // Act
            var result = await backend.IndexAsync(true);

            // Assert
            foreach (var location in result)
            {
                Assert.AreEqual(true, location.SoftDelete);
            }

            Assert.AreEqual(3, result.Count);
        }





        /// <summary>
        /// Tests Backend IndexAsync for non-deleted locations.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_IndexAsync_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);


            // Act
            var result = await backend.IndexAsync();

            // Assert
            foreach (var location in result)
            {
                Assert.AreNotEqual(true, location.SoftDelete);
            }

            Assert.AreEqual(2, result.Count);
        }






        /// <summary>
        /// Tests Backend IndexAsync for non-deleted locations.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DetailsAsync_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var id = "59bb3e88-9757-492e-a07c-b7efd3f316c3";


            // Act
            var result = await backend.DetailsAsync(id);

            // Assert
            Assert.AreEqual(id, result.LocationId);
        }




        /// <summary>
        /// Tests Backend DetailsAsync for a Location record ID that does not exist
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DetailsAsync_Invalid_Id_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var id = Guid.NewGuid().ToString();


            // Act
            var result = await backend.DetailsAsync(id);

            // Assert
            Assert.IsNull(result);
        }



        /// <summary>
        /// Tests Backend Create which will create a new Location record in all tables.
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_Create_Should_Pass_()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            LocationsContactSpecialQualitiesViewModel location = new LocationsContactSpecialQualitiesViewModel();

            location.AcceptCash = BooleanEnum.Y;
            location.AcceptDeposit = BooleanEnum.Y;
            location.Access = BooleanEnum.Y;
            location.AccessNotes = "Lobby";
            location.Address = "362 Oxford Dr.";
            location.Cashless = BooleanEnum.Y;
            location.City = "Starkville";
            location.CoopLocationId = "WA9820-174920573";
            location.Country = "US";
            location.County = "King County";
            location.DriveThruOnly = BooleanEnum.Y;
            location.EnvelopeRequired = BooleanEnum.Y;
            location.Fax = "8058451931";
            location.HandicapAccess = BooleanEnum.Y;
            location.Hours = "24 HOURS ACCESS";
            location.HoursDtfriClose = "9";
            location.HoursDtfriOpen = "9";
            location.HoursDtmonClose = "9";
            location.HoursDtmonOpen = "9";
            location.HoursDtsatClose = "9";
            location.HoursDtsatOpen = "9";
            location.HoursDtsunClose = "9";
            location.HoursDtsunOpen = "9";
            location.HoursDtthuClose = "9";
            location.HoursDtthuOpen = "9";
            location.HoursDttueClose = "9";
            location.HoursDttueOpen = "9";
            location.HoursDtwedClose = "9";
            location.HoursDtwedOpen = "9";
            location.HoursFriClose = "9";
            location.HoursFriOpen = "9";
            location.HoursMonClose = "9";
            location.HoursMonOpen = "9";
            location.HoursSatClose = "9";
            location.HoursSatOpen = "9";
            location.HoursSunClose = "9";
            location.HoursSunOpen = "9";
            location.HoursThuClose = "9";
            location.HoursThuOpen = "9";
            location.HoursTueClose = "9";
            location.HoursTueOpen = "9";
            location.HoursWedClose = "9";
            location.HoursWedOpen = "9";
            location.InstallationType = "Walk-Up";
            location.Latitude = 13.3108M;
            location.LimitedTransactions = BooleanEnum.Y;
            location.LocationId = "NEW LOCATION ID";
            location.locations = new List<Locations>();
            location.LocationType = LocationTypeEnum.A;
            location.Longitude = -132.8851M;
            location.MilitaryIdRequired = BooleanEnum.Y;
            location.Name = "BECU";
            location.OnMilitaryBase = BooleanEnum.Y;
            location.OnPremise = BooleanEnum.Y;
            location.Phone = "4896771019";
            location.PostalCode = "39759";
            location.RestrictedAccess = BooleanEnum.Y;
            location.RetailOutlet = "Northgate";
            location.SelfServiceDevice = BooleanEnum.Y;
            location.SelfServiceOnly = BooleanEnum.Y;
            location.SoftDelete = BooleanEnum.Y;
            location.State = StateEnum.MS;
            location.Surcharge = BooleanEnum.Y;
            location.TakeCoopData = BooleanEnum.Y;
            location.WebAddress = "https://trypap.com/";


            // Act
            var result = backend.Create(location);


            // Assert
            Assert.IsTrue(result);
        }



        /// <summary>
        /// Tests Backend Create which will not create  a new Location record in all tables
        /// because it has a non-unique LocationId.
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_Create_Should_Not_Pass_()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            LocationsContactSpecialQualitiesViewModel location = new LocationsContactSpecialQualitiesViewModel();

            location.AcceptCash = BooleanEnum.Y;
            location.AcceptDeposit = BooleanEnum.Y;
            location.Access = BooleanEnum.Y;
            location.AccessNotes = "Lobby";
            location.Address = "362 Oxford Dr.";
            location.Cashless = BooleanEnum.Y;
            location.City = "Starkville";
            location.CoopLocationId = "WA9820-174920573";
            location.Country = "US";
            location.County = "King County";
            location.DriveThruOnly = BooleanEnum.Y;
            location.EnvelopeRequired = BooleanEnum.Y;
            location.Fax = "8058451931";
            location.HandicapAccess = BooleanEnum.Y;
            location.Hours = "24 HOURS ACCESS";
            location.HoursDtfriClose = "9";
            location.HoursDtfriOpen = "9";
            location.HoursDtmonClose = "9";
            location.HoursDtmonOpen = "9";
            location.HoursDtsatClose = "9";
            location.HoursDtsatOpen = "9";
            location.HoursDtsunClose = "9";
            location.HoursDtsunOpen = "9";
            location.HoursDtthuClose = "9";
            location.HoursDtthuOpen = "9";
            location.HoursDttueClose = "9";
            location.HoursDttueOpen = "9";
            location.HoursDtwedClose = "9";
            location.HoursDtwedOpen = "9";
            location.HoursFriClose = "9";
            location.HoursFriOpen = "9";
            location.HoursMonClose = "9";
            location.HoursMonOpen = "9";
            location.HoursSatClose = "9";
            location.HoursSatOpen = "9";
            location.HoursSunClose = "9";
            location.HoursSunOpen = "9";
            location.HoursThuClose = "9";
            location.HoursThuOpen = "9";
            location.HoursTueClose = "9";
            location.HoursTueOpen = "9";
            location.HoursWedClose = "9";
            location.HoursWedOpen = "9";
            location.InstallationType = "Walk-Up";
            location.Latitude = 13.3108M;
            location.LimitedTransactions = BooleanEnum.Y;
            location.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
            location.locations = new List<Locations>();
            location.LocationType = LocationTypeEnum.A;
            location.Longitude = -132.8851M;
            location.MilitaryIdRequired = BooleanEnum.Y;
            location.Name = "BECU";
            location.OnMilitaryBase = BooleanEnum.Y;
            location.OnPremise = BooleanEnum.Y;
            location.Phone = "4896771019";
            location.PostalCode = "39759";
            location.RestrictedAccess = BooleanEnum.Y;
            location.RetailOutlet = "Northgate";
            location.SelfServiceDevice = BooleanEnum.Y;
            location.SelfServiceOnly = BooleanEnum.Y;
            location.SoftDelete = BooleanEnum.Y;
            location.State = StateEnum.MS;
            location.Surcharge = BooleanEnum.Y;
            location.TakeCoopData = BooleanEnum.Y;
            location.WebAddress = "https://trypap.com/";


            // Act
            var result = backend.Create(location);


            // Assert
            Assert.IsFalse(result);
        }





        /// <summary>
        /// Tests Backend Create which will not create  a new Location record in all tables
        /// because it has a non-unique LocationId.
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_GetLocation_Should_Pass_()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            string locationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";

            Locations location = new Locations();
            location.Address = "8071 Sunbeam Court";
            location.City = "Massillon";
            location.CoopLocationId = null;
            location.Country = null;
            location.County = null;
            location.Hours = null;
            location.Latitude = -20.9110M;
            location.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
            location.LocationType = "ATM";
            location.Longitude = -84.8988M;
            location.Name = null;
            location.PostalCode = "44646";
            location.RetailOutlet = null;
            location.SoftDelete = null;
            location.State = "Ohio";
            location.TakeCoopData = null;

            // Act
            var result = backend.GetLocation(locationId);


            // Assert
            Assert.AreEqual(location.Address, result.Address);
            Assert.AreEqual(location.City, result.City);
            Assert.AreEqual(location.CoopLocationId, result.CoopLocationId);
            Assert.AreEqual(location.Country, result.Country);
            Assert.AreEqual(location.County, result.County);
            Assert.AreEqual(location.Hours, result.Hours);
            Assert.AreEqual(location.Latitude, result.Latitude);
            Assert.AreEqual(location.LocationId, result.LocationId);
            Assert.AreEqual(location.LocationType, result.LocationType);
            Assert.AreEqual(location.Longitude, result.Longitude);
            Assert.AreEqual(location.Name, result.Name);
            Assert.AreEqual(location.PostalCode, result.PostalCode);
            Assert.AreEqual(location.RetailOutlet, result.RetailOutlet);
            Assert.AreEqual(location.SoftDelete, result.SoftDelete);
            Assert.AreEqual(location.State, result.State);
            Assert.AreEqual(location.TakeCoopData, result.TakeCoopData);
        }
    }
}
