using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace adminconsoletest
{
    [TestClass]
    public class ErrorViewModelTest
    {
        [TestMethod]
        public void ErrorViewModelTest_Default_Should_Pass()
        {
            // Arrange
            var errorViewModel = new ErrorViewModel();

            // Act

            // Assert
            Assert.IsNull(errorViewModel.RequestId);
            Assert.IsFalse(errorViewModel.ShowRequestId);
        }
    }
}
