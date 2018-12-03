using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDTipoVehiculo : TemplateConexion
    {

        public int ID { get; set; }

        public String Descripcion { get; set; }

   


        public DDTipoVehiculo() { }

        public DDTipoVehiculo(string descripcion)
        {
            this.Descripcion = descripcion;
        }


        public void AddDTipoVehiculo()
        {
            this.GuardarSQL();
        }
        public void UpdateDTipoVehiculo()
        {
            this.ActualizarSQL();
        }

        public void DeleteDTipoVehiculo()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableDTipoVehiculos()
        {
            return this.GetTablaSQL();
        }


        public override string SqlGuardar()
        {
            return "insert into Tipo_vehiculo values('" + this.Descripcion + "')";
        }

        public override string SqlActualizar()
        {
            return "update tipo_vehiculo set descripcion='" + this.Descripcion + "'where ID='" + this.ID + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from tipo_vehiculo where ID='" + this.ID + "';";
        }

        public override string SqlListarTabla()
        {
            return "Select ID ,Descripcion from tipo_vehiculo";
        }
    }
}
