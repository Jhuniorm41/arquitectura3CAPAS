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
    public partial class Login : Form
    {
        NUsuario NUser;

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
         NUser = new NUsuario();
        }
      
        private void validar_Click(object sender, EventArgs e)
        {
            if (NUser.GetUsuario(VUsuario.Text, VPassword.Text) == true)
            {

                Principal P = new Principal();
                P.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario Invalido");
            }
        }


       
    }
}
