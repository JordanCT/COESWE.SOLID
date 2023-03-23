namespace COESWE.SOLID.IMP.Repositorio
{
    public interface IAction<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
