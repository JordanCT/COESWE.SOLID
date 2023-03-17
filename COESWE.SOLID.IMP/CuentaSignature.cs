using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COESWE.SOLID.IMP
{
    public class CuentaSignature : Cuenta
    {
        public CuentaSignature(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            Tipo = nameof(CuentaSignature);
        }

        public override decimal ObtenerSaldoDisponible()
        {
            return SaldoDisponible;
        }
    }
}
