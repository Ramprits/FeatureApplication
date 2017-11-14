using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeatureApplication.Models {
    public class ProductCategory : AuditableEntity {
        [Key]
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}