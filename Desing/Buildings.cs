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

namespace Desing
{
    public partial class Buildings : Form
    {
        public Buildings()
        {
            InitializeComponent();
        }
        BuildingServices buildingServices = new BuildingServices();
        ClassroomServices classroomServices = new ClassroomServices();
        public Building building = new Building();
        public Classroom classroom = new Classroom();
        private void getB()
        {
            dgvBuilding.DataSource = buildingServices.Get(0, "");
        }
        private void getC(string ID_Building)
        {
            dgvClassroom.DataSource = classroomServices.Get(0, ID_Building);
        }
        private void btnBAdd_Click(object sender, EventArgs e)
        {
            building.NAME = txtBName.Text;
            if (buildingServices.Add(building))
            {
                MessageBox.Show("Edificio agregado satisfactoriamente");
                getB();
            }
        }

        private void btnCRAdd_Click(object sender, EventArgs e)
        {
            if (dgvBuilding.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione uno de los edificios");
            }
            else
            {
                if (txtCapacity.Text != "" | txtCount.Text != "")
                {
                    for (int i = 1; i <= Convert.ToInt32(txtCount.Text); i++)
                    {
                        classroom.ID_BUILDING = Convert.ToInt32(dgvBuilding.CurrentRow.Cells[0].Value);
                        classroom.CAPACITY = Convert.ToInt32(txtCapacity.Text);
                        if (classroomServices.Add(classroom))
                        {
                            getC(dgvBuilding.CurrentRow.Cells[0].Value.ToString());
                        }
                    }
                }
            }

        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            if (dgvBuilding.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar el registro que desea eliminar");
            else
            {
                building.ID = Convert.ToInt32(dgvBuilding.CurrentRow.Cells[0].Value);
                if (buildingServices.Delete(building))
                {
                    MessageBox.Show("Edificio eliminado correctamente");
                    getB();
                    getC(dgvBuilding.CurrentRow.Cells[0].Value.ToString());
                }
            }   
        }

        private void btnCRDelete_Click(object sender, EventArgs e)
        {
            classroom.ID = Convert.ToInt32(dgvClassroom.CurrentRow.Cells[0].Value);
            if (classroomServices.Delete(classroom))
            {
                MessageBox.Show("Aula eliminada correctamente");
                getC(dgvBuilding.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getC(dgvBuilding.CurrentRow.Cells[0].Value.ToString());
            txtBID.Text = dgvBuilding.CurrentRow.Cells[0].Value.ToString();
        }

        private void Buildings_Load(object sender, EventArgs e)
        {
            getB();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
