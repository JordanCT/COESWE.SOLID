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

        public override decimal ObtenerSaldoDisponible()
        {
            ModificarSaldoDisponible(SaldoDisponible - 0.1m);
            return SaldoDisponible;
        }
    }
}
