using Services;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño;

namespace Desing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPassword.Text != "")
            {
                UserServices userServices = new UserServices();
                DataTable dt = new DataTable();
                dt = userServices.Login(txtUser.Text, txtPassword.Text);
                if (dt is null)
                {
                    MessageBox.Show("Datos incorrectos");
                }
                else if(dt.Rows.Count == 1)
                {
                    UserLogged.Instance.logIn(dt);
                    Registers principal = new Registers();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            
        }


        private void btnNC_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }
    }
}
