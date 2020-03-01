using Microsoft.AspNetCore.Mvc;
using CartStateMachine.Order;

namespace CartStateMachine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICart _cart;

        public CartController(ICart cart)
        {
            _cart = cart;
        }

        [HttpGet("new")]
        public string NewCart()
        {
            _cart.State.EmptyCart();
            return _cart.Id;
        }

        [HttpGet("checkout")]
        public string Checkout()
        {
            _cart.State.Checkout();
            return _cart.Id;
        }
    }
}
