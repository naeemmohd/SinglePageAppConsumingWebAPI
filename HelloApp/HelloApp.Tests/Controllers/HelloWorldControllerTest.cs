using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloApp;
using HelloApp.Controllers;
using HelloApp.Patterns.Interfaces;
using HelloApp.Patterns.Implementations;

namespace HelloApp.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void SuccessTest()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            ActionResult result = controller.GetHelloWorld() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("This is success data.", ((System.Web.Mvc.JsonResult)result).Data.ToString());
        }

        [TestMethod]
        public void FailTest()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            ActionResult result = controller.GetHelloWorld() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual("This is error data.", ((System.Web.Mvc.JsonResult)result).Data.ToString());
        }
    }
}
