using Microsoft.AspNetCore.Mvc;
using DataShowing.Models;

namespace DataShowing.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index(List<customer> customerDetails)
        {
            return View(customerDetails);
        }

        public IActionResult Product(List<Products> productDetails)
        {
            return View(productDetails);
        }
    }
}
