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
    public partial class PRepuesto : Form
    {
        NRepuesto Repuesto;
        public PRepuesto()
        {
            InitializeComponent();
        }
        private void PRepuesto_Load(object sender, EventArgs e)
        {
            Repuesto = new NRepuesto();
            dataGridView1.DataSource = Repuesto.ShowRepuestos();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Repuesto.RegistrarRepuesto(textMarca.Text,textDescripcion.Text,textIndustria.Text, Convert.ToDecimal(textPrecio.Text));
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = Repuesto.ShowRepuestos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Repuesto.ActualizarRepuesto(Convert.ToInt16(textID.Text), textMarca.Text,textDescripcion.Text, textIndustria.Text ,Convert.ToDecimal(textPrecio.Text));
            MessageBox.Show("Se modifico correctamente");
            dataGridView1.DataSource = Repuesto.ShowRepuestos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Repuesto.EliminarRepuesto(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se elimino correctamente");
            dataGridView1.DataSource = Repuesto.ShowRepuestos();
        }

     
    }
}
