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
    public partial class PVehiculo : Form
    {
        NVehiculo vehiculo;
        NTipoVehiculo tipo = new NTipoVehiculo();
        NCliente cliente = new NCliente();
        public PVehiculo()
        {
            InitializeComponent();
        }

        private void PVehiculo_Load(object sender, EventArgs e)
        {
            
            vehiculo = new NVehiculo();
            comboTipo.DataSource = tipo.ShowTipos();
            comboTipo.ValueMember = "id";
            comboTipo.DisplayMember = "descripcion";
        


            comboCliente.DataSource = cliente.ShowClientes();
            comboCliente.DisplayMember = "nombre";
            comboCliente.ValueMember = "id";

            dataGridView1.DataSource = vehiculo.ShowVehiculos();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vehiculo.RegistrarVehiculo(textPlaca.Text, textMarca.Text, textModelo.Text, Convert.ToInt16(textAnio.Text),textColor.Text, int.Parse(comboCliente.SelectedValue.ToString()), int.Parse(comboTipo.SelectedValue.ToString()));
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = vehiculo.ShowVehiculos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            vehiculo.UpdateVehiculo(Convert.ToInt16(textID.Text), textPlaca.Text, textMarca.Text, textModelo.Text, Convert.ToInt16(textAnio.Text), textColor.Text);
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = vehiculo.ShowVehiculos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            vehiculo.EliminarVehiculo(Convert.ToInt16(Convert.ToInt16(textID.Text)));
            MessageBox.Show("Se Elimino correctamente");
            dataGridView1.DataSource = vehiculo.ShowVehiculos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
