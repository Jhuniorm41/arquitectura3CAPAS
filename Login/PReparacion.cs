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
    public partial class PReparacion : Form
    {
        NReparacion reparacion;
        NMecanico mecanico = new NMecanico();
        NVehiculo vehiculo = new NVehiculo();

        public PReparacion()
        {
            InitializeComponent();
        }

        private void PReparacion_Load(object sender, EventArgs e)
        {
            reparacion = new NReparacion();
            comboMecanico.DataSource = mecanico.ShowMecanico();
            comboMecanico.ValueMember = "id";
            comboMecanico.DisplayMember = "nombre";

            comboVehiculo.DataSource = vehiculo.ShowVehiculos();
            comboVehiculo.ValueMember = "id";
            comboVehiculo.DisplayMember = "placa";

            dataGridView1.DataSource = reparacion.ShowReparacion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            reparacion.RegistrarReparacion(textCodigo.Text, textDescripcion.Text, Convert.ToDateTime( textFecha.Text),Convert.ToDecimal( textMonto.Text), int.Parse(comboMecanico.SelectedValue.ToString()), int.Parse(comboVehiculo.SelectedValue.ToString()));
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = reparacion.ShowReparacion();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No esta disponible");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            reparacion.EliminarReparacion(Convert.ToInt16(Convert.ToInt16(textID.Text)));
            MessageBox.Show("Se Elimino correctamente");
            dataGridView1.DataSource = reparacion.ShowReparacion();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            PDetalle P = new PDetalle();
            P.Show();
            this.Hide();
        }
    }
}
