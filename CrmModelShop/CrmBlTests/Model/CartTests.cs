using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            // arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "TestUser"
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };
            var cart = new Cart(customer);
            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };

            // act
            cart.AddProduct(product1);
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            var cartResult = cart.GetAll();

            // assert
            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; i++)
                Assert.AreEqual(expectedResult[i], cartResult[i]);
        }
    }
}