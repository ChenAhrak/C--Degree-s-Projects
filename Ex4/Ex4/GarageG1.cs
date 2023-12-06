using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class GarageG1 : Form
    {
        Garage G1 = new Garage();
        public GarageG1()
        {
            InitializeComponent();
            G1 = new Garage();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblAddCar.Visible = true;
            txtId.Visible = true;
            txtfName.Visible = true;
            txtlName.Visible = true;
            txtPhone.Visible = true;
            txtAddress.Visible = true;
            txtLicense.Visible = true;
            txtMaker.Visible = true;
            txtYear.Visible = true;
            txtEngine.Visible = true;
            txtModel.Visible = true;
            btnOKaddCar.Visible = true;

            txtId.Text = "";
            txtfName.Text = "";
            txtlName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtLicense.Text = "";
            txtMaker.Text = "";
            txtYear.Text = "";
            txtEngine.Text = "";
            txtModel.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnOKaddCar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtfName.Text != "" && txtlName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtLicense.Text != "" && txtMaker.Text != "" && txtYear.Text != "" && txtEngine.Text != "" && txtModel.Text != "")
                {
                Costumers c1 = new Costumers(txtId.Text, txtfName.Text, txtlName.Text, txtPhone.Text, txtAddress.Text);
                Car car = new Car(int.Parse(txtLicense.Text), txtMaker.Text, int.Parse(txtYear.Text), int.Parse(txtEngine.Text), txtModel.Text, c1);
                G1.addCar(car);
                

                MessageBox.Show("Car was added successfully!", "Car added");

                lblAddCar.Visible = false;
                txtId.Visible = false;
                txtfName.Visible = false;
                txtlName.Visible = false;
                txtPhone.Visible = false;
                txtAddress.Visible = false;
                txtLicense.Visible = false;
                txtMaker.Visible = false;
                txtYear.Visible = false;
                txtEngine.Visible = false;
                txtModel.Visible = false;
                btnOKaddCar.Visible = false;
            }
            else MessageBox.Show("Empty fields", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblAddCar.Visible = false;
            txtId.Visible = false;
            txtfName.Visible = false;
            txtlName.Visible = false;
            txtPhone.Visible = false;
            txtAddress.Visible = false;
            txtLicense.Visible = false;
            txtMaker.Visible = false;
            txtYear.Visible = false;
            txtEngine.Visible = false;
            txtModel.Visible = false;
            btnOKaddCar.Visible = false;

            lblShowCars.Visible = true;
            lblShowCars.Text = "";
            for (int i = 0; i < G1.CARS.Length; i++)     
            {
                if (G1.CARS[i] != null)
                {
                    lblShowCars.Text = lblShowCars.Text + G1.CARS[i].toString() + $"Status: {G1.STATUS[i]}";
                }
                else break;
            }
        }

        private void lblShowCars_Click(object sender, EventArgs e)
        {
            lblShowCars.Visible = false;
        }

        private void btnFixCar_Click(object sender, EventArgs e)
        {
            txtInProcess.Visible = true;
            lblInProcess.Visible = true;
            btnInProcessOk.Visible = true;
        }

        private void btnInProcessOk_Click(object sender, EventArgs e)
        {
            if (G1.inProcess(int.Parse(txtInProcess.Text)))
            {
                txtInProcess.Visible = false;
                lblInProcess.Visible = false;
                btnInProcessOk.Visible = false;

                MessageBox.Show("Your Car is ready");
            }
            else MessageBox.Show("There is no car waiting with this number");

        }

        private void btnTakeCar_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
