using adminconsole.Backend;
using adminconsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminconsoletest
{
    [TestClass]
    public class DatabaseHelperTest
    {

        LocationsDataMock mockData = new LocationsDataMock();
        MaphawksContext mockContext = new MaphawksContext();

        /// <summary>
        /// Test DatabaseHelper Constructor
        /// </summary>
        [TestMethod]
        public void DatabaseHelper_Constructor_Should_Pass()
        {
            // Arrange
            var mock = new Mock<MaphawksContext>();

            
            // Act
            var db = new DatabaseHelper(mock.Object);



            // Assert
            Assert.IsNotNull(db);
        }





        [TestMethod]
        public void DatabaseHelper_ReadOneRecordAsync_Should_Pass()
        {
            // Arrange
            var id = "a91be80e-ed05-4157-bb95-aa3494663d2a";

            List<KeyValuePair<string, string>> whereClause = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> idPair = new KeyValuePair<string, string>("LocationId", id);
            whereClause.Add(idPair);

            var mock = new Mock<MaphawksContext>();




            var locationList = new List<Locations>() { mockData.GetOneLocation(whereClause) }.AsQueryable();

            mock.Setup(context => context.Locations).Returns(mockDbSet.Object);
            var db = new DatabaseHelper(mock.Object);


            // Act
            var result = db.ReadOneRecordAsync(id);



            // Assert
            Assert.IsNotNull(db);
        }
    }
}
