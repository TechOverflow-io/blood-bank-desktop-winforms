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
    public partial class UpdateDonor : Form
    {
        NewDonorDTO donorDTO;
        NewDonorBL donorBL;
        public UpdateDonor()
        {
            InitializeComponent();
            donorDTO = new NewDonorDTO();
            donorBL = new NewDonorBL();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDonorIDSearch.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show(" Please Enter Some ID to Search", "Error Feild is Empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void UpdateDonor_Load(object sender, EventArgs e)
        {

        }

        private void txtDonorIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonorIDSearch.Text != "" && txtNameU.Text != "")
                {
                    donorDTO.DName = txtNameU.Text;
                    donorDTO.Fname = txtFatherU.Text;
                    donorDTO.Mname = txtMotherU.Text;
                    donorDTO.DoB = txtDOBU.Text;
                    donorDTO.Moile = Int64.Parse(txtMobileU.Text);
                    donorDTO.Gender = txtGenderU.Text;
                    donorDTO.Email = txtEmailU.Text;
                    donorDTO.Bgroup = txtBloodGroupU.Text;
                    donorDTO.City = txtCityU.Text;
                    donorDTO.Address = txtAddressU.Text;

                    int rowAffected = donorBL.UpdateDonor(donorDTO);
                    if (rowAffected == 1)
                    {
                        MessageBox.Show("Data Updated Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" Please Enter Some ID to Search", "Error Feild is Empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
