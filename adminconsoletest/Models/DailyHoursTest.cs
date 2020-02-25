using adminconsole.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace adminconsoletest
{
    [TestClass]
    public class DailyHoursTest
    {

        // Tests default instantiation of DailyHours
        [TestMethod]
        public void DailyHours_Default_Should_Pass()
        {
            // Arrange
            var result = new DailyHours();

            // Act


            //Assert
            Assert.IsNotNull(result);   // DailyHours object exists

            PropertyInfo[] properties = typeof(DailyHours).GetProperties(); // All properties of DailyHours is null by default
            foreach (PropertyInfo property in properties)
            {
                var actual = property.GetValue(result);
                Assert.IsNull(actual);
            }
        }
    }
}
