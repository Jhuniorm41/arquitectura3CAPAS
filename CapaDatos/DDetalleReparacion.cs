using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDetalleReparacion : TemplateConexion
    {

        public int ID { get; set; }

        public DateTime FechaFin { get; set; }

        public Decimal Monto { get; set; }
        public int ID_Servicio { get; set; }
        public int ID_Repuesto { get; set; }
        public int ID_Reparacion { get; set; }

        public DReparacion reparacion = null;

        List<DServicio> ListaServicios = new List<DServicio>();

        List<DRepuesto> ListaRepuestos = new List<DRepuesto>();

  


        public DDetalleReparacion() { }

        public DDetalleReparacion(DateTime fecha, Decimal monto, int id_servicio, int id_repuesto, int id_Reparacion)
        {

            this.FechaFin = fecha;
            this.Monto = monto;
            this.ID_Servicio = id_servicio;
            this.ID_Repuesto = id_repuesto;
            this.ID_Reparacion = id_Reparacion;
        }

        public void AddRepuesto(DRepuesto repuesto) {

            ListaRepuestos.Add(repuesto);
        }
        public void AddServicio(DServicio servicio)
        {

            ListaServicios.Add(servicio);
        }

        public void AddReparacion(DReparacion Reparacion) {
            if (reparacion == null) {
                this.reparacion = Reparacion;
            }
        }
        public void AdDDetalleReparacion()
        {
            this.GuardarSQL();
        }
        public void UpdateDetalleReparacion()
        {
            this.ActualizarSQL();
        }

        public void DeleteDetalleReparacion()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableDetalleReparacions()
        {
            return this.GetTablaSQL();
        }


        public override string SqlGuardar()
        {
            return "insert into detalle_Reparacion values('" + this.FechaFin + "','" + this.Monto + "','" + this.ID_Servicio + "','" + this.ID_Repuesto + "','" + this.ID_Reparacion + "')";
        }

        public override string SqlActualizar()
        {
            return "update detalle_Reparacion set fechaFin='" + this.FechaFin + "', monto='" + this.Monto + "' where ID='" + this.ID + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from detalle_Reparacion where ID='" + this.ID + "';";
        }

        public override string SqlListarTabla()
        {
            return "Select ID,fechaFin,Monto from Detalle_Reparacion";
        }
    }
}
