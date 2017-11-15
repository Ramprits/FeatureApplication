using System;
using System.Collections.Generic;
using FeatureApplication.Models;

namespace FeatureApplication.Repositories.Interfaces {
    public interface ICustomerRepository : IRepository<Customer> {
        IEnumerable<Customer> GetAllCustomersData ();
        void AddCustomer (Customer entity);
        bool Save();
    }
}