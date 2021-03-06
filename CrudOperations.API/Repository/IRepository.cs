namespace CrudOperations.API.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Edit(TEntity entity);
        Task Del(int id);
        Task SaveChangesAsync();
    }

}
