using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaDatos
{
    public class DServicio : TemplateConexion
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Decimal Costo { get; set; }

        public DServicio() { }
        public DServicio(string nombre, Decimal costo)
        {
            this.Nombre = nombre;
            this.Costo = costo;
        }

        public void AddServicio()
        {
            this.GuardarSQL();
        }
        public void UpdateServicio()
        {
            this.ActualizarSQL();
        }

        public void DeleteServicio()
        {
            this.EliminarSQL();
        }
        public DataTable GetTableServicios()
        {
            return this.GetTablaSQL();
        }


        public override string SqlActualizar()
        {
            return "update Servicio set descripcion='" + this.Nombre + "', costo='" + this.Costo + "' where id='" + this.Id + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Servicio where id='" + this.Id + "';";
        }

        public override string SqlGuardar()
        {
            return "insert into Servicio values('" + this.Nombre + "','" + this.Costo + "');";
        }

        public override string SqlListarTabla()
        {
            return "select * from Servicio";
        }
      }
    }
