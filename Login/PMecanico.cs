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
    public partial class PMecanico : Form
    {
        NMecanico mecanico;
        public PMecanico()
        {
            InitializeComponent();
        }
        private void PMecanico_Load(object sender, EventArgs e)
        {
            mecanico = new NMecanico();
            dataGridView1.DataSource = mecanico.ShowMecanico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mecanico.RegistrarMecanico(textCodigo.Text, textNombre.Text, textCI.Text, textDireccion.Text, textTelefono.Text);
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = mecanico.ShowMecanico();
        }

    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mecanico.ActualizarMecanico(Convert.ToInt16(textID.Text), textCodigo.Text, textNombre.Text, textCI.Text, textDireccion.Text, textTelefono.Text);
            MessageBox.Show("Se modifico correctamente");
            dataGridView1.DataSource = mecanico.ShowMecanico();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mecanico.EliminarMecanico(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se Elimino correctamente");
            dataGridView1.DataSource = mecanico.ShowMecanico();
        }
    }
}
