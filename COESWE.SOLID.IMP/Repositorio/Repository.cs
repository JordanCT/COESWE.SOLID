using Newtonsoft.Json;

namespace COESWE.SOLID.IMP.Repositorio
{
    public class RepositoryCliente : IRepository<Cliente>
    {
        private readonly List<Cliente> _listaCliente;
        private readonly StreamWriter _writer;
        public RepositoryCliente(string conexion)
        {
            _writer = new StreamWriter(conexion);
            _listaCliente = new List<Cliente>();
        }
        public void Add(Cliente entity)
        {
            _listaCliente.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            _listaCliente.Remove(entity);
        }

        public void Update(Cliente entity)
        {
            _listaCliente[_listaCliente.FindIndex(x => x.ClienteId == entity.ClienteId)] = entity;
        }

        public Cliente Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            using (_writer)
            {
                string jsonresult = JsonConvert.SerializeObject(_listaCliente, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Objects
                });
                _writer.WriteLine(jsonresult.ToString());
                _writer.Close();
            }
        }
    }
}
