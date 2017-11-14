using FeatureApplication.Repositories.Interfaces;

namespace FeatureApplication.Services {
    public interface IUnitOfWork {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        IOrdersRepository Orders { get; }

        int SaveChanges ();
    }
}