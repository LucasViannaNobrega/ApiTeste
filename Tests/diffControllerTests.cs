using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLucas.Controllers;
using ApiLucas.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace blog.tests.Controllers
{
    public class diffControllerTests
    {
        private diffController _diffController; // Arrange

        /* 
        [Fact]
        public async Task Post_BadRequest()
        {
           var control = _diffController;
            control.ModelState.SetModelValue("a", new Object(), "a");

            // Act
            var result = await control.Post(new Right());

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            
        }

       [Fact]
        public async Task Right_Create()
        {
            // Arrange
            
            var Right = new Right
            {
                Id = 1,
                Valor = "aaa",
            };

            // Act
            var result = await _diffController.Right(Right);

            // Assert
            Assert.NotNull(result);

            var objectResult = result as CreatedResult;
            
            Assert.NotNull(objectResult);
            
        }

        [Fact]
        public async Task Left_Create()
        {
            // Arrange
            
            var Left = new Left
            {
                Id = 1,
                Valor = "aaa",
            };

            // Act
            var result = await _diffController.Left(Left);

            // Assert
            Assert.NotNull(result);

            var objectResult = result as CreatedResult;
            
            Assert.NotNull(objectResult);
            
        }*/
    }
}
