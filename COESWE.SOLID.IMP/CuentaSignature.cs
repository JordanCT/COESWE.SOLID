namespace COESWE.SOLID.IMP
{
    public class CuentaSignature : Cuenta
    {
        public CuentaSignature(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            Tipo = nameof(CuentaSignature);
        }
    }
}
