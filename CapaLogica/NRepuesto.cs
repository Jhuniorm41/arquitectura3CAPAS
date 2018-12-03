using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{

    public class NRepuesto
    {
        public static DRepuesto objDRepuesto;

        public NRepuesto() { }
        public void RegistrarRepuesto(string marca, string Descripcion, string industria, decimal precio)
        {
            objDRepuesto = new DRepuesto();
            objDRepuesto.Marca = marca;
            objDRepuesto.Descripcion = Descripcion;
            objDRepuesto.Industria = industria;
            objDRepuesto.Precio = precio;
            objDRepuesto.AddRepuesto();
        }

        public void ActualizarRepuesto(int id, string marca, string Descripcion, string industria, decimal precio)
        {
            DRepuesto objDRepuesto = new DRepuesto();
            objDRepuesto.Id = id;
            objDRepuesto.Marca = marca;
            objDRepuesto.Descripcion = Descripcion;
            objDRepuesto.Industria = industria;
            objDRepuesto.Precio = precio;
            objDRepuesto.UpdateRepuesto();
        }

        public void EliminarRepuesto(int id)
        {
            DRepuesto objDRepuesto = new DRepuesto();
            objDRepuesto.Id = id;
            objDRepuesto.DeleteRepuesto();
        }

        public DataTable ShowRepuestos()
        {
            objDRepuesto = new DRepuesto();
            return objDRepuesto.GetTableRepuestos();
        }

    }


}
