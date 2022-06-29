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
    public partial class HManager : Form
    {
        public HManager()
        {
            InitializeComponent();
        }

        private void searchByLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMSearchByLocation sad = new HMSearchByLocation();
            sad.ShowDialog();
        }

        private void searchByBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMSearchByAddress sbg = new HMSearchByAddress();
            sbg.ShowDialog();

        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails sd = new StockDetails();
            sd.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI lgGui = new LoginGUI();
            this.Hide();
            lgGui.ShowDialog();
            this.Close();
        }

        private void requestBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HMRequestBloodGroup hmR = new HMRequestBloodGroup();
            hmR.ShowDialog();
        }
    }
}
