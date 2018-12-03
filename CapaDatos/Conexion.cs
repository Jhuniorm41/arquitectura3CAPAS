using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class Conexion
    {
        private static Conexion instanciaConexion;
        
        public static SqlConnection conexion;
        public static SqlCommand ComandExect;

        private Conexion()
        {
            conexion = new SqlConnection("Data Source=SIRIUS;Initial Catalog=Taller_mecanico;Integrated Security=True");            
        }

        public static Conexion getInstanceConexion()
        {
            if (instanciaConexion == null)
            {
                instanciaConexion = new Conexion();
            }
            return instanciaConexion;
        }

        public void ConectarBD()
        {
            conexion.Open();
        }

        public void DesconectarBD()
        {
            conexion.Close();
        }

        public object EjecutarQuery(string sql, int tipo)
        {
            ConectarBD();
            ComandExect = new SqlCommand();
            SqlCommand SqlCmd = new SqlCommand(sql, conexion);
            if (tipo == 0) // ejecutar una accion de escritura (insert,update,delete)
            {
                int x = SqlCmd.ExecuteNonQuery();
                DesconectarBD();
                return x;
            }
            else  // accion de lectura u obtencion de datos
            {
                SqlDataReader dr = SqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DesconectarBD();
                return dt;
            }
            
        }
 
        
    }
}
