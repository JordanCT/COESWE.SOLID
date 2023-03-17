namespace COESWE.SOLID.IMP
{
    public class Cuenta
    {
        public Guid CuentaId { get; set; }
        public Guid ClienteId { get; set; }
        public decimal SaldoDisponible { get; set; }
    }
}
