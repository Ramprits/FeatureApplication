using System;

namespace FeatureApplication.Models.Interface {
    public interface IAuditableEntity {
        // string CreatedBy { get; set; }
        // string UpdatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        // DateTime UpdatedDate { get; set; }
    }
}