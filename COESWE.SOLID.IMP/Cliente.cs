namespace COESWE.SOLID.IMP
{
    public class Cliente
    {
        public Guid ClienteId { get; private set; }
        public string ApellidoPaterno { get; private set; }
        public string ApellidoMaterno { get; private set; }
        public string Nombres { get; private set; }

        private readonly List<Cuenta> _cuentas;
        public IReadOnlyCollection<Cuenta> Cuentas => _cuentas;

        public Cliente(string apellidoPaterno, string apellidoMaterno, string nombres)
        {
            ClienteId = Guid.NewGuid();
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Nombres = nombres;
            _cuentas = new List<Cuenta>();
        }

        public void AgregarCuenta(decimal saldo)
        {
            _cuentas.Add(new Cuenta(ClienteId, saldo));
        }
    }
}