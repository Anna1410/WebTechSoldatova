using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTechSoldatova.Extensions;
using WebTechSoldatova.Models;

namespace WebTechSoldatova.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
