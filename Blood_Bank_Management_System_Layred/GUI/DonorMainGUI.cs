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
    public partial class DonorMainGUI : Form
    {
        public DonorMainGUI()
        {
            InitializeComponent();
        }

        private void searchBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMSearchByLocation s = new HMSearchByLocation();
            s.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HMSearchByAddress sad = new HMSearchByAddress();
            sad.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI lgGui = new LoginGUI();
            this.Hide();
            lgGui.ShowDialog();
            this.Close();
        }
    }
}
