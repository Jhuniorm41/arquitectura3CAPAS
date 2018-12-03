using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
       public class NCliente
    {
        public static DCliente cliente;
        public void RegistrarCliente(string codCliente, string nombre, string ci, string direccion, string telefono)
        {
            DCliente Cliente = new DCliente();
         
            Cliente.CodigoCliente = codCliente;
            Cliente.Nombre = nombre;
            Cliente.Ci = ci;
            Cliente.Direccion = direccion;
            Cliente.Telefono = telefono;
            Cliente.AddCliente();
        }
        public void ActualizarCliente(int id, string codCliente, string nombre, string ci, string direccion, string telefono)
        {
            DCliente Cliente = new DCliente();
            Cliente.Id = id;
            Cliente.CodigoCliente = codCliente;
            Cliente.Nombre = nombre;
            Cliente.Ci = ci;
            Cliente.Direccion = direccion;
            Cliente.Telefono = telefono;
            Cliente.UpdateCliente();
        }

        public void EliminarCliente(int id)
        {
            DCliente Cliente = new DCliente();
            Cliente.Id = id;
            Cliente.DeleteCliente();
        }
        public DataTable ShowClientes()
        {
            cliente = new DCliente();
            return cliente.getTableClientes();
        }

    }
}

