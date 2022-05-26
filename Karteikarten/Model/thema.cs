using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten.Model
{
    public class thema
    {
        public thema()
        {
            this.karte = new HashSet<karte>();
        }
        public int id { get; set; }
        public string themaName { get; set; }
        public virtual ICollection<karte> karte { get; set; }
    }
}
