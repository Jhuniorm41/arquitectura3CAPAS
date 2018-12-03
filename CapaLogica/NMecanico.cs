using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class NMecanico
    {
       public static DMecanico mecanico;
        public void RegistrarMecanico(string codLegajo, string nombre, string ci, string direccion, string telefono)
        {
            DMecanico mecanico = new DMecanico();
            mecanico.CodigoLegajo = codLegajo;
            mecanico.Nombre = nombre;
            mecanico.Ci = ci;
            mecanico.Direccion = direccion;
            mecanico.Telefono = telefono;
            mecanico.AddMecanico();
        }
        public void ActualizarMecanico(int id, string codLegajo, string nombre, string ci, string direccion, string telefono)
        {
            DMecanico mecanico = new DMecanico();
            mecanico.Id = id;
            mecanico.CodigoLegajo = codLegajo;
            mecanico.Nombre = nombre;
            mecanico.Ci = ci;
            mecanico.Direccion = direccion;
            mecanico.Telefono = telefono;
            mecanico.UpdateMecanico();
        }

        public void EliminarMecanico(int id)
        {
            DMecanico mecanico = new DMecanico();
            mecanico.Id = id;
            mecanico.DeleteMecanico();
        }
        public DataTable ShowMecanico()
        {
            mecanico = new DMecanico();
            return mecanico.GetTableMecanicos();
        }


    }
}

