using Blood_Bank_Management_System_Layred.BL;
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
    public partial class ViewAllDonorsDetails : Form
    {
        NewDonorBL donorBL;
        public ViewAllDonorsDetails()
        {
            InitializeComponent();
            donorBL = new NewDonorBL();
        }

        private void ViewAllDonorsDetails_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = donorBL.FetchAll();
                DataGridViewDetails.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.DataGridViewDetails.Width, this.DataGridViewDetails.Height);
            DataGridViewDetails.DrawToBitmap(bmp, new Rectangle(0, 0, this.DataGridViewDetails.Width, this.DataGridViewDetails.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
