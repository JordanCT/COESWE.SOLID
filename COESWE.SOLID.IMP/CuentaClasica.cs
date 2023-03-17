namespace COESWE.SOLID.IMP
{
    public class CuentaClasica : Cuenta
    {
        public CuentaClasica(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            Tipo = nameof(CuentaClasica);
        }

        public override void AgregarComision()
        {
            var comision = new Comision(CuentaId, 1);
            _comisiones.Add(comision);
            ModificarSaldoDisponible(SaldoDisponible - comision.Monto);
        }
    }
}
