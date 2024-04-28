using LoginDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class DBGeneral : Form
    {
        public DBGeneral()
        {
            InitializeComponent();
        }

        private void btnDBAccounts_Click(object sender, EventArgs e)
        {
            Hide();
            DBBanend DBB = new DBBanend();
            DBB.ShowDialog();
            Close();
        }

        private void btnBans_Click(object sender, EventArgs e)
        {
            Hide();
            DBPlayer DBP = new DBPlayer();
            DBP.ShowDialog();
            Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Hide();
            CreateAcc CA = new CreateAcc();
            CA.ShowDialog();
            Close();
        }
    }
}
