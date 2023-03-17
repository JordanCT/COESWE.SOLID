namespace COESWE.SOLID.IMP
{
    public class CuentaClasica : Cuenta
    {
        public CuentaClasica(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            Tipo = nameof(CuentaClasica);
        }

        public override decimal ObtenerSaldoDisponible()
        {
            ModificarSaldoDisponible(SaldoDisponible - 1);
            return SaldoDisponible;
        }
    }
}
