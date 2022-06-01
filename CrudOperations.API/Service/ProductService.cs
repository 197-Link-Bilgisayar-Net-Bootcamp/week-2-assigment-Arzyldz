using CrudOperations.API.Models;
using CrudOperations.API.Repository;

namespace CrudOperations.API.Service
{
    public class ProductService : CrudService<Product>
    {
        public ProductService(IRepository<Product> iRepo) : base(iRepo)
        {
        }
    }
}
