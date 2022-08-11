namespace ExcellentProtectionTaskAPI.Repositories
{
    public interface IRepository<T>
    {
        public ICollection<T> GetAll();
        public int Create(T entity);
    }
}
