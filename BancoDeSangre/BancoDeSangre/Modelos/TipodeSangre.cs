using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class TipodeSangre
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public TipodeSangre()
        {

        }

        public TipodeSangre(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
