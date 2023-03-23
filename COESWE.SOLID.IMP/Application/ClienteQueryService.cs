using COESWE.SOLID.IMP.Repositorio;

namespace COESWE.SOLID.IMP.Application
{
    public class ClienteQueryService : IClienteQueryService
    {
        private readonly IRepositoryQueryCliente _repositoryQueryCliente;
        public ClienteQueryService(IRepositoryQueryCliente repositoryQueryCliente)
        {
            _repositoryQueryCliente = repositoryQueryCliente;
        }

        public int TotalClientes()
        {
            return _repositoryQueryCliente.GetAll().Count;
        }
    }
}
