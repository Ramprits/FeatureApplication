using System;
using FeatureApplication.Models.Interface;

namespace FeatureApplication.Models {
    public class AuditableEntity : IAuditableEntity {
        // public string CreatedBy { get; set; }
        // public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        // public DateTime UpdatedDate { get; set; }
    }
}