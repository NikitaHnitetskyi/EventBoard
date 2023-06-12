namespace EventBoardDataAccess.DataBase.Repository
{
    public interface IRepository<T> where T : class
    {
        public EventBoardContext DbContext { get; set; }
        T GetValue(int id);
        public void Add(T entity);
        public void Delete(int id);
        public void Update(T entity);
        public IQueryable<T> GetAll();
    }
}
