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
    public partial class AdminRequestTables : Form
    {
        HMangerBL hmBL;
        HMBloodAmmount hmAmount;

        public AdminRequestTables()
        {
            InitializeComponent();
            hmBL = new HMangerBL();
            hmAmount = new HMBloodAmmount();
        }

        private void AdminRequestTables_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = hmBL.fetchAll();
                DataGridView1.DataSource = dataSet.Tables[0];
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {

                int rowAffected = hmBL.DecreaseStock(hmAmount);
                int rowAffected2 = hmBL.DeleteFromReq(hmAmount);
                if (rowAffected == 1 && rowAffected2 == 1)
                {
                    MessageBox.Show("Data Proccessed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminRequestTables_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error!!!! Data is not Proccessed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                    hmAmount.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    hmAmount.BloodGroup = row.Cells[1].Value.ToString();
                    hmAmount.Amount = Convert.ToInt32(row.Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message is:    " + ex.Message, "Error Exeption Raised", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
