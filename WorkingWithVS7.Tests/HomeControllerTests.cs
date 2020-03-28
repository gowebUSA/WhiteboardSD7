using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVS7.Controllers;
using WorkingWithVS7.Models;
using Xunit;
namespace WorkingWithVS7.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Product>;
            // Assert
            Assert.Equal(SimpleRepository.SharedRepository.Products, model,
            Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
            && p1.Price == p2.Price));
        }
    }
}
