using Microsoft.AspNetCore.Mvc;
using PetShop.Controllers;
using PetShop.Model;

namespace PetStore.Tests
{
    [TestClass]
    public class CatalogeControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var repository = new FakeRepository();
            var cataloge = new CatalogeController(repository);

            //Act
            var result = cataloge.Index() as ViewResult;

            //Assert

            Assert.AreEqual(typeof(List<Animal>), result!.Model!.GetType());
        }
    }
}
