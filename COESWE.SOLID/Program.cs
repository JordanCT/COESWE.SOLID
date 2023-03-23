using COESWE.SOLID.IMP;
using COESWE.SOLID.IMP.Repositorio;
using System.Collections;
using System.Reflection;

namespace COESWE.SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Cruz", "Tarazona", "Jordan");
            cliente.AgregarCuenta(400);
            var validador = new ClienteValidator();
            var resultado = validador.Validate(cliente);
            if (resultado.IsValid)
            {
                var disponible = 0m;
                var cuentaId = cliente.Cuentas.FirstOrDefault().CuentaId;
                for (int i = 0; i < 10; i++)
                {
                    disponible = cliente.ConsultarSaldoDisponible(cuentaId);
                }
                PrintProperties(cliente, 0);
                Console.WriteLine($"El saldo de la cuenta es: {disponible}");

                IRepositoryActionCliente repositorioCliente = new RepositoryActionCliente("Cliente.txt");
                repositorioCliente.Add(cliente);
                repositorioCliente.Save();

                IRepositoryQueryCliente repositorioConsultaCliente = new RepositoryQueryCliente("Cliente.txt");
                var listaCliente = repositorioConsultaCliente.GetAll();
                Console.WriteLine($"Se encontró {listaCliente.Count} client(s) guardados");
            }
            else
                foreach (var error in resultado.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
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