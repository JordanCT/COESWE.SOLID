namespace COESWE.SOLID.IMP
{
    public class Cuenta
    {
        public Guid CuentaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal SaldoDisponible { get; private set; }

        public Cuenta(Guid clienteId, decimal saldo)
        {
            CuentaId = Guid.NewGuid();
            ClienteId = clienteId;
            SaldoDisponible = saldo;
        }
    }
}
