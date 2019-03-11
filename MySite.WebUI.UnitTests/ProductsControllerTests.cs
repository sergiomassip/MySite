using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;

namespace MySite.WebUI.UnitTests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
                    mock.Setup(m => m.Products).Returns(new Product[] {
                    new Product {Id = 1, Name = "P1"},
                    new Product {Id = 2, Name = "P2"},
                    new Product {Id = 3, Name = "P3"},
                    new Product {Id = 4, Name = "P4"},
                    new Product {Id = 5, Name = "P5"}
            });


            // Act (attempt the operation)     

            // Assert (verify the result)
        }
    }
}
