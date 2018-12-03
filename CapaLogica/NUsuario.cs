using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
         //Registro de usuario
        public class NUsuario
        {
            public static DUsuario objDUsuario;

            public NUsuario() { }
            public void RegistrarUsuario(string username, string password, int id_mecanico)
            {
                objDUsuario = new DUsuario();
                objDUsuario.UserName = username;
                objDUsuario.Password = password;
                objDUsuario.ID_Mecanico = id_mecanico;
                objDUsuario.AddUsuario();
            }

            public void ActualizarUsuario(int id, string username, string password)
            {
                DUsuario objDUsuario = new DUsuario();
                objDUsuario.ID = id;
                objDUsuario.UserName = username;
                objDUsuario.Password = password;
                objDUsuario.UpdateUsuario();
            }

            public void EliminarUsuario(int id)
            {
                DUsuario objDUsuario = new DUsuario();
                objDUsuario.ID = id;
                objDUsuario.DeleteUsuario();
            }
        public Boolean GetUsuario(string Username, string Password)
        {
            DUsuario usuario = new DUsuario();
            usuario.UserName = Username;
            usuario.Password = Password;
            bool sw = usuario.existe(usuario.UserName, usuario.Password);
            return sw;
        }
        public DataTable ShowUsuarios()
            {
                objDUsuario = new DUsuario();
                return objDUsuario.GetTableUsuarios();
            }

        }


    
}