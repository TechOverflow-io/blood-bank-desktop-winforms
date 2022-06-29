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
    public partial class AdminMainGUI : Form
    {
        public AdminMainGUI()
        {
            InitializeComponent();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor addForm = new AddNewDonor();
            addForm.ShowDialog();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI lgGui = new LoginGUI();

            this.Hide();
            lgGui.ShowDialog();
            this.Close();
        }
        private void updateDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonor upd = new UpdateDonor();
            upd.ShowDialog();
        }
        private void viewAllDonorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllDonorsDetails vad = new ViewAllDonorsDetails();
            vad.ShowDialog();
        }
        private void searchByLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByAddress sad = new SearchByAddress();
            sad.ShowDialog();
        }
        private void searchByBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByBloodGroup sabg = new SearchByBloodGroup();
            sabg.ShowDialog();
        }
        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncreaseStock ins = new IncreaseStock();
            ins.ShowDialog();
        }
        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecreaseStock ds = new DecreaseStock();
            ds.ShowDialog();
        }
        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails sd = new StockDetails();
            sd.ShowDialog();
        }
        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor del = new DeleteDonor();
            del.ShowDialog();
        }

        private void AdminMainGUI_Load(object sender, EventArgs e)
        {

        }

        private void approveDemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRequestTables req = new AdminRequestTables();
            req.ShowDialog();
        }

    }
}
