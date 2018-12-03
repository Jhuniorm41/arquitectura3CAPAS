
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class TemplateConexion
    {
        public static Conexion conexion;


        public TemplateConexion()
        {
            conexion = Conexion.getInstanceConexion();
        }

        public static Conexion getConexion()
        {
            return conexion;
        }

        // METODOS PLANTILLA GENERALES

        public void GuardarSQL()
        {
            conexion.EjecutarQuery(SqlGuardar(), 0);
        }

        public void ActualizarSQL()
        {
            conexion.EjecutarQuery(SqlActualizar(), 0);
        }

        public void EliminarSQL()
        {
            conexion.EjecutarQuery(SqlEliminar(), 0);
        }

        public DataTable GetTablaSQL()
        {
            return (DataTable)conexion.EjecutarQuery(SqlListarTabla(), 1);
        }


        public abstract string SqlGuardar();

        public abstract string SqlActualizar();

        public abstract string SqlEliminar();

        public abstract string SqlListarTabla();
    }
}
