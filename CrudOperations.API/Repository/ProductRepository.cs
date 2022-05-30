using CrudOperations.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.API.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(MyDataContext dbContext) : base(dbContext)
        {
        }
      
        //public async void Add(Product entity)
        //{
        //    if (entity.ID > 0)
        //    {
        //        _dbSet.Attach(entity);
        //        _dbContext.Entry(entity).State = EntityState.Modified;
        //        _dbContext.SaveChanges();
        //    }
        //    else
        //    {
        //        _dbContext.Entry(entity).State = EntityState.Added;
        //        //_dbSet.Add(entity);
        //        _dbContext.SaveChanges();
        //    }
        //}


    }
}
