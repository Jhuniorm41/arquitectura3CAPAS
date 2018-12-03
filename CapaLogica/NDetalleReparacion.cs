using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
    public class NDetalleReparacion
    {
        public static DDetalleReparacion objDDetalleReparacion;

        public NDetalleReparacion() { }
        public static void RegistrarDetalleReparacion(Decimal monto, int id_servicio, int id_repuesto, int id_reparacion)
        {
            objDDetalleReparacion = new DDetalleReparacion();
            objDDetalleReparacion.Monto = monto;
            objDDetalleReparacion.ID_Servicio = id_servicio;
            objDDetalleReparacion.ID_Repuesto = id_repuesto;
            objDDetalleReparacion.ID_Reparacion = id_reparacion;
            objDDetalleReparacion.AdDDetalleReparacion();
        }

      
        public static DataTable ShowDetalleReparacions()
        {
            objDDetalleReparacion = new DDetalleReparacion();
            return objDDetalleReparacion.GetTableDetalleReparacions();
        }

    }

}
