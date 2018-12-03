using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
 
        public  class DCliente : TemplateConexion
        {

            public int Id { get; set; }
            public String CodigoCliente { get; set; }
            public String Nombre { get; set; }
            public String Ci { get; set; }
            public String Direccion { get; set; }
            public String Telefono { get; set; }

            public DCliente() { }

            public DCliente(string codigoCliente, string nombre, string ci, string direccion, string telefono)
            {
            this.CodigoCliente = codigoCliente;
            this.Nombre = Nombre;
            this.Ci = ci;
            this.Direccion = direccion;
            }


            public void AddCliente()
            {
                this.GuardarSQL();
            }
            public void UpdateCliente()
            {
                this.ActualizarSQL();
            }

            public void DeleteCliente()
            {
                this.EliminarSQL();
            }

            public DataTable getTableClientes()
            {
                return this.GetTablaSQL();
            }

            public override string SqlActualizar()
            {
                return "update Cliente set nombre='" + this.Nombre + "', CodigoCliente='" + this.CodigoCliente + "',ci='" + this.Ci + "', direccion='" + this.Direccion + "',telefono='" + this.Telefono + "' where id='" + this.Id + "';";
            }

            public override string SqlEliminar()
            {
                return "delete from Cliente where id='" + this.Id + "'";
            }

            public override string SqlGuardar()
            {
                return "insert into Cliente values('" + this.CodigoCliente + "','" + this.Nombre + "','" + this.Ci + "','" + this.Direccion + "','" + this.Telefono + "');";
            }

            public override string SqlListarTabla()
            {
                return "select * from Cliente";
            }
        }


    }
