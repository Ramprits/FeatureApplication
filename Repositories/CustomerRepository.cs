using System.Collections.Generic;
using FeatureApplication.Models;
using FeatureApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FeatureApplication.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetAllCustomersData()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetTopActiveCustomers(int count)
        {
            throw new System.NotImplementedException();
        }
    }
}