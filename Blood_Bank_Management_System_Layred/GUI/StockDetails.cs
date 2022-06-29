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
    public partial class StockDetails : Form
    {
        StockBL sbl;
        StockDTO sdo;
        public StockDetails()
        {
            InitializeComponent();
            sbl = new StockBL();
            sdo = new StockDTO();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.DataGridView1.Width, this.DataGridView1.Height);
            DataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.DataGridView1.Width, this.DataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = sbl.fetchAll();
                DataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
