using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace adminconsoletest
{
    [TestClass]
    public class SpecialQualitiesModelTest
    {
        [TestMethod]
        public void SpecialQualitiesModel_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new SpecialQualitiesModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SpecialQualitiesModel_Get_Property_Defaults_Should_Pass()
        {
            // Arrange
            var result = new SpecialQualitiesModel();

            // Act

            // Assert
            Assert.IsNull(result.Location);
            Assert.IsNull(result.LocationId);
            Assert.IsNull(result.AcceptsCash);
            Assert.IsNull(result.AdditionalDetail);
            Assert.IsNull(result.Cashless);
            Assert.IsNull(result.DepositTaking);
            Assert.IsNull(result.HandicapAccess);
            Assert.IsNull(result.LimitedTransactions);
            Assert.IsNull(result.MilitaryIdrequired);
            Assert.IsNull(result.OnMilitaryBase);
            Assert.IsNull(result.RestrictedAccess);
            Assert.IsNull(result.SelfServiceOnly);
            Assert.IsNull(result.Surcharge);
        }

        [TestMethod]
        public void SpecialQualitiesModel_Set_Property_Should_Pass()
        {
            // Arrange
            var result = new SpecialQualitiesModel();

            // Act
            result.Location = new LocationsModel();
            result.LocationId = "location id";
            result.AcceptsCash = true;
            result.AdditionalDetail = "additional";
            result.Cashless = true;
            result.DepositTaking = true;
            result.HandicapAccess = true;
            result.LimitedTransactions = true;
            result.MilitaryIdrequired = true;
            result.OnMilitaryBase = true;
            result.RestrictedAccess = true;
            result.SelfServiceOnly = true;
            result.Surcharge = true;

            // Assert
            Assert.IsNotNull(result.Location);
            Assert.AreEqual("location id", result.LocationId);
            Assert.AreEqual(true, result.AcceptsCash);
            Assert.AreEqual("additional", result.AdditionalDetail);
            Assert.AreEqual(true, result.Cashless);
            Assert.AreEqual(true, result.DepositTaking);
            Assert.AreEqual(true, result.HandicapAccess);
            Assert.AreEqual(true, result.LimitedTransactions);
            Assert.AreEqual(true, result.MilitaryIdrequired);
            Assert.AreEqual(true, result.OnMilitaryBase);
            Assert.AreEqual(true, result.RestrictedAccess);
            Assert.AreEqual(true, result.SelfServiceOnly);
            Assert.AreEqual(true, result.Surcharge);
        }
    }
}
