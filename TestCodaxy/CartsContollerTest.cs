using CodaxyProject.Controllers;
using CodaxyProject.Models;
using CodaxyProject.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CodaxyProject;

namespace TestCodaxy
{
    public class CartsContollerTest
    {
        
        
        [Theory]
        [InlineData(1111, true)]
        [InlineData(1, false)]
        public void SubmitCartTest(int id,Boolean temp) 
        {
            String key = "";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            Task<ActionResult<Cart>> actionResult = controller.SubmitCart(id);
            if (temp == false)
            {
                var result = new BadRequestObjectResult(actionResult.Result);
                Assert.IsType<BadRequestObjectResult>(result);
            }
            else
            {
                var result = new OkObjectResult(actionResult.Result);
                Assert.IsType<OkObjectResult>(result);
            }
        }

        [Theory]
        [InlineData(1111, true)]
        [InlineData(1, false)]
        public void CancelCartTest(int id, Boolean temp)
        {
            String key = "";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            Task<ActionResult<Cart>> actionResult = controller.CancelCart(id);
            if (temp == false)
            {
                var result = new BadRequestObjectResult(actionResult.Result);
                Assert.IsType<BadRequestObjectResult>(result);
            }
            else
            {
                var result = new OkObjectResult(actionResult.Result);
                Assert.IsType<OkObjectResult>(result);
            }
        }

        [Theory]
        [InlineData(1111, false)]
        [InlineData(12, true)]
        public void DeleteCartItemFromCartTest(int id, Boolean temp) 
        {
            String key = "";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            if (temp == false)
            {
                Task<ActionResult<Cart>> actionResult = controller.DeleteCartItemFromCart(id);
                var result = new BadRequestObjectResult(actionResult.Result);
                Assert.IsType<BadRequestObjectResult>(result);
            }
            else
            {
                Task<ActionResult<Cart>> actionResult = controller.DeleteCartItemFromCart(id);
                var result = new OkObjectResult(actionResult.Result);
                Assert.IsType<OkObjectResult>(result);
            }
        }
        [Theory]
        [InlineData(1111, false)]
        [InlineData(1, true)]
        public void AddCartItemInCartTest(int id, Boolean temp) 
        {
            String key = "";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            CartItem item =new CartItem
            {
                
                CartId = id,
                Name = "cokolada",
                Description = "sa ljesnjakom",
                TimeCreated = DateTime.Now,
                TimeUpdated = DateTime.Now,
                CreatedBy = "Pero Budak"
            };
            
            if (temp == false)
            {
                Task<ActionResult<Cart>> actionResult = controller.AddCartItemInCart(id, item);
                var result = new BadRequestObjectResult(actionResult.Result);
                Assert.IsType<BadRequestObjectResult>(result);
            }
            else
            {
                Task<ActionResult<Cart>> actionResult = controller.AddCartItemInCart(id, item);
                var result = new OkObjectResult(actionResult.Result);
                Assert.IsType<OkObjectResult>(result);
            }
        }
        [Fact]
        public void GetTest() 
        {
            String key = "";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            ActionResult<dynamic> actionResult = controller.Get();
            var result = new OkObjectResult(actionResult.Result);          
            Assert.IsType<OkObjectResult>(result);
        }
        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Authenticate(Boolean opcija) 
        {
            String key="ewrwrwqrqwrqwrewqrqwrqwrqwerqwrqwrwrwrw2rfddsfdggfdgdsggsdfgsgfasda";
            IJwtAuthenticationManager jwtAuthenticationManager = new JwtAuthenticationManager(key);
            var controller = new CartsController(jwtAuthenticationManager);
            if (opcija == true)
            {
                UserCred userCred = new UserCred
                {
                    Username = "test1",
                    Password = "password1"
                };
                IActionResult actionResult = controller.Authenticate(userCred);
                var result = new OkObjectResult(actionResult);          
                Assert.IsType<OkObjectResult>(result);
            }
            else
            {
                UserCred userCred = new UserCred
                {
                    Username = "greska",
                    Password = "greska"
                };
                IActionResult actionResult = controller.Authenticate(userCred);
                var result = new UnauthorizedObjectResult(actionResult);
                Assert.IsType<UnauthorizedObjectResult>(result);
            }
            
        }
    }
}
