using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karteikarten.Model;
using Karteikarten.Controller;

namespace Karteikarten.View
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            UpdateCBThema();
        }

        private void UpdateCBThema()
        {
            cbThema.Items.Clear();
            cbThema_t.Items.Clear();

            SQLController.GetThemas().ForEach(z => cbThema.Items.Add(z.themaName));
            SQLController.GetThemas().ForEach(z => cbThema_t.Items.Add(z.themaName));
        }

        private void btnInsertThema_Click(object sender, EventArgs e)
        {
            /* To recap
            thema t = new thema();
            // t.id =  ("IT IS AUTO INCRMEANT SO WE DON'T GIVE ID")
            t.themaName = txtThema.Text;
            SQLController.InsertThema(t);
            */
            if (txtThema.Text != "")
            {
                SQLController.InsertThema(new thema() { themaName = txtThema.Text });
                MessageBox.Show("New Thema has been Added");
            }
            else
            {
                MessageBox.Show("Please Enter Thema Name");
            }
            txtThema.Text = "";
            UpdateCBThema();
        }


    }
}
