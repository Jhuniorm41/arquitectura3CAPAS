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
    public partial class PTipoVehiculo : Form
    {
        NTipoVehiculo tipo;
        public PTipoVehiculo()
        {
            InitializeComponent();
        }

        private void PTipoVehiculo_Load(object sender, EventArgs e)
        {
            tipo = new NTipoVehiculo();
            
            dataGridView1.DataSource = tipo.ShowTipos();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            tipo.RegistrarTipo(textDescripcion.Text);
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = tipo.ShowTipos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tipo.ActualizarTipo(Convert.ToInt16(textID.Text), textDescripcion.Text);
            MessageBox.Show("Se modifico correctamente");
            dataGridView1.DataSource = tipo.ShowTipos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tipo.EliminarTipo(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se elimino correctamente");
            dataGridView1.DataSource = tipo.ShowTipos();

        }

        
    }
}
