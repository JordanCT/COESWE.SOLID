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
            string tipo;
            if (saldo > 400)
                tipo = "CuentaSignature";
            else if (saldo > 200)
                tipo = "CuentaPremium";
            else
                tipo = "CuentaClasica";
            _cuentas.Add(new Cuenta(ClienteId, saldo, tipo));
        }

        public decimal ConsultarSaldoDisponible(Guid cuentaId)
        {
            var cuenta = _cuentas.FirstOrDefault(x => x.CuentaId == cuentaId);
            return cuenta.ObtenerSaldoDisponible();
        }
    }
}