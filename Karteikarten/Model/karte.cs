using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten.Model
{
    public class karte
    {
        public int id { get; set; }
        public string qText { get; set; }
        public byte[] qImg { get; set; }
        public string aText { get; set; }
        public byte[] aImg { get; set; }
        public int themaid { get; set; }
        public virtual thema thema { get; set; }
    }
}
