using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliate.Control
{
    public class Questao
    {
        public string titulo { get; set; }
        public string id { get; set; }

        public override string ToString()
        {
            return this.id;
        }
    }
}
