namespace COESWE.SOLID.IMP
{
    public class Cuenta
    {
        public Guid CuentaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal SaldoDisponible { get; private set; }
        public string Tipo { get; private set; }

        public Cuenta(Guid clienteId, decimal saldo, string tipo)
        {
            CuentaId = Guid.NewGuid();
            ClienteId = clienteId;
            SaldoDisponible = saldo;
            Tipo = tipo;
        }
        public void ModificarSaldoDisponible(decimal saldoDisponible)
        {
            SaldoDisponible = saldoDisponible;
        }

        public decimal ObtenerSaldoDisponible()
        {
            if (Tipo == "CuentaPremium")
                ModificarSaldoDisponible(SaldoDisponible - 0.1m);
            else if (Tipo == "CuentaClasica")
                ModificarSaldoDisponible(SaldoDisponible - 1);
            return SaldoDisponible;
        }
    }
}
