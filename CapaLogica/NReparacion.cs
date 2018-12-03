using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class NReparacion
    {
        public static DReparacion reparacion;
        public void RegistrarReparacion(string codigo,string nombre, DateTime fecha, decimal monto, int id_mecanico, int id_vehiculo)
        {
            DReparacion Reparacion = new DReparacion();
            Reparacion.Codigo = codigo;
            Reparacion.Descripcion = nombre;
            Reparacion.Fecha = fecha;
            Reparacion.Monto = monto;
            Reparacion.Id_mecanico = id_mecanico;
            Reparacion.Id_vehiculo = id_vehiculo;
            Reparacion.AddReparacion();
        }
        public void ActualizarReparacion(string nombre, DateTime fecha, decimal monto)
        {
            DReparacion Reparacion = new DReparacion();
            Reparacion.Descripcion = nombre;
            Reparacion.Fecha = fecha;
            Reparacion.Monto = monto;
            Reparacion.UpdateReparacion();
        }

        public void EliminarReparacion(int id)
        {
            DReparacion serv = new DReparacion();
            serv.ID = id;
            serv.DeleteReparacion();
        }

        public DataTable ShowReparacion()
        {
            reparacion = new DReparacion();
            return reparacion.GetTableReparacions();
        }

    }
}
