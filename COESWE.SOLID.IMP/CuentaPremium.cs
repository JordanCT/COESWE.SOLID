namespace COESWE.SOLID.IMP
{
    public class CuentaPremium : CuentaComisionable
    {
        public CuentaPremium(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            Tipo = nameof(CuentaPremium);
        }

        public override void AgregarComision()
        {
            var comision = new Comision(CuentaId, 0.1m);
            _comisiones.Add(comision);
            ModificarSaldoDisponible(SaldoDisponible - comision.Monto);
        }
    }
}
