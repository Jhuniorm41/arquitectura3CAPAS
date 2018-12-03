using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class DMecanico : TemplateConexion
    {
        public int Id { get; set; }
        public String CodigoLegajo{get;set;}
        public String Nombre { get; set; }
        public String Ci  { get; set; }
        public String Direccion { get; set; }
        public String Telefono{get; set; }

        public DMecanico() { }

        public DMecanico(string codigoLegajo, string nombre, string ci, string direccion, string telefono)
        {
            this.CodigoLegajo = codigoLegajo;
            this.Nombre = Nombre;
            this.Ci = ci;
            this.Direccion = direccion;
        }


        public void AddMecanico()
        {
            this.GuardarSQL();
        }
        public void UpdateMecanico()
        {
            this.ActualizarSQL();
        }

        public void DeleteMecanico()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableMecanicos()
        {
            return this.GetTablaSQL();
        }

        public override string SqlActualizar()
        {
            return "update Mecanico set nombre='" + this.Nombre + "', CodigoLegajo='" + this.CodigoLegajo + "',ci='" + this.Ci + "', direccion='" + this.Direccion + "',telefono='" + this.Telefono + "' where id='" + this.Id + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Mecanico where id='" + this.Id + "'";
        }

        public override string SqlGuardar()
        {
            return "insert into Mecanico values('" + this.CodigoLegajo + "','" + this.Nombre + "','" + this.Ci + "','" + this.Direccion + "','" + this.Telefono +"');";
        }

        public override string SqlListarTabla()
        {
            return "select * from Mecanico";
        }
    }
}
