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
    public partial class HMSearchByAddress : Form
    {
        HMangerBL hmB;
        HMangerDTO hmD;
        public HMSearchByAddress()
        {
            InitializeComponent();
            hmB = new HMangerBL();
            hmD = new HMangerDTO();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void HMSearchByAddress_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = hmB.getAllDonorInfo();
                DataGridViewSearchA.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBloodGroupFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBloodGroupFind.Text != "")
                {
                    hmD.Bgroup = txtBloodGroupFind.Text;

                    DataSet dataset = hmB.fetchByBloodGroup(hmD);
                    DataGridViewSearchA.DataSource = dataset.Tables[0];
                }
                else
                {
                    DataSet dataSet = hmB.getAllDonorInfo();
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
