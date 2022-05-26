using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karteikarten.Controller;
namespace Karteikarten.View
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            EFController controller = new EFController();
            dataGridView1.DataSource = controller.thema.ToList();
        }
    }
}
