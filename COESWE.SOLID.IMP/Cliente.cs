namespace COESWE.SOLID.IMP
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public List<Cuenta> Cuentas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrWhiteSpace(ApellidoMaterno))
                return false;
            if (string.IsNullOrWhiteSpace(ApellidoPaterno))
                return false;
            if (string.IsNullOrWhiteSpace(Nombres))
                return false;
            return true;
        }
        public void AgregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }
    }
}