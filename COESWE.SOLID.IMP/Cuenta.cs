namespace COESWE.SOLID.IMP
{
    public abstract class Cuenta
    {
        public Guid CuentaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal SaldoDisponible { get; private set; }
        public string Tipo { get; protected set; }
        public Cuenta(Guid clienteId, decimal saldo)
        {
            CuentaId = Guid.NewGuid();
            ClienteId = clienteId;
            SaldoDisponible = saldo;
        }
        public virtual void ModificarSaldoDisponible(decimal saldoDisponible)
        {
            SaldoDisponible = saldoDisponible;
        }

        public virtual decimal ObtenerSaldoDisponible() 
        {
            return SaldoDisponible; 
        }
    }
}
