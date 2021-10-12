using CodaxyProject.Config;
using CodaxyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodaxyProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        CodaxyDBContext context = new CodaxyDBContext();
        [HttpGet("{id}")]
        public async Task<ActionResult<CartItem>> Get(int id)
        {

            var cartItem = await context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return BadRequest();
            }
            return Ok(cartItem);

        }

    }
}
