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
    public partial class PCliente : Form
    {
        NCliente cliente;
        public PCliente()
        {
            InitializeComponent();
        }
        private void PCliente_Load(object sender, EventArgs e)
        {
            cliente = new NCliente();
            dataGridView1.DataSource = cliente.ShowClientes();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.RegistrarCliente(textCodigo.Text, textNombre.Text, textCI.Text, textDireccion.Text, textTelefono.Text);
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = cliente.ShowClientes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            cliente.EliminarCliente(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se Elimino correctamente");
            dataGridView1.DataSource = cliente.ShowClientes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cliente.ActualizarCliente(Convert.ToInt16(textID.Text), textCodigo.Text, textNombre.Text, textCI.Text, textDireccion.Text, textTelefono.Text);
            MessageBox.Show("Se modifico correctamente");
            dataGridView1.DataSource = cliente.ShowClientes();
        }
    }
}

