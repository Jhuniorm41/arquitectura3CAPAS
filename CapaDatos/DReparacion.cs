using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DReparacion : TemplateConexion
    {

        public int ID { get; set; }
        public String Codigo { get; set; }

        public String Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public Decimal Monto { get; set; }
        public int Id_vehiculo { get; set; }
        public int Id_mecanico { get; set; }



        public DReparacion() { }

        public DReparacion(string codigo, string descripcion, DateTime fecha, decimal monto, int id_vehiculo, int id_mecanico)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Monto = monto;
            this.Id_mecanico = id_mecanico;
            this.Id_vehiculo = id_vehiculo;

        }


        public void AddReparacion()
        {
            this.GuardarSQL();
        }
        public void UpdateReparacion()
        {
            this.ActualizarSQL();
        }

        public void DeleteReparacion()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableReparacions()
        {
            return this.GetTablaSQL();
        }


        public override string SqlGuardar()
        {
           return "insert into Reparacion values('" + this.Codigo + "','" + this.Descripcion + "','" + this.Fecha + "','" + this.Monto + "','" + this.Id_mecanico + "','" + this.Id_vehiculo + "');";
        }

        public override string SqlActualizar()
        {
            return "update Reparacion set descripcion='" + this.Descripcion + "', fecha='" + this.Fecha + "' where ID='" + this.ID + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Reparacion where ID='" + this.ID + "';";
        }

        public override string SqlListarTabla()
        {
            return "Select r.id, r.Descripcion,r.fecha_inicio, r.monto, v.placa as Vehiculo, m.nombre as Mecanico from Reparacion r, vehiculo v, mecanico m where r.id_mecanico = m.id and r.id_vehiculo = v.id";
        }
    }
}

