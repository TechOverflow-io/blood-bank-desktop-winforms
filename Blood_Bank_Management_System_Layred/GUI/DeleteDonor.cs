using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank_Management_System_Layred.BL;
using Blood_Bank_Management_System_Layred.DTO;

namespace Blood_Bank_Management_System_Layred.GUI
{
    public partial class DeleteDonor : Form
    {
        NewDonorDTO donorDTO;
        NewDonorBL donorBL;

        public DeleteDonor()
        {
            InitializeComponent();
            donorDTO = new NewDonorDTO();
            donorBL = new NewDonorBL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDonorIDSearch.Clear();
        }

        private void txtDonorIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorIDSearch.Text == "")
            {
                txtNameU.Clear();
                txtFatherU.Clear();
                txtMotherU.Clear();
                txtDOBU.ResetText();
                txtMobileU.Clear();
                txtGenderU.ResetText();
                txtEmailU.Clear();
                txtBloodGroupU.ResetText();
                txtCityU.Clear();
                txtAddressU.Clear();
                txtBloodGroupU.SelectedIndex = -1;
                txtGenderU.SelectedIndex = -1;


            }
        }

        private void txtDonorIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonorIDSearch.Text != "")
                {
                    donorDTO.DiD = Convert.ToInt32(txtDonorIDSearch.Text);

                    // Write this in TRY CATCH BLOCK 

                    DataSet dataSet = donorBL.getAllDonorInfo(donorDTO);
                    if (dataSet.Tables[0].Rows.Count != 0)
                    {
                        labelNewIDU.Text = dataSet.Tables[0].Rows[0][0].ToString();
                        txtNameU.Text = dataSet.Tables[0].Rows[0][1].ToString();
                        txtFatherU.Text = dataSet.Tables[0].Rows[0][2].ToString();
                        txtMotherU.Text = dataSet.Tables[0].Rows[0][3].ToString();
                        txtDOBU.Text = dataSet.Tables[0].Rows[0][4].ToString();
                        txtMobileU.Text = dataSet.Tables[0].Rows[0][5].ToString();
                        txtGenderU.Text = dataSet.Tables[0].Rows[0][6].ToString();
                        txtEmailU.Text = dataSet.Tables[0].Rows[0][7].ToString();
                        txtBloodGroupU.Text = dataSet.Tables[0].Rows[0][8].ToString();
                        txtCityU.Text = dataSet.Tables[0].Rows[0][9].ToString();
                        txtAddressU.Text = dataSet.Tables[0].Rows[0][10].ToString();
                    }
                    else
                    {
                        MessageBox.Show(" No Record Found", "Error Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" Please Enter ID to Search", "Error ID_Box is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {
            txtNameU.Enabled = false;
            txtFatherU.Enabled = false;
            txtMotherU.Enabled = false;
            txtBloodGroupU.Enabled = false;
            txtMobileU.Enabled = false;
            txtGenderU.Enabled = false;
            txtEmailU.Enabled = false;
            txtBloodGroupU.Enabled = false;
            txtCityU.Enabled = false;
            txtAddressU.Enabled = false;
            txtDOBU.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonorIDSearch.Text != "" && txtNameU.Text != "")
                {
                    donorDTO.DiD = Convert.ToInt32(txtDonorIDSearch.Text);

                    int rowAffected = donorBL.DeleteDonor(donorDTO);

                    if (rowAffected == 1)
                    {
                        MessageBox.Show("Donor Deleted Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" Please Enter ID to Search", "Error ID_Box is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
