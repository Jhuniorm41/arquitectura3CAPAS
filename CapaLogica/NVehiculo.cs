using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
    public class NVehiculo
    {

        public static DVehiculo vehiculo;
        public void RegistrarVehiculo(string placa, string marca, string modelo, int anio,string color, int codCliente, int codTipo)
        {
            DVehiculo vehiculo = new DVehiculo();
            vehiculo.Placa = placa;
            vehiculo.Marca = marca;
            vehiculo.Modelo = modelo;
            vehiculo.Anio = anio;
            vehiculo.Color = color;
            vehiculo.CodTipo = codTipo;
            vehiculo.CodCliente = codCliente;
            vehiculo.AddVehiculo();
        }
        public void UpdateVehiculo(int id, string placa, string marca, string modelo, int anio, string color)
        {
            DVehiculo vehiculo = new DVehiculo();
            vehiculo.Id = id;
            vehiculo.Placa = placa;
            vehiculo.Marca = marca;
            vehiculo.Modelo = modelo;
            vehiculo.Anio = anio;
            vehiculo.Color = color;
            vehiculo.UpdateVehiculo();
        }
        public void EliminarVehiculo(int id)
        {
            DVehiculo vehiculo = new DVehiculo();
            vehiculo.Id = id;
            vehiculo.DeleteVehiculo();
        }
        public DataTable ShowVehiculos()
        {
            vehiculo = new DVehiculo();
            return vehiculo.GetTableVehiculo();
        }


    }
}
