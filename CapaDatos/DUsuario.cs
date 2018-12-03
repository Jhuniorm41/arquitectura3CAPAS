using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{

    public class DUsuario : TemplateConexion
    {

        public int ID { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public int ID_Mecanico { get; set; }


        public DUsuario() { }

        public DUsuario(string username, string password, int id_mecanico)
        {
            
            this.UserName = username;
            this.Password = password;
            this.ID_Mecanico = id_mecanico;
        }


        public void AddUsuario()
        {
            this.GuardarSQL();
        }
        public void UpdateUsuario()
        {
            this.ActualizarSQL();
        }

        public void DeleteUsuario()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableUsuarios()
        {
            return this.GetTablaSQL();
        }

        public bool existe( string username, string password)
        {
            int d = 0;
            string sql = "SELECT '"+ @d +"'= count(*) FROM usuario WHERE username ='" + username + "' and password ='" + password + "';";

            return d == 0 ? true : false;
        }
        public override string SqlGuardar()
        {
            return "insert into Usuario values('" + this.UserName + "','" + this.Password + "','" + this.ID_Mecanico + "')";
        }

        public override string SqlActualizar()
        {
            return "update Usuario set UserName='" + this.UserName + "', Password='" + this.Password + "' where ID='" + this.ID + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Usuario where ID='" + this.ID + "';";
        }

        public override string SqlListarTabla()
        {
            return "Select u.id ,m.Nombre as Mecanico ,u.UserName from Usuario u, mecanico m where u.id_mecanico = m.id";
        }
    }
}
