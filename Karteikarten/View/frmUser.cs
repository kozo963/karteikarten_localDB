using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karteikarten.Model;

namespace Karteikarten.View
{
    public partial class frmUser : Form
    {
        List<karte> _kartes = new List<karte>();
        int _currentKarteNum;
        karte _k;
        int _correct_AnswerTotal;
        public frmUser(List<karte> kartes)
        {
            InitializeComponent();
            _kartes = kartes;
            _currentKarteNum = 0;
            _k = _kartes.ElementAt(_currentKarteNum);
            _correct_AnswerTotal = 0;
            lblTotalQ.Text = _kartes.Count.ToString();
            lblCorrectA.Text = _correct_AnswerTotal.ToString();

            SetQuestion();
        }

        private void SetQuestion()
        {
            pbQImg.Image = FromByteArrayToImage(_k.qImg);
            tbQTxt.Text = _k.qText;

            pbAImg.Image = null;
            tbATxt.Text = "";

            btnCorrect.Enabled = false;
            btnFalse.Enabled = false;

            btnShowAnswer.Enabled = true;

            btnNext.Enabled = false;
        }


        private Image FromByteArrayToImage(byte[] img)
        {
            if (img == null)
                return null;

            MemoryStream stream = new MemoryStream(img);
            Image image = Image.FromStream(stream);
            return image;
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            pbAImg.Image = FromByteArrayToImage(_k.aImg);
            tbATxt.Text = _k.aText;

            btnCorrect.Enabled = true;
            btnFalse.Enabled = true;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            _correct_AnswerTotal++;
            lblCorrectA.Text = _correct_AnswerTotal.ToString();

            btnCorrect.Enabled = false;
            btnFalse.Enabled = false;

            btnShowAnswer.Enabled = false;
            btnNext.Enabled = true;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            btnCorrect.Enabled = false;
            btnFalse.Enabled = false;

            btnShowAnswer.Enabled = false;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentKarteNum == _kartes.Count - 1)
            {
                MessageBox.Show("Game Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _currentKarteNum++;
            _k = _kartes.ElementAt(_currentKarteNum);
            SetQuestion();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserConfig frmUserConfig = new frmUserConfig();
            frmUserConfig.ShowDialog();
            this.Close();
        }
    }
}
