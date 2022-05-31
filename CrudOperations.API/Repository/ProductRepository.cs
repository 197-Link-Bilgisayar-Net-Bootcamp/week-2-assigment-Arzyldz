using CrudOperations.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.API.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(MyDataContext dbContext) : base(dbContext)
        {
        }
    }
}
