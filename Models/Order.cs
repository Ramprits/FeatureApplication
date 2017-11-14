using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeatureApplication.Models {
    public class Order : AuditableEntity {
        [Key]
        public Guid OrderId { get; set; }
        public decimal Discount { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string CashierId { get; set; }
        public ApplicationUser Cashier { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}