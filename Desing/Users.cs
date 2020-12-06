using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        public Entities.User user { get; set;}
        public User userEdit { get; set; }
        public bool Edit { get; set; }

        private void setProfilePic()
        {
                DialogResult dr = Photo.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    user.PICTURE = Photo.FileName;
                    pbPP.ImageLocation = user.PICTURE;
                }
        }


        private void btnNC_Click(object sender, EventArgs e)
        {
            
                if(txtPassCon.Text != "" | txtPass.Text != "" )
                {
                    if (txtPassCon.Text == txtPass.Text)
                    {
                    if (txtName.Text != "" | txtLastName.Text != "" | dtpBirth.Text != "" | txtUser.Text != "" | cbType.Text != "")
                    {
                        user.NAME = txtName.Text;
                        user.LASTNAME = txtLastName.Text;
                        if (cbType.Text == "Administrador")
                        {
                            user.TYPE = 0;
                        }
                        else
                        {
                            user.TYPE = 1;
                        }
                        user.BIRTH = dtpBirth.Value;
                        user.USER = txtUser.Text;
                        user.PASSWORD = txtPass.Text;
                        user.CAREER = txtCareer.Text;
                        user.MAIL = txtMail.Text;
                        UserServices userServices = new UserServices();
                        if (Edit)
                        {
                            user.ID = userEdit.ID;
                            if (userServices.Edit(user))
                            {
                                MessageBox.Show("Usuario editado correctamente");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo completar la accion");
                            }
                        }
                        else
                        {
                            if (userServices.Add(user))
                            {
                                MessageBox.Show("Usuario agregado correctamente");
                                this.Hide(); 
                            }
                            else 
                            {
                                MessageBox.Show("No se pudo completar la accion");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }

            }
        
        private void EditUser()
        {
            pbPP.ImageLocation = userEdit.PICTURE;
            txtName.Text = userEdit.NAME;
            txtLastName.Text = userEdit.LASTNAME;
            dtpBirth.Value = userEdit.BIRTH;
            if(userEdit.TYPE == 0)
            {
                cbType.Text = "Administrador";
            }
            else
            {
                cbType.Text = "General";
            }
            txtUser.Text = userEdit.USER;
            txtPass.Text = userEdit.PASSWORD;
            txtCareer.Text = userEdit.CAREER;
            txtMail.Text = userEdit.MAIL;
        }
        private void SingIn_Load(object sender, EventArgs e)
        {
            user = new Entities.User();
            if (Edit)
            {
                EditUser();
                if(UserLogged.Instance.user.TYPE == 0)
                {
                    cbType.Enabled = true;
                }
            }
        }

        private void pbPP_Click(object sender, EventArgs e)
        {
            setProfilePic();
        }
    }
}
