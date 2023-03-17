using COESWE.SOLID.IMP;
using System.Collections;
using System.Reflection;

namespace COESWE.SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.ClienteId = Guid.NewGuid();
            cliente.ApellidoPaterno = "Cruz";
            cliente.ApellidoMaterno = "Tarazona";
            cliente.Nombres = "Jordan";
            cliente.Cuentas = new List<Cuenta>();
            var cuenta = new Cuenta();
            cuenta.ClienteId = cliente.ClienteId;
            cuenta.CuentaId = Guid.NewGuid();
            cuenta.SaldoDisponible = 200;
            cliente.Cuentas.Add(cuenta);
            if (cliente.Validar())
                PrintProperties(cliente, 0);

        }

        private static void PrintProperties(object obj, int indent)
        {
            if (obj == null) return;
            string indentString = new string(' ', indent);
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(obj, null);
                var elems = propValue as IList;
                if (elems != null)
                {
                    foreach (var item in elems)
                    {
                        PrintProperties(item, indent + 3);
                    }
                }
                else
                {
                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        Console.WriteLine($"{indentString}{property.Name}:");

                        PrintProperties(propValue, indent + 2);
                    }
                    else
                    {
                        Console.WriteLine($"{indentString}{property.Name}: {propValue}");
                    }
                }
            }
        }
    }
}