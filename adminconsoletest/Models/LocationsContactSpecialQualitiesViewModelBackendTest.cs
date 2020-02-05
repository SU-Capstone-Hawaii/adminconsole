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
        /// <returns></returns>
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
    }
}
