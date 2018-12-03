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
    public partial class PServicio : Form
    {
        NServicio NSer;
        public PServicio()
        {
            InitializeComponent();
        }

        public static string id;
        public static string nombre;
        public static string costo;
        private void PServicio_Load(object sender, EventArgs e)
        {
            NSer = new NServicio();
            dataGridView1.DataSource = NSer.ShowServicios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NSer.RegistrarServicio(textNombre.Text, Convert.ToDecimal(textCosto.Text));
            MessageBox.Show("Se registro correctamente");
            dataGridView1.DataSource = NSer.ShowServicios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            NSer.ActualizarServicio(Convert.ToInt16(textID.Text) ,textNombre.Text, Convert.ToDecimal(textCosto.Text));
            MessageBox.Show("Se modifico correctamente");
            dataGridView1.DataSource = NSer.ShowServicios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NSer.EliminarServicio(Convert.ToInt16(textID.Text));
            MessageBox.Show("Se elimino correctamente");
            dataGridView1.DataSource = NSer.ShowServicios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // listView1.Items.Add(NSer.ShowServicios.T);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            costo = dataGridView1.Rows[e.RowIndex].Cells["costo"].Value.ToString();

        }
    }
}
