using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteikarten.View
{
    public partial class frmUserConfig : Form
    {
        public frmUserConfig()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
            this.Close();
        }
    }
}
