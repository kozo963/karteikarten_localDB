﻿using System;
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
        string _imgPathQ = "";
        string _imgPathA = "";
        public frmAdmin()
        {
            InitializeComponent();
            UpdateCBThema();
        }

        private void UpdateCBThema()
        {
            cbThema.Items.Clear();
            cbThema_t.Items.Clear();
            cb_Thema_UD.Items.Clear();

            SQLController.GetThemas().ForEach(z => cbThema.Items.Add(z.themaName));
            SQLController.GetThemas().ForEach(z => cbThema_t.Items.Add(z.themaName));
            SQLController.GetThemas().ForEach(z => cb_Thema_UD.Items.Add(z.themaName));
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
            
            if (tbQTxt.Text == "" && _imgPathQ == "" || tbATxt.Text == "" && _imgPathA == "" || cbThema.Text == "")
            {
                MessageBox.Show("Please Fill at least \n1 Question\n1 Answer\nSelect the Thema.");
                return;
            }

            karte k = new karte();
            k.qText = tbQTxt.Text;
            k.qImg = FromImgPathToBinary(_imgPathQ);
            k.aText = tbATxt.Text;
            k.aImg = FromImgPathToBinary(_imgPathA);
            k.themaid = SQLController.GetThemaIDByName(cbThema.Text);
            try
            {
                SQLController.AddKarte(k);
                MessageBox.Show("Karte has been added.");
                tbQTxt.Text = "";
                tbATxt.Text = "";
                pbAImg.Image = null;
                pbQImg.Image = null;
                _imgPathQ = "";
                _imgPathA = "";
            }
            catch
            {
                MessageBox.Show("Database Error");
            }
            

        }

        private byte[] FromImgPathToBinary(string imgPath)
        {
            if(imgPath == "")
                return null;
            FileInfo fInfo = new FileInfo(imgPath);
            
            FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] data = br.ReadBytes((int)fInfo.Length);
            return data;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.ShowDialog();
            this.Close();
        }

        // UPDATE AND DELETE TAB
        List<karte> _kartes = new List<karte>();
        karte _currentKarte;
        int _currentIndex;
        private void cb_Thema_UD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int themaID = SQLController.GetThemaIDByName(cb_Thema_UD.Text);
            _kartes =  SQLController.GetKartesByThemaID(themaID);
            if (_kartes.Count == 0)
            {
                MessageBox.Show("No Kartes in this Thema");
                pbQImg_UD.Image = null;
                tbQTxt_UD.Text = "";
                pbAImg_UD.Image = null;
                tbATxt_UD.Text = "";

                lblCurrentKarte.Text = "0";
                lblTotalKarte.Text = "0";

                return;
            }

            _currentIndex = 0;
            _currentKarte = _kartes.ElementAt(_currentIndex);
            lblTotalKarte.Text = _kartes.Count.ToString();
            lblCurrentKarte.Text = (_currentIndex + 1).ToString();
            ShowKarte();
        }

        private void ShowKarte()
        {
            pbQImg_UD.Image = FromByteArrayToImage(_currentKarte.qImg);
            tbQTxt_UD.Text = _currentKarte.qText;

            pbAImg_UD.Image = FromByteArrayToImage(_currentKarte.aImg);
            tbATxt_UD.Text = _currentKarte.aText;

            lblCurrentKarte.Text = (_currentIndex + 1).ToString();
        }

        private Image FromByteArrayToImage(byte[] img)
        {
            if (img == null)
                return null;

            MemoryStream stream = new MemoryStream(img);
            Image image = Image.FromStream(stream);
            return image;
        }

        private void btnPreviousUD_Click(object sender, EventArgs e)
        {
            if (_kartes.Count == 0)
                return;
            if (_currentIndex == 0)
            {
                MessageBox.Show("this is the first Karte");
                return;
            }
            _currentIndex--;
            _currentKarte = _kartes.ElementAt(_currentIndex);
            ShowKarte();
        }

        private void btnNextUD_Click(object sender, EventArgs e)
        {
            if (_kartes.Count == 0)
                return;
            if (_currentIndex == _kartes.Count - 1)
            {
                MessageBox.Show("this was last Karte");
                return;
            }
            _currentIndex++;
            _currentKarte = _kartes.ElementAt(_currentIndex);
            ShowKarte();
        }


        private void btnUpdate_UD_Click(object sender, EventArgs e)
        {
            if (tbQTxt_UD.Text == "" && _imgPathQ == "" || tbATxt_UD.Text == "" && _imgPathA == "" || cb_Thema_UD.Text == "")
            {
                MessageBox.Show("Please Fill at least \n1 Question\n1 Answer");
                return;
            }

            karte karte = new karte();
            karte.id = _currentKarte.id;
            karte.aText = tbATxt_UD.Text;
            karte.qText = tbQTxt_UD.Text;
            karte.aImg = FromImgPathToBinary(_imgPathA);
            karte.qImg = FromImgPathToBinary(_imgPathQ);
            karte.themaid = _currentKarte.themaid;

            try
            {
                SQLController.UpdateKarte(karte);
                MessageBox.Show("Karte has been updated");
            }
            catch
            {
                MessageBox.Show("Error while Updating");
            }

        }


        //SPAGHETTI
        private void btnQImg_UD_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.jgp; *.jpeg; *.png; *.jfif) | *.jpg; *.jpeg; *.png; *.jfif";
            if (o.ShowDialog() == DialogResult.OK)
            {
                pbQImg_UD.Image = new Bitmap(o.FileName);
                _imgPathQ = Path.GetFullPath(o.FileName);
            }
        }

        private void btnAImg_UD_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.jgp; *.jpeg; *.png; *.jfif) | *.jpg; *.jpeg; *.png; *.jfif";
            if (o.ShowDialog() == DialogResult.OK)
            {
                pbAImg_UD.Image = new Bitmap(o.FileName);
                _imgPathA = Path.GetFullPath(o.FileName);
            }
        }

        private void btnDelete_UD_Click(object sender, EventArgs e)
        {
            try
            {
                SQLController.DeleteKarte(_currentKarte);
                MessageBox.Show("Karte has been Deleted");
                cb_Thema_UD.SelectedIndex = cb_Thema_UD.Items.IndexOf(cb_Thema_UD.Text);
                cb_Thema_UD_SelectedIndexChanged(null,null);
            }
            catch
            {
                MessageBox.Show("Error while deleting Karte");
            }
        }

        private void tabUpdateDelete_Enter(object sender, EventArgs e)
        {
            UpdateCBThema();
            pbQImg_UD.Image = null;
            tbQTxt_UD.Text = "";
            pbAImg_UD.Image = null;
            tbATxt_UD.Text = "";

            lblCurrentKarte.Text = "0";
            lblTotalKarte.Text = "0";
        }
    }
}
