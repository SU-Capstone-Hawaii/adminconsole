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
        /// Tests Backend GetLocation with a valid LocationId value
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






        /// <summary>
        /// Tests Backend GetLocation with an invalid LocationId value
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_GetLocation_Invalid_Id_Should_Not_Pass_()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            string locationId = "INVALID LOCATION ID";

            // Act
            var result = backend.GetLocation(locationId);


            // Assert
            Assert.IsNull(result);
        }




        /// <summary>
        /// Tests Backend GetLocation with a null LocationId value
        /// </summary>
        [TestMethod]
        public void LocationsContactSpecialQualitiesBackend_GetLocation_Null_Id_Should_Not_Pass_()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);

            // Act
            var result = backend.GetLocation(null);


            // Assert
            Assert.IsNull(result);
        }





        /// <summary>
        /// Tests Backend DeleteConfirmedAsync with a valid LocationId
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DeleteConfirmedAsync_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var locationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";


            // Act
            var result = await backend.DeleteConfirmedAsync(locationId);


            // Assert
            Assert.IsTrue(result);
        }








        /// <summary>
        /// Tests Backend DeleteConfirmedAsync with an invalid LocationId
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DeleteConfirmedAsync_Invalid_Id_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var locationId = "INVALID ID";


            // Act
            var result = await backend.DeleteConfirmedAsync(locationId);


            // Assert
            Assert.IsFalse(result);
        }





        /// <summary>
        /// Tests Backend DeleteConfirmedAsync with a null LocationId
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DeleteConfirmedAsync_Null_Id_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);


            // Act
            var result = await backend.DeleteConfirmedAsync(null);


            // Assert
            Assert.IsFalse(result);
        }







        /// <summary>
        /// Tests Backend DeleteConfirmedAsync with a LocationId that has already
        /// been deleted
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_DeleteConfirmedAsync_Already_Deleted_Id_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var locationId = "6cc2244b-ff5b-4860-8464-2e5186b7060f";

            // Act
            var result = await backend.DeleteConfirmedAsync(locationId);


            // Assert
            Assert.IsFalse(result);
        }






        /// <summary>
        /// Tests Backend EditAsync method. The method should return the Locations record 
        /// with the LocationId it receives. 
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_EditAsync_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            string locationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
            var location = new LocationsContactSpecialQualitiesViewModel();

            location.AcceptCash = BooleanEnum.NULL;
            location.AcceptDeposit = BooleanEnum.NULL;
            location.Access = BooleanEnum.NULL;
            location.AccessNotes = null;
            location.Address = "8071 Sunbeam Court";
            location.Cashless = BooleanEnum.NULL;
            location.City = "Massillon";
            location.CoopLocationId = null;
            location.Country = null;
            location.County = null;
            location.DriveThruOnly = BooleanEnum.NULL;
            location.EnvelopeRequired = BooleanEnum.NULL;
            location.Fax = "9166280006";
            location.HandicapAccess = BooleanEnum.NULL;
            location.Hours = null;
            location.HoursDtfriClose = null;
            location.HoursDtfriOpen = null;
            location.HoursDtmonClose = null;
            location.HoursDtmonOpen = null;
            location.HoursDtsatClose = null;
            location.HoursDtsatOpen = null;
            location.HoursDtsunClose = null;
            location.HoursDtsunOpen = null;
            location.HoursDtthuClose = null;
            location.HoursDtthuOpen = null;
            location.HoursDttueClose = null;
            location.HoursDttueOpen = null;
            location.HoursDtwedClose = null;
            location.HoursDtwedOpen = null;
            location.HoursFriClose = null;
            location.HoursFriOpen = null;
            location.HoursMonClose = null;
            location.HoursMonOpen = null;
            location.HoursSatClose = null;
            location.HoursSatOpen = null;
            location.HoursSunClose = null;
            location.HoursSunOpen = null;
            location.HoursThuClose = null;
            location.HoursThuOpen = null;
            location.HoursTueClose = null;
            location.HoursTueOpen = null;
            location.HoursWedClose = null;
            location.HoursWedOpen = null;
            location.InstallationType = null;
            location.Latitude = -20.9110M;
            location.LimitedTransactions = BooleanEnum.NULL;
            location.LocationId = "59bb3e88-9757-492e-a07c-b7efd3f316c3";
            location.locations = null;
            location.LocationType = LocationTypeEnum.A;
            location.Longitude = -84.8988M;
            location.MilitaryIdRequired = BooleanEnum.NULL;
            location.Name = null;
            location.OnMilitaryBase = BooleanEnum.NULL;
            location.OnPremise = BooleanEnum.NULL;
            location.Phone = "9997957521";
            location.PostalCode = "44646";
            location.RestrictedAccess = BooleanEnum.NULL;
            location.RetailOutlet = null;
            location.SelfServiceDevice = BooleanEnum.NULL;
            location.SelfServiceOnly = BooleanEnum.NULL;
            location.SoftDelete = null;
            location.State = StateEnum.OH;
            location.Surcharge = BooleanEnum.NULL;
            location.TakeCoopData = null;
            location.WebAddress = null;


            // Act
            var result = await backend.EditAsync(locationId);


            // Assert
            Assert.AreEqual(location.AcceptCash, result.AcceptCash);
            Assert.AreEqual(location.AcceptDeposit, result.AcceptDeposit);
            Assert.AreEqual(location.Access, result.Access);
            Assert.AreEqual(location.AccessNotes, result.AccessNotes);
            Assert.AreEqual(location.Address, result.Address);
            Assert.AreEqual(location.Cashless, result.Cashless);
            Assert.AreEqual(location.City, result.City);
            Assert.AreEqual(location.CoopLocationId, result.CoopLocationId);
            Assert.AreEqual(location.Country, result.Country);
            Assert.AreEqual(location.County, result.County);
            Assert.AreEqual(location.DriveThruOnly, result.DriveThruOnly);
            Assert.AreEqual(location.EnvelopeRequired, result.EnvelopeRequired);
            Assert.AreEqual(location.Fax, result.Fax);
            Assert.AreEqual(location.HandicapAccess, result.HandicapAccess);
            Assert.AreEqual(location.Hours, result.Hours);
            Assert.AreEqual(location.HoursDtfriClose, result.HoursDtfriClose);
            Assert.AreEqual(location.HoursDtfriOpen, result.HoursDtfriOpen);
            Assert.AreEqual(location.HoursDtmonClose, result.HoursDtmonClose);
            Assert.AreEqual(location.HoursDtmonOpen, result.HoursDtmonOpen);
            Assert.AreEqual(location.HoursDtsatClose, result.HoursDtsatClose);
            Assert.AreEqual(location.HoursDtsatOpen, result.HoursDtsatOpen);
            Assert.AreEqual(location.HoursDtsunClose, result.HoursDtsunClose);
            Assert.AreEqual(location.HoursDtsunOpen, result.HoursDtsunOpen);
            Assert.AreEqual(location.HoursDtthuClose, result.HoursDtthuClose);
            Assert.AreEqual(location.HoursDtthuOpen, result.HoursDttueOpen);
            Assert.AreEqual(location.HoursDttueClose, result.HoursDttueClose);
            Assert.AreEqual(location.HoursDttueOpen, result.HoursDttueOpen);
            Assert.AreEqual(location.HoursDtwedClose, result.HoursDtwedClose);
            Assert.AreEqual(location.HoursDtwedOpen, result.HoursDtwedOpen);
            Assert.AreEqual(location.HoursFriClose, result.HoursFriClose);
            Assert.AreEqual(location.HoursFriOpen, result.HoursFriOpen);
            Assert.AreEqual(location.HoursMonClose, result.HoursMonClose);
            Assert.AreEqual(location.HoursMonOpen, result.HoursMonOpen);
            Assert.AreEqual(location.HoursSatClose, result.HoursSatClose);
            Assert.AreEqual(location.HoursSatOpen, result.HoursSatOpen);
            Assert.AreEqual(location.HoursSunClose, result.HoursSunClose);
            Assert.AreEqual(location.HoursSunOpen, result.HoursSunOpen);
            Assert.AreEqual(location.HoursThuClose, result.HoursThuClose);
            Assert.AreEqual(location.HoursThuOpen, result.HoursThuOpen);
            Assert.AreEqual(location.HoursTueClose, result.HoursTueClose);
            Assert.AreEqual(location.HoursTueOpen, result.HoursTueOpen);
            Assert.AreEqual(location.HoursWedClose, result.HoursWedClose);
            Assert.AreEqual(location.HoursWedOpen, result.HoursWedOpen);
            Assert.AreEqual(location.InstallationType, result.InstallationType);
            Assert.AreEqual(location.Latitude, result.Latitude);
            Assert.AreEqual(location.LimitedTransactions, result.LimitedTransactions);
            Assert.AreEqual(location.LocationId, result.LocationId);
            Assert.AreEqual(location.locations, result.locations);
            Assert.AreEqual(location.LocationType, result.LocationType);
            Assert.AreEqual(location.Longitude, result.Longitude);
            Assert.AreEqual(location.MilitaryIdRequired, result.MilitaryIdRequired);
            Assert.AreEqual(location.Name, result.Name);
            Assert.AreEqual(location.OnMilitaryBase, result.OnMilitaryBase);
            Assert.AreEqual(location.OnPremise, result.OnPremise);
            Assert.AreEqual(location.Phone, result.Phone);
            Assert.AreEqual(location.PostalCode, result.PostalCode);
            Assert.AreEqual(location.RestrictedAccess, result.RestrictedAccess);
            Assert.AreEqual(location.RetailOutlet, result.RetailOutlet);
            Assert.AreEqual(location.SelfServiceDevice, result.SelfServiceDevice);
            Assert.AreEqual(location.SelfServiceOnly, result.SelfServiceOnly);
            Assert.AreEqual(location.SoftDelete, result.SoftDelete);
            Assert.AreEqual(location.State, result.State);
            Assert.AreEqual(location.Surcharge, result.Surcharge);
            Assert.AreEqual(location.TakeCoopData, result.TakeCoopData);
            Assert.AreEqual(location.WebAddress, result.WebAddress);
        }






        /// <summary>
        /// Tests Backend EditPostAsync method. The method should return NULL.
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_EditAsync_Invalid_Id_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            string locationId = "59bb3e88-9757-492e-a07c-00000000000";

            // Act
            var result = await backend.EditAsync(locationId);


            // Assert
            Assert.IsNull(result);
        }





        /// <summary>
        /// Tests Backend EditPostAsync method. The method should return NULL.
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_EditAsync_Null_Id_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);


            // Act
            var result = await backend.EditAsync(null);


            // Assert
            Assert.IsNull(result);
        }






        /// <summary>
        /// Tests Backend EditPostAsync method by editing a record that already exists in the 
        /// Database.
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_EditPostAsync_Should_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var id = "59bb3e88-9757-492e-a07c-b7efd3f316c3";


            var location = backend.GetLocation(id);
            var locationAsViewModel = new LocationsContactSpecialQualitiesViewModel();
            Locations locationAfterEdit;
            LocationsContactSpecialQualitiesViewModel locationAfterEditViewModel = new LocationsContactSpecialQualitiesViewModel();
            bool successfullyCreatedPostEditViewModel;


            var successfullyCreateViewModel = locationAsViewModel.InstatiateViewModelPropertiesWithOneLocation(location);


            // Act
            locationAsViewModel.City = "MY EDITED FIELD";
            bool result = await backend.EditPostAsync(locationAsViewModel);
            locationAfterEdit = backend.GetLocation(id);
            successfullyCreatedPostEditViewModel = locationAfterEditViewModel.InstatiateViewModelPropertiesWithOneLocation(locationAfterEdit);
            




            // Assert
            Assert.IsTrue(successfullyCreateViewModel);
            Assert.IsTrue(result);
            Assert.IsTrue(successfullyCreatedPostEditViewModel);
            Assert.AreEqual(locationAsViewModel.City, locationAfterEdit.City);
        }





        /// <summary>
        /// Tests Backend EditPostAsync method by editing a record that does not exist in
        /// the Database
        /// </summary>
        [TestMethod]
        public async Task LocationsContactSpecialQualitiesBackend_EditPostAsync_Null_Locations_Object_Should_Not_Pass_Async()
        {
            // Arrange
            var backend = new LocationsContactSpecialQualitiesBackend(DataSourceEnum.TEST);
            var id = "59bb3e88-9757-492e-a07c-b7efd3f316c3";


            var locationToEdit = backend.GetLocation(id);
            var locationToEditAsViewModel = new LocationsContactSpecialQualitiesViewModel();


            Locations locationAfterEdit;
            LocationsContactSpecialQualitiesViewModel locationAfterEditViewModel = new LocationsContactSpecialQualitiesViewModel();


            // EditPostAsync takes ViewModel object as parameter
            locationToEditAsViewModel.InstatiateViewModelPropertiesWithOneLocation(locationToEdit);


            // Act
            locationToEditAsViewModel.LocationId = "59bb3e88-9757-492e-a07c-NOT VALID ID";
            bool result = await backend.EditPostAsync(locationToEditAsViewModel); // Should be null as ID doesn't exist
            locationAfterEdit = backend.GetLocation(id); // Should be the same





            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(locationToEdit.LocationId, locationAfterEdit.LocationId);
        }
    }
}
