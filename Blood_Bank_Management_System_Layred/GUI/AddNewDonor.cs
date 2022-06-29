using Blood_Bank_Management_System_Layred.BL;
using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System_Layred.GUI
{
    public partial class AddNewDonor : Form
    {
        NewDonorDTO newDonorDTO;
        NewDonorBL newDonorBL;
        public AddNewDonor()
        {
            InitializeComponent();
            newDonorDTO = new NewDonorDTO();
            newDonorBL = new NewDonorBL();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtFather.Text = "";
            txtMother.Text = "";
            txtDOB.Text = "";
            txtMobile.Text = "";
            txtGender.Text = "";
            txtEmail.Text = "";
            txtBloodGroup.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtBloodGroup.SelectedIndex = -1;
            txtGender.SelectedIndex = -1;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "")
                {
                    newDonorDTO.DName = txtName.Text;
                    newDonorDTO.Fname = txtFather.Text;
                    newDonorDTO.Mname = txtMother.Text;
                    newDonorDTO.DoB = txtDOB.Text;
                    newDonorDTO.Moile = Int64.Parse(txtMobile.Text);
                    newDonorDTO.Gender = txtGender.Text;
                    newDonorDTO.Email = txtEmail.Text;
                    newDonorDTO.Bgroup = txtBloodGroup.Text;
                    newDonorDTO.City = txtCity.Text;
                    newDonorDTO.Address = txtAddress.Text;

                    // Adding New Donnor
                    int count = newDonorBL.AddNewDonor(newDonorDTO);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Processed Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(sender, e);
                        AddNewDonor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Fill All Feilds First. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = newDonorBL.getMaxID();
                int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelNewID.Text = (count + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
