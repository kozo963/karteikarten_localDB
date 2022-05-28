using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karteikarten.Model;
using Karteikarten.Controller;

namespace Karteikarten.View
{
    public partial class frmAdmin : Form
    {
        string _imgPathQ;
        string _imgPathA;
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

        private void btnQImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.jgp; *.jpeg; *.png; *.jfif) | *.jpg; *.jpeg; *.png; *.jfif";
            if (o.ShowDialog() == DialogResult.OK)
            {
                pbQImg.Image = new Bitmap(o.FileName);
                _imgPathQ = Path.GetFullPath(o.FileName);
            }
        }
        private void btnAImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.jgp; *.jpeg; *.png; *.jfif) | *.jpg; *.jpeg; *.png; *.jfif";
            if (o.ShowDialog() == DialogResult.OK)
            {
                pbAImg.Image = new Bitmap(o.FileName);
                _imgPathA = Path.GetFullPath(o.FileName);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            karte k = new karte();
            k.qText = tbQTxt.Text;
            k.qImg = FromImgPathToBinary(_imgPathQ);
            k.aText = tbATxt.Text;
            k.aImg = FromImgPathToBinary(_imgPathA);
            k.themaid = SQLController.GetThemaIDByName(cbThema.Text);

            SQLController.AddKarte(k);
        }

        private byte[] FromImgPathToBinary(string imgPath)
        {
            if(imgPath == null)
                return null;
            FileInfo fInfo = new FileInfo(imgPath);
            
            FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] data = br.ReadBytes((int)fInfo.Length);
            return data;
        }


    }
}
