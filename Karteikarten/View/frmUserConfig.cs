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
using Karteikarten.Model;

namespace Karteikarten.View
{
    public partial class frmUserConfig : Form
    {
        public frmUserConfig()
        {
            InitializeComponent();
            InitCBL();
            rbAll.Checked = true;
        }

        private void InitCBL()
        {
            List<ThemaHelper> themaHelpers = SQLController.GetThemasWithCount();
            cbl.DataBindings.Clear();
            themaHelpers.ForEach(t => cbl.Items.Add(t.themaName + "\t(" + t.karteTotal + ")"));
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

            bool found = false;
            for (int i = 0; i < cbl.Items.Count; i++)
            {
                if (cbl.GetItemChecked(i))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                int? totalQuestions = null;
                if (rbNum.Checked == true && txtQNumber.Text != "")
                {
                    try
                    {
                        totalQuestions = int.Parse(txtQNumber.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter only Digits [0-9].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                List<karte> kartes = GetKartes(totalQuestions);

                this.Hide();
                frmUser frmUser = new frmUser(kartes);
                frmUser.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select Thema","Error",MessageBoxButtons.OK);
            }
        }

        private List<karte> GetKartes(int? total)
        {
            List<thema> themas = SQLController.GetThemas();
            List<karte> kartes = new List<karte>();



            for (int i = 0; i < cbl.Items.Count; i++)
            {
                if (cbl.GetItemChecked(i))
                {
                    foreach (thema t in themas)
                    {
                        if (cbl.Items[i].ToString().Contains(t.themaName))
                        {
                            kartes.AddRange(SQLController.GetKartesByThemaID(t.id));
                        }
                    }
                }
            }

            kartes = Randoming(kartes);


            if (total.HasValue)
            {
                while (total < kartes.Count)
                {
                    kartes.RemoveAt(0);
                }
            }



            return kartes;
        }

        private List<karte> Randoming(List<karte> k)
        {
            List<karte> temp = new List<karte>();
            Random ran = new Random();

            while (k.Count > 0)
            {
                int index = ran.Next(0, k.Count);
                temp.Add(k[index]);
                k.RemoveAt(index);
            }

            
            return temp;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbl.Items.Count; i++)
            {
                cbl.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbl.Items.Count; i++)
            {
                cbl.SetItemChecked(i, false);
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            txtQNumber.Enabled = false;
        }

        private void rbNum_CheckedChanged(object sender, EventArgs e)
        {
            txtQNumber.Enabled = true;
        }
    }
}
