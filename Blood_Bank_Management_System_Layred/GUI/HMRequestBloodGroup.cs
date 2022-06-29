using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank_Management_System_Layred.DTO;
using Blood_Bank_Management_System_Layred.BL;

namespace Blood_Bank_Management_System_Layred.GUI
{
    public partial class HMRequestBloodGroup : Form
    {
        HMBloodAmmount reqDTO;
        HMangerBL hmB;
        public HMRequestBloodGroup()
        {
            InitializeComponent();
            reqDTO = new HMBloodAmmount();
            hmB = new HMangerBL();
        }

        private void btnRequestBlood_Click(object sender, EventArgs e)
        {
            try
            {


                reqDTO.BloodGroup = txtBloodGroup.Text;
                reqDTO.Amount = Convert.ToInt32(txtUnits.Text);

                int rowAffected = hmB.AddReq(reqDTO);
                if (rowAffected == 1)
                {
                    MessageBox.Show("Request is Posted Successfully.... ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
