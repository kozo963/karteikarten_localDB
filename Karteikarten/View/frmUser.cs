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

namespace Karteikarten.View
{
    public partial class frmUser : Form
    {
        public List<karte> _kartes = new List<karte>();
        public frmUser(List<karte> kartes)
        {
            InitializeComponent();
            _kartes = kartes;
        }
    }
}
