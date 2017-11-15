using System;
using System.Linq;
using FeatureApplication.ApplicationContext;
using FeatureApplication.Models;
using FeatureApplication.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FeatureApplication.Controllers {
    [Route ("api/Customers")]
    public class CustomersController : Controller {
        public ICustomerRepository _repository { get; }
        public CustomersController (ICustomerRepository repository) {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAction () {
            var getCustomers = _repository.GetAllCustomersData ();
            return Ok (getCustomers);
        }

        [HttpGet ("{Id}", Name = "GetCustomer")]
        public IActionResult GetAction (Guid Id) {
            var getCustomer = _repository.Get (Id);
            return Ok (getCustomer);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Customer entity) {
            //TODO: Implement Realistic Implementation
            if (!ModelState.IsValid) {
                return BadRequest ();
            }
            _repository.AddCustomer (entity);
            if (!_repository.Save ()) {
                return BadRequest ();
            }
            var getCurrenCreatedCustomer = _repository.Get (entity.CustomerId);
            return Created ("GetCustomer", new { customerId = getCurrenCreatedCustomer.CustomerId });
        }

        [HttpPut]
        public IActionResult Put ([FromBody] Customer entity) {
            //TODO: Implement Realistic Implementation
            return Ok ();
        }
    }
}