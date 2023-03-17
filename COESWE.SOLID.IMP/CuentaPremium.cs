using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COESWE.SOLID.IMP
{
    public class CuentaPremium : Cuenta
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
