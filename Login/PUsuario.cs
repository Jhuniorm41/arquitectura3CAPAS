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
    public partial class PUsuario : Form
    {

        NUsuario NUser;
        NMecanico mecanico = new NMecanico();
        public PUsuario()
        {
            InitializeComponent();
        }
        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            NUser = new NUsuario();
            comboMecanico.DataSource = mecanico.ShowMecanico();
            comboMecanico.ValueMember = "id";
            comboMecanico.DisplayMember = "nombre";

            dataGridView1.DataSource = NUser.ShowUsuarios();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            NUser.RegistrarUsuario(textUser.Text, textPass.Text, Convert.ToInt16(comboMecanico.SelectedValue.ToString()));
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = NUser.ShowUsuarios();
        }

     

        private void baja_Click(object sender, EventArgs e)
        {
            NUser.EliminarUsuario(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se actualizo correctamente");
            dataGridView1.DataSource = NUser.ShowUsuarios();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NUser.ActualizarUsuario(Convert.ToInt16(textID.Text), textUser.Text, textPass.Text);
            MessageBox.Show("Se actualizo correctamente");
            dataGridView1.DataSource = NUser.ShowUsuarios();
        }
    }
}
