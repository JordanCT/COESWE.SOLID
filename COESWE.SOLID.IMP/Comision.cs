namespace COESWE.SOLID.IMP
{
    public class Comision
    {
        public Guid ComisionId { get; private set; }
        public Guid CuentaId { get; private set; }
        public decimal Monto { get; private set; }
        public Comision(Guid cuentaId, decimal monto)
        {
            ComisionId= Guid.NewGuid();
            CuentaId= cuentaId;
            Monto= monto;
        }
    }
}
