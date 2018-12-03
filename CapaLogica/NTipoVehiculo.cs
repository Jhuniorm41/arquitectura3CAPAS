using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class NTipoVehiculo
    {
      
            public static DDTipoVehiculo Tipo;

            public NTipoVehiculo() { }
            public void RegistrarTipo(string descripcion)
            {
                Tipo = new DDTipoVehiculo();
                Tipo.Descripcion = descripcion;
                Tipo.AddDTipoVehiculo();
            }

       
            public void ActualizarTipo(int id, string descripcion)
            {
                DDTipoVehiculo tipo = new DDTipoVehiculo();
                tipo.ID = id;
                tipo.Descripcion = descripcion;              
                tipo.UpdateDTipoVehiculo();
            }

            public void EliminarTipo(int id)
            {
                DDTipoVehiculo tipo = new DDTipoVehiculo();
                tipo.ID = id;
                tipo.DeleteDTipoVehiculo();
            }
       
            public DataTable ShowTipos()
            {
                Tipo = new DDTipoVehiculo();
                return Tipo.GetTableDTipoVehiculos();
            }

        }
    
}
