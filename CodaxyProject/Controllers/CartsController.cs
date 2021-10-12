using CodaxyProject.Config;
using CodaxyProject.Enumerations;
using CodaxyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodaxyProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        CodaxyDBContext context = new CodaxyDBContext();
        public CartsController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpGet]
        public ActionResult<List<dynamic>> Get()
        {

            var carts = context.Carts.Select(carts => new
            {
                Id = carts.Id,
                Status = carts.Status,
                TimeCreated = carts.TimeCreated,
                TimeUpdated = carts.TimeUpdated,
                CartItems = carts.CartItems.Select(cartitems => new
                {
                    Id = cartitems.Id,
                    name = cartitems.Name
                })
            }).ToList<dynamic>();

            return Ok(carts);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> Get(int id)
        {


            Cart cart = await context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            var items = context.CartItems.Where(cartItem => cartItem.CartId == id).ToList();
            foreach (var i in items)
            {
                cart.CartItems.Add(i);
            }
            return Ok(cart);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cart>> Delete(long id)
        {

            var cart = await context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            context.Carts.Remove(cart);
            await context.SaveChangesAsync();

            return Ok();

        }
        [HttpPost("submitCart/{id}")]
        public async Task<ActionResult<Cart>> SubmitCart(int id)
        {

            var temp = await context.Carts.FindAsync(id);
            if (temp == null)
            {
                return BadRequest();
            }
            temp.Status = StatusEnum.Submitted;
            temp.TimeUpdated = DateTime.Now;
            await context.SaveChangesAsync();
            return Ok();

        }
        [HttpPost("cancelCart/{id}")]
        public async Task<ActionResult<Cart>> CancelCart(int id)
        {

            var temp = await context.Carts.FindAsync(id);
            if (temp == null)
            {
                return BadRequest();
            }
            temp.Status = StatusEnum.Cancelled;
            temp.TimeUpdated = DateTime.Now;
            await context.SaveChangesAsync();
            return Ok();

        }
        [HttpPost("addCartItem/{idCarta}")]
        public async Task<ActionResult<Cart>> AddCartItemInCart(int idCarta, CartItem ci)
        {

            var temp = await context.Carts.FindAsync(idCarta);

            if (temp == null)
            {
                return BadRequest();
            }
            ci.CartId = idCarta;
            ci.TimeCreated = DateTime.Now;
            ci.TimeUpdated = DateTime.Now;
            context.CartItems.Add(ci);
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("deleteCartItem/{id}")]
        public async Task<ActionResult<Cart>> DeleteCartItemFromCart(int id)
        {

            var temp = await context.CartItems.FindAsync(id);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                context.CartItems.Remove(temp);
                context.SaveChanges();
                return Ok();
            }


        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {

            var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }

}
