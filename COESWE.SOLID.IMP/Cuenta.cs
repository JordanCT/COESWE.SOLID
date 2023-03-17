namespace COESWE.SOLID.IMP
{
    public abstract class Cuenta
    {
        public Guid CuentaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal SaldoDisponible { get; private set; }
        public string Tipo { get; protected set; }

        protected readonly List<Comision> _comisiones;
        public IReadOnlyCollection<Comision> Comisiones => _comisiones;

        public Cuenta(Guid clienteId, decimal saldo)
        {
            CuentaId = Guid.NewGuid();
            ClienteId = clienteId;
            SaldoDisponible = saldo;
            _comisiones = new List<Comision>();
        }
        public virtual void ModificarSaldoDisponible(decimal saldoDisponible)
        {
            SaldoDisponible = saldoDisponible;
        }

        public abstract void AgregarComision();

        public virtual decimal ObtenerSaldoDisponible() 
        {
            AgregarComision();
            return SaldoDisponible; 
        }
    }
}
