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
using Entities;
using Services;

namespace Desing
{
    public partial class Registers : Form
    {
        public Registers()
        {
            InitializeComponent();
        }
        public Register register = new Register();
        public bool Edit { get; set; }
        public User user = new User();
        RegisterServices registerServices = new RegisterServices();


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            register.ID_USER = user.ID;
            register.ID_BUILDING = Convert.ToInt32(cbBuilding.SelectedIndex.ToString())+ 1;
            register.ENTRY = dtpEntry.Value.ToString();
            register.EXIT = dtpExit.Value.ToString();
            register.REASON = txtReason.Text;
            register.ID_CLASSROOM = Convert.ToInt32(cbClassroom.Text);
            if (!Edit)
            {
                if (registerServices.Add(register))
                {
                    MessageBox.Show("Visita agendada");
                    Edit = false;
                }
                else
                    MessageBox.Show("ERROR");
            }
            else
            {
                if (registerServices.Edit(register))
                {
                    MessageBox.Show("Visita agendada modificada");
                    Edit = false;
                }
                else
                    MessageBox.Show("ERROR");
            }
            
        }
        private void search(int ID)
        {
            user.ID = ID;
            UserServices userServices = new UserServices();
            DataTable dt = new DataTable();
            dt = userServices.Get(0, user.ID.ToString());
            txtName.Text = dt.Rows[0]["NAME"].ToString();
            txtLastName.Text = dt.Rows[0]["LASTNAME"].ToString();
            txtCareer.Text = dt.Rows[0]["CAREER"].ToString();
            txtMail.Text = dt.Rows[0]["MAIL"].ToString();
            pbPP.ImageLocation = dt.Rows[0]["PICTURE"].ToString();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(Convert.ToInt32(txtID.Text));
                Edit = false;
            }
        }

        private void cbSBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cbSBuilding.SelectedIndex + 1;
            dataGridView1.DataSource = registerServices.Get(1, a.ToString());
        }

        private void Registers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = registerServices.Get(0,"");
            if(UserLogged.Instance.user.TYPE == 0)
            {
                edificiosToolStripMenuItem.Enabled = true;
                agregarUsuarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                txtID.Text = UserLogged.Instance.user.ID.ToString();
                txtID.Enabled = false;
                search(UserLogged.Instance.user.ID);
            }
            setBCB(cbBuilding);
            setBCB(cbSBuilding);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            search(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            dtpEntry.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            dtpExit.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            txtReason.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Edit = true;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            register.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (registerServices.Delete(register))
            {
                MessageBox.Show("Visita eliminada correctamente");
                dataGridView1.DataSource = registerServices.Get(0, "");
            }

        }

        private void editarMiUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Edit = true;
            user.userEdit = UserLogged.Instance.user;
            user.ShowDialog();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void verUsuariosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buildings buildings = new Buildings();
            buildings.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogged.Instance.logOut();
            Login login = new Login();
            login.Show();
        }
        private void setBCB(ComboBox cb)
        {
            BuildingServices buildingServices = new BuildingServices();
            DataTable dt = new DataTable();
            dt = buildingServices.Get(0, "");
            if(dt.Rows.Count >= 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb.Items.Insert(Convert.ToInt32(dt.Rows[i][0].ToString()) - 1, dt.Rows[i][1].ToString());
                }
            }
        }
        private void setCRCB(ComboBox cb, int ID_Building)
        {
            ClassroomServices classroomServices = new ClassroomServices();
            DataTable dt = new DataTable();
            dt = classroomServices.Get(0, ID_Building.ToString());
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                cb.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClassroom.Items.Clear();
            setCRCB(cbClassroom, cbBuilding.SelectedIndex + 1);
        }
    }
}
