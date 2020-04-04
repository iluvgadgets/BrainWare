using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web;
using Web.Controllers;

namespace Tests.Controllers
{
    [TestClass]
    public class CompaniesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            CompaniesController controller = new CompaniesController();

            // act
            var result = controller.GetCompanies();

            // assert
            Assert.IsNotNull(result);
            // given the time i would setup mocking of entity framework
        }


    }

}
