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
    public partial class SearchByAddress : Form
    {
        NewDonorBL donorBL;
        NewDonorDTO donorDTO;

        public SearchByAddress()
        {
            InitializeComponent();
            donorBL = new NewDonorBL();
            donorDTO = new NewDonorDTO();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.DataGridViewSearchA.Width, this.DataGridViewSearchA.Height);
            DataGridViewSearchA.DrawToBitmap(bmp, new Rectangle(0, 0, this.DataGridViewSearchA.Width, this.DataGridViewSearchA.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchByAddress_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = donorBL.FetchAll();
                DataGridViewSearchA.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonorLoc_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtDonorLoc.Text != "")
                {
                    donorDTO.City = txtDonorLoc.Text;
                    donorDTO.Address = txtDonorLoc.Text;

                    DataSet dataset = donorBL.fetchByAddress(donorDTO);
                    DataGridViewSearchA.DataSource = dataset.Tables[0];
                }
                else
                {
                    DataSet dataSet = donorBL.FetchAll();
                    DataGridViewSearchA.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
