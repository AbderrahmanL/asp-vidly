using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        public ActionResult Customers()
        {
            var customer1 = new Customer() {Name = "Emilie"};
            var customer2 = new Customer() {Name = "Emilio"};
            CustomerViewModel customersVM =
                new CustomerViewModel() {Customers = new List<Customer>() {customer1, customer2}};
            return View(customersVM);
        }
    }
}