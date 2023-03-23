using COESWE.SOLID.IMP.Repositorio;

namespace COESWE.SOLID.IMP.Application
{
    public class ClienteActionService : IClienteActionService
    {
        private readonly IRepositoryActionCliente _repositoryActionCliente;
        public ClienteActionService(IRepositoryActionCliente repositoryActionCliente)
        {
            _repositoryActionCliente = repositoryActionCliente;
        }

        public void Guardar(Cliente cliente)
        {
            _repositoryActionCliente.Add(cliente);
            _repositoryActionCliente.Save();
        }
    }
}
