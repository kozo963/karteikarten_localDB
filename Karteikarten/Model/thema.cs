using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten.Model
{
    public class thema
    {
        public int id { get; set; }
        public string themaName { get; set; }
        public virtual ICollection<karte> karte { get; set; }
    }
}
