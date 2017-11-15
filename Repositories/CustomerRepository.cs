using System;
using System.Collections.Generic;
using System.Linq;
using FeatureApplication.ApplicationContext;
using FeatureApplication.Models;
using FeatureApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FeatureApplication.Repositories {
    public class CustomerRepository : Repository<Customer>, ICustomerRepository {
        public CustomerRepository (ApplicationDbContext context) : base (context) { }

        public IEnumerable<Customer> GetAllCustomersData () {
            return _context.Customers.ToList ();
        }

        public void AddCustomer (Customer entity) {
            entity.CustomerId = Guid.NewGuid ();
            _context.Customers.Add (entity);
        }

        public bool Save () {
            return (_context.SaveChanges () >= 0);
        }
    }
}