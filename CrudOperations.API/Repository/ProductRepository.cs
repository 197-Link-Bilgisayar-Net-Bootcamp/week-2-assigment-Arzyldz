using CrudOperations.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.API.Repository
{
    public class ProductRepository : Repository<Product>
    {
        private readonly MyDataContext _dbContext;

        public ProductRepository(MyDataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
       
    }
}
