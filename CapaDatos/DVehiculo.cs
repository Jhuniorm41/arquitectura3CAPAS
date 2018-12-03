using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DVehiculo : TemplateConexion
    {
        public int Id { get; set; }
        public String Placa { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public int Anio { get; set; }
        public String Color { get; set; }
        public int CodCliente { get; set; }
        public int CodTipo { get; set; }


        public DVehiculo()
        {
         }

        public DVehiculo(string placa, string marca, string modelo, int anio, string color, int codCliente, int codTipo)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Color = color;
            this.CodCliente = codCliente;
            this.CodTipo = codTipo;
        }

        public void AddVehiculo()
        {
            this.GuardarSQL();
        }
        public void UpdateVehiculo()
        {
            this.ActualizarSQL();
        }

        public void DeleteVehiculo()
        {
            this.EliminarSQL();
        }

        public DataTable GetTableVehiculo()
        {
            return this.GetTablaSQL();
        }

      

        public override string SqlActualizar()
        {
            return "update Vehiculo set placa='" + this.Placa + "', marca='" + this.Marca + "',modelo='" + this.Modelo + "', anio='" + this.Anio + "',color='" + this.Color + "' where id='" + this.Id + "';";
        }

        public override string SqlEliminar()
        {
            return "delete from Vehiculo where id='" + this.Id + "';";
        }

        public override string SqlGuardar()
        {
            return "insert into Vehiculo values('" + this.Placa + "','" + this.Marca + "','" + this.Modelo + "','" + this.Anio + "','" + this.Color + "','" + this.CodCliente + "','" + this.CodTipo + "');";
        }

        public override string SqlListarTabla()
        {
            return "select v.id ,v.placa , v.marca, v.modelo, v.anio, v.color, tv.descripcion as Tipo, c.nombre as Cliente from vehiculo v, tipo_vehiculo tv, Cliente c where v.id_cliente = c.id and v.id_tipo = tv.id";
        }
      
    }
}
