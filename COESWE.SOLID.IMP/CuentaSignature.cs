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

        public override void AgregarComision()
        {
            throw new NotImplementedException("Este tipo de cuenta no es comisionable");
        }
    }
}
