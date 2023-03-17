using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COESWE.SOLID.IMP
{
    public abstract class CuentaComisionable : Cuenta
    {
        protected readonly List<Comision> _comisiones;
        public IReadOnlyCollection<Comision> Comisiones => _comisiones;
        public CuentaComisionable(Guid clienteId, decimal saldo) 
            : base(clienteId, saldo)
        {
            _comisiones = new List<Comision>();
        }

        public abstract void AgregarComision();

        public override decimal ObtenerSaldoDisponible()
        {
            AgregarComision();
            return SaldoDisponible;
        }
    }
}
