using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class NServicio
    {
        public static DServicio servicio;
        public void RegistrarServicio(string nombre, decimal costo)
        {
            DServicio servicio = new DServicio();
            servicio.Nombre = nombre;
            servicio.Costo = costo;
            servicio.AddServicio();
        }
        public void ActualizarServicio(int id, string nombre, decimal costo)
        {
            DServicio serv = new DServicio();
            serv.Id = id;
            serv.Nombre = nombre;
            serv.Costo = costo;
            serv.UpdateServicio();
        }

        public void EliminarServicio(int id)
        {
            DServicio serv = new DServicio();
            serv.Id = id;
            serv.DeleteServicio();
        }
        public DataTable ShowServicios()
        {
            servicio = new DServicio();
            return servicio.GetTableServicios();
        }

    }

}

