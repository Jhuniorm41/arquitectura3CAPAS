using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRepuesto : TemplateConexion
    {
        public int Id { get; set; }
        public String Marca { get; set; }
        public String Descripcion { get; set; }
        public String Industria { get; set; }
        public Decimal Precio { get; set; }


        public DRepuesto() { }
        public DRepuesto(string marca, string descripcion, string industria, Decimal precio)
        {
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.Industria = industria;
            this.Precio = precio;
        }

        public void AddRepuesto()
        {
            this.GuardarSQL();
        }
        public void UpdateRepuesto()
        {
            this.ActualizarSQL();
        }

        public void DeleteRepuesto()
        {
            this.EliminarSQL();
        }
        public DataTable GetTableRepuestos()
        {
            return this.GetTablaSQL();
        }


        public override string SqlActualizar()
        {
            return "update Repuesto set descripcion='" + this.Descripcion + "', marca='" + this.Marca + "', industria='" + this.Industria + "' where id='" + this.Id + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Repuesto where id='" + this.Id + "';";
        }

        public override string SqlGuardar()
        {
            return "insert into Repuesto values('" + this.Descripcion + "','" + this.Marca + "','" + this.Industria + "','" + this.Precio + "' );";
        }

        public override string SqlListarTabla()
        {
            return "select * from Repuesto";
        }
    }
}
