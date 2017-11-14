using System.Collections.Generic;
using FeatureApplication.Models;

namespace FeatureApplication.Repositories.Interfaces {
    public interface ICustomerRepository : IRepository<Customer> {
        IEnumerable<Customer> GetTopActiveCustomers (int count);
        IEnumerable<Customer> GetAllCustomersData ();
    }
}