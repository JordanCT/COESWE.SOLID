using Newtonsoft.Json;

namespace COESWE.SOLID.IMP.Repositorio
{
    public class RepositoryActionCliente : IRepositoryActionCliente
    {
        private readonly List<Cliente> _listaCliente;
        private readonly StreamWriter _writer;
        public RepositoryActionCliente(string conexion)
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
