﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVS7.Tests;
using WorkingWithVS7.Controllers;
using WorkingWithVS7.Models;
using Xunit;
using Moq;

namespace WorkingWithVS7.Tests
{
    public class HomeControllerTests
    {
        class ModelCompleteFakeRepository : IRepository                             //Page 178
        {
            public IEnumerable<Product> Products { get; set; }                      //Page 182
            //public IEnumerable<Product> Products { get; } = new Product[]         //Comment put Page 182.
            //{
            //    new Product { Name = "P1", Price = 275M },
            //    new Product { Name = "P2", Price = 48.95M },
            //    new Product { Name = "P3", Price = 19.50M },
            //    new Product { Name = "P3", Price = 34.95M }
            //};
            public void AddProduct(Product p)
            {
                // do nothing - not required for test
            }
        }
        [Theory]
        [ClassData(typeof(ProductTestData))]                            //Page 185
        public void IndexActionModelIsComplete(Product[] products)
        {
            //[InlineData(275, 48.95, 19.50, 24.95)]                        //Comment out Page 185
            //[InlineData(5, 48.95, 19.50, 24.95)]
            //public void IndexActionModelIsComplete(decimal price1, decimal price2,
            //    decimal price3, decimal price4)
            //{
            //-----------------------------------------------------------------------
            //[Fact]                                        //Comment out Page 182
            //public void IndexActionModelIsComplete()
            //{
            //-----------------------------------------------------------------------
            // Arrange
            var mock = new Mock<IRepository>();                                     //Page 189
            mock.SetupGet(m => m.Products).Returns(products);
            var controller = new HomeController { Repository = mock.Object };
            //var controller = new HomeController();                               //Comment out Page 189
            ////controller.Repository = new ModelCompleteFakeRepository();       //Page 178   //Comment out Page 183
            //controller.Repository = new ModelCompleteFakeRepository             //Page 183
            //{
            //    Products = products                                             //Page 185
            //    //Products = new Product[] {                                    //Comment out Page 185
            //    //new Product {Name = "P1", Price = price1 },
            //    //new Product {Name = "P2", Price = price2 },
            //    //new Product {Name = "P3", Price = price3 },
            //    //new Product {Name = "P4", Price = price4 },
            //    //}
            //    //-----------------------------------------------------------------------
            //};
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Product>;
            // Assert
            Assert.Equal(controller.Repository.Products, model,                     //Page 178
            //Assert.Equal(SimpleRepository.SharedRepository.Products, model,       //Comment out Page 178.
            Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
            && p1.Price == p2.Price));
        }
        class PropertyOnceFakeRepository : IRepository
        {
            public int PropertyCounter { get; set; } = 0;
            public IEnumerable<Product> Products
            {
                get
                {
                    PropertyCounter++;
                    return new[] { new Product { Name = "P1", Price = 100 } };
                }
            }
            public void AddProduct(Product p)
            {
                // do nothing - not required for test
            }
        }
        [Fact]
        public void RepositoryPropertyCalledOnce()
        {
            // Arrange
            var mock = new Mock<IRepository>();                                 //Page 189
            mock.SetupGet(m => m.Products)
            .Returns(new[] { new Product { Name = "P1", Price = 100 } });
            var controller = new HomeController { Repository = mock.Object };
            //var repo = new PropertyOnceFakeRepository();                  //Comment out Page 189
            //var controller = new HomeController { Repository = repo };
            // Act
            var result = controller.Index();
            // Assert
            mock.VerifyGet(m => m.Products, Times.Once);                        //Page 189
            //Assert.Equal(1, repo.PropertyCounter);                            //Comment out Page 189
        }
    }

    //-----------------------------------------------------------Start Page 179-----------Comment out Page 187-------------------------
    //class ModelCompleteFakeRepositoryPricesUnder50 : IRepository
    //{
    //    public IEnumerable<Product> Products { get; } = new Product[] {
    //        new Product { Name = "P1", Price = 5M },
    //        new Product { Name = "P2", Price = 48.95M },
    //        new Product { Name = "P3", Price = 19.50M },
    //        new Product { Name = "P3", Price = 34.95M }};
    //    public void AddProduct(Product p)
    //    {
    //        // do nothing - not required for test
    //    }
    //}
    //[Fact]
    //public void IndexActionModelIsCompletePricesUnder50()
    //{
    //    // Arrange
    //    var controller = new HomeController();
    //    controller.Repository = new ModelCompleteFakeRepositoryPricesUnder50();
    //    // Act
    //    var model = (controller.Index() as ViewResult)?.ViewData.Model
    //    as IEnumerable<Product>;
    //    // Assert
    //    Assert.Equal(controller.Repository.Products, model,
    //    Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
    //    && p1.Price == p2.Price));
    //}
    //--------------------------------------------------------------------End-----------------------------
}
