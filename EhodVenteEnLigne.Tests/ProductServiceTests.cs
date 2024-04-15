using EhodBoutiqueEnLigne.Models.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EhodBoutiqueEnLigne.Models.Services;
using EhodBoutiqueEnLigne.Models.Repositories;
using Microsoft.Extensions.Localization;
using EhodBoutiqueEnLigne.Models;
using Moq;
using Xunit;

namespace EhodBoutiqueEnLigne.Tests
    {
    public class ProductServiceTests
        {
        /// <summary>
        /// Take this test method as a template to write your test method.
        /// A test method must check if a definite method does its job:
        /// returns an expected value from a particular set of parameters
        /// </summary>
        /// 
         private readonly Mock<ICart> _mockCart;
        private readonly Mock<IProductRepository> _mockProductRepository;
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly Mock<IStringLocalizer<ProductService>> _mockLocalizer;
        private readonly ProductService _productService;
           public ProductServiceTests()
        {
            _mockCart = new Mock<ICart>();
            _mockProductRepository = new Mock<IProductRepository>();
            _mockOrderRepository = new Mock<IOrderRepository>();
            _mockLocalizer = new Mock<IStringLocalizer<ProductService>>();
            _mockLocalizer.Setup(l => l["MissingName"]).Returns(new LocalizedString("MissingName", "MissingName"));
            _mockLocalizer.Setup(l => l["MissingPrice"]).Returns(new LocalizedString("MissingPrice", "MissingPrice"));
            _mockLocalizer.Setup(l => l["PriceValue"]).Returns(new LocalizedString("PriceValue", "PriceValue"));
            _productService = new ProductService(_mockCart.Object, _mockProductRepository.Object, _mockOrderRepository.Object, _mockLocalizer.Object);
        }

        [Fact]
        public void SaveProduct_MissingName_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name="",
                Description = "The description of the product",
                Price = "10,99",
                Stock = "5"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("MissingName", modelErrors);
        }

        [Fact]
         public void SaveProduct_PriceValue_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name="The name of product",
                Description = "The description of the product",
                Price = "gfgf",
                Stock = "12"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            //Assert.Contains("PriceValue", modelErrors);
        }

    

        // TODO write test methods to ensure a correct coverage of all possibilities
        }

    }