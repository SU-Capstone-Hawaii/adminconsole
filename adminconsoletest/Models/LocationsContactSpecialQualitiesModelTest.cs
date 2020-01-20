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
            Assert.IsNull(result.City);
            Assert.IsNull(result.contacts);
            Assert.IsNull(result.Hours);
            Assert.IsNull(result.InstitutionName);
            Assert.AreEqual(0.0M, result.Lat);
            Assert.IsNull(result.locations);
            Assert.IsNull(result.LocationId);
            Assert.AreEqual(0.0M, result.Long);
            Assert.IsNull(result.RetailOutlet);
            Assert.IsNull(result.specialQualities);
            Assert.IsNull(result.State);
            Assert.IsNull(result.Street);
            Assert.IsNull(result.TypeName);
            Assert.IsNull(result.Zipcode);

            // Contacts
            Assert.IsNull(result.Phone);
            Assert.IsNull(result.Fax);
            Assert.IsNull(result.Terminal);

            // Special Qualities
            Assert.IsNull(result.AcceptsCash);
            Assert.IsNull(result.AdditionalDetail);
            Assert.IsNull(result.Cashless);
            Assert.IsNull(result.DepositTaking);
            Assert.IsNull(result.HandicapAccess);
            Assert.IsNull(result.LimitedTransactions);
            Assert.IsNull(result.MilitaryIdRequired);
            Assert.IsNull(result.OnMilitaryBase);
            Assert.IsNull(result.RestrictedAccess);
            Assert.IsNull(result.SelfServiceOnly);
            Assert.IsNull(result.Surcharge);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new LocationsContactSpecialQualitiesViewModel();

            // Act
            // Locations
            result.City = "city";
            result.contacts = new List<Contact>();
            result.Hours = "hours";
            result.InstitutionName = "institution";
            result.Lat = 45.555M;
            result.LocationId = "locationid";
            result.Long = 45.555M;
            result.RetailOutlet = "retail";
            result.specialQualities = new List<SpecialQualities>();
            result.State = StateEnum.AB;
            result.Street = "street";
            result.TypeName = "atm";
            result.Zipcode = "zip";

            // Contacts
            result.Phone = "phone";
            result.Fax = "fax";
            result.Terminal = "terminal";

            // SpecialQualities
            result.locations = new List<Locations>();
            result.AcceptsCash = BooleanEnum.N;
            result.AdditionalDetail = "additional";
            result.Cashless = BooleanEnum.N;
            result.DepositTaking = BooleanEnum.N;
            result.HandicapAccess = BooleanEnum.N;
            result.LimitedTransactions = BooleanEnum.Y;
            result.MilitaryIdRequired = BooleanEnum.Y;
            result.OnMilitaryBase = BooleanEnum.Y;
            result.RestrictedAccess = BooleanEnum.Y;
            result.SelfServiceOnly = BooleanEnum.Y;
            result.Surcharge = BooleanEnum.NULL;

            // Assert
            // Locations
            Assert.IsNotNull(result.contacts);
            Assert.IsNotNull(result.specialQualities);
            Assert.AreEqual("locationid", result.LocationId);
            Assert.AreEqual("city", result.City);
            Assert.AreEqual("hours", result.Hours);
            Assert.AreEqual("institution", result.InstitutionName);
            Assert.AreEqual(45.555M, result.Lat);
            Assert.AreEqual("locationid", result.LocationId);
            Assert.AreEqual(45.555M, result.Long);
            Assert.AreEqual("retail", result.RetailOutlet);
            Assert.AreEqual(StateEnum.AB, result.State);
            Assert.AreEqual("street", result.Street);
            Assert.AreEqual("atm", result.TypeName);
            Assert.AreEqual("zip", result.Zipcode);

            // Contacts
            Assert.AreEqual("phone", result.Phone);
            Assert.AreEqual("fax", result.Fax);
            Assert.AreEqual("terminal", result.Terminal);

            // SpecialQualities
            Assert.IsNotNull(result.locations);            
            Assert.AreEqual(BooleanEnum.N, result.AcceptsCash);
            Assert.AreEqual("additional", result.AdditionalDetail);
            Assert.AreEqual(BooleanEnum.N, result.Cashless);
            Assert.AreEqual(BooleanEnum.N, result.DepositTaking);
            Assert.AreEqual(BooleanEnum.N, result.HandicapAccess);
            Assert.AreEqual(BooleanEnum.Y, result.LimitedTransactions);
            Assert.AreEqual(BooleanEnum.Y, result.MilitaryIdRequired);
            Assert.AreEqual(BooleanEnum.Y, result.OnMilitaryBase);
            Assert.AreEqual(BooleanEnum.Y, result.RestrictedAccess);
            Assert.AreEqual(BooleanEnum.Y, result.SelfServiceOnly);
            Assert.AreEqual(BooleanEnum.NULL, result.Surcharge);
        }

        [TestMethod]
        public void LocationsContactSpecialQualitiesViewModel_Index_Should_Pass()
        {
          
        }
    }
}
