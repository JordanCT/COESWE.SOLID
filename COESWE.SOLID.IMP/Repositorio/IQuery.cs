namespace COESWE.SOLID.IMP.Repositorio
{
    public interface IQuery<T>
    {
        T Get(Guid id);
        List<T> GetAll();
    }
}
