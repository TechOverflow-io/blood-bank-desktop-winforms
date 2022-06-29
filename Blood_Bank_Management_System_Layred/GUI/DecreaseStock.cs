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
    public partial class DecreaseStock : Form
    {
        StockBL sbl;
        StockDTO sdo;

        public DecreaseStock()
        {
            InitializeComponent();
            sbl = new StockBL();
            sdo = new StockDTO();
        }

        private void DecreaseStock_Load(object sender, EventArgs e)
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

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBloodGroup.Text != "" && txtUnits.Text != "")
                {
                    sdo.BloodGroup = txtBloodGroup.Text;
                    sdo.Quantity = Convert.ToInt32(txtUnits.Text);


                    // TRY CATCH HERE 
                    int rowAffected = sbl.DecreaseStock(sdo);
                    if (rowAffected == 1)
                    {
                        MessageBox.Show("Data Updated Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DecreaseStock_Load(sender, e);
                        txtBloodGroup.SelectedIndex = -1;
                        txtUnits.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Select Some\n Value to Insert ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.DataGridView1.Width, this.DataGridView1.Height);
            DataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.DataGridView1.Width, this.DataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }



}
