using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
namespace Login
{
    public partial class PDetalle : Form
    {

        NDetalleReparacion detalle;
        NReparacion reparacion = new NReparacion();
        NRepuesto repuesto = new NRepuesto();
        NServicio servicio = new NServicio();

        public PDetalle()
        {
            InitializeComponent();
        }

        private void PDetalle_Load(object sender, EventArgs e)
        {
            detalle = new NDetalleReparacion();
            comboRepuesto.DataSource = repuesto.ShowRepuestos();
            comboRepuesto.DisplayMember = "descripcion";
            comboRepuesto.ValueMember = "id";

            comboServicio.DataSource = servicio.ShowServicios();
            comboServicio.DisplayMember = "descripcion";
            comboServicio.ValueMember = "id";


        }

        private void btnServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnRepuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
