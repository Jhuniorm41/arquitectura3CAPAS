using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void CerrarSecion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void gestionarUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PUsuario RU = new PUsuario();
            RU.Show();
        }

        private void gestionarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PServicio P = new PServicio();
            P.Show();
        }

        private void gestionarMecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMecanico P = new PMecanico();
            P.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCliente P = new PCliente();
            P.Show();
        }

        private void gestionarVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PVehiculo P = new PVehiculo();
            P.Show();
        }

        private void gestionarRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRepuesto P = new PRepuesto();
            P.Show();
        }

        private void gestionarTipoVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTipoVehiculo P = new PTipoVehiculo();
            P.Show();
        }

        private void gestionarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PReparacion p = new PReparacion();
            p.Show();
        }
    }
}
