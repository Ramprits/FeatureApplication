using System.Linq;
using FeatureApplication.ApplicationContext;
using Microsoft.AspNetCore.Mvc;

namespace FeatureApplication.Controllers {
    [Route ("api/Customers")]
    public class CustomersController : Controller {
        public ApplicationDbContext _repository { get; }
        public CustomersController (ApplicationDbContext repository) {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAction () {
            var getCustomers = _repository.Customers.ToList ();
            return Ok (getCustomers);
        }
    }
}