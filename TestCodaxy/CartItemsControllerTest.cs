using CodaxyProject.Controllers;
using CodaxyProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCodaxy
{
    public class CartItemsControllerTest
    {
        [Theory]
        [InlineData(1111, false)]
        [InlineData(1, true)]
        public void GetCartItem(int id, Boolean temp)
        {
            var controller = new CartItemsController();
            Task<ActionResult<CartItem>> actionResult = controller.Get(id);
            if (temp == false)
            {
                var result = new NotFoundObjectResult(actionResult.Result);
                Assert.IsType<NotFoundObjectResult>(result);
            }
            else
            {
                var result = new OkObjectResult(actionResult.Result);
                Assert.IsType<OkObjectResult>(result);
            }

        }
    }
}
