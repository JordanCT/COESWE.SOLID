using Newtonsoft.Json;

namespace COESWE.SOLID.IMP.Repositorio
{
    public class RepositoryQueryCliente : IRepositoryQueryCliente
    {
        private readonly List<Cliente> _listaCliente;

        public RepositoryQueryCliente(string conexion)
        {
            using (StreamReader _reader = new StreamReader(conexion))
            {
                string jsonresult = _reader.ReadToEnd();
                _listaCliente = JsonConvert.DeserializeObject<List<Cliente>>(jsonresult, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Objects
                });
            }
        }
        public Cliente Get(Guid id)
        {
            return _listaCliente.Find(x => x.ClienteId == id);
        }

        public List<Cliente> GetAll()
        {
            return _listaCliente;
        }
    }
}
