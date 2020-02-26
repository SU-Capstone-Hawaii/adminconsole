using adminconsole.Backend;
using adminconsole.Controllers;
using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace adminconsoletest
{
    [TestClass]
    public class LocationsControllerTest
    {


        MaphawksContext context = (new Mock<MaphawksContext>()).Object;


        #region IndexTests
        /// <summary>
        /// Ensure the Default Index page on the controller returns and is not null
        /// </summary>
        [TestMethod]
        public void LocationsController_Index_Get_Default_Should_Pass()
        {
            // Arrange
            var dataMock = new LocationsDataMock();
            var backendMock = new Mock<LocationsBackend>(context);

            backendMock.Setup(backend => backend.IndexAsync(false)).Returns(Task.FromResult(dataMock.GetAllViewModelList()));
            var myController = new LocationsController(context, backendMock.Object);


            // Act
            var result = myController.Index();


            // Assert
            Assert.IsNotNull(result);
        }
        #endregion IndexTests
    }
}
