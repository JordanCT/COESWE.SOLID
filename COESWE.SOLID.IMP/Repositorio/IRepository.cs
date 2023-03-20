namespace COESWE.SOLID.IMP.Repositorio
{
    public interface IRepository<T>
    {
        T Get(Guid id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();

    }
}
