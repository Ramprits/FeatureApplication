using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FeatureApplication.Core;

namespace FeatureApplication.Models {
    public class Customer : AuditableEntity {
        [Key]
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}