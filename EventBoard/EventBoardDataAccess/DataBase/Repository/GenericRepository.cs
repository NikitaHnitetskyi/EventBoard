namespace EventBoardDataAccess.DataBase.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public RoleContext DbContext { get; set; }
        public void Add(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            DbContext.Set<T>().Remove(GetValue(id));
        }

        public T GetValue(int id)
        {
            return DbContext.Set<T>().Find(id);

        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }

        public void Update(T entity)
        {
            DbContext.Update(entity);
        }
    }
}
