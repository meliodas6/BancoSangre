using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
   public class TipodeSangreBL
    {
        public BindingList<TipodeSangre> ListadeSangre { get; set; }

        public TipodeSangreBL()
        {
            ListadeSangre = new BindingList<TipodeSangre>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var tipo1 = new TipodeSangre("A Positivo");
            var tipo2 = new TipodeSangre("A Negativo");
            var tipo3 = new TipodeSangre("B Positivo");
            var tipo4 = new TipodeSangre("B Negativo");
            var tipo5 = new TipodeSangre("O Positivo");
            var tipo6 = new TipodeSangre("O Negativo");
            var tipo7 = new TipodeSangre("AB Positivo");
            var tipo8 = new TipodeSangre("AB Negativo");

            ListadeSangre.Add(tipo1);
            ListadeSangre.Add(tipo2);
            ListadeSangre.Add(tipo3);
            ListadeSangre.Add(tipo4);
            ListadeSangre.Add(tipo5);
            ListadeSangre.Add(tipo6);
            ListadeSangre.Add(tipo7);
            ListadeSangre.Add(tipo8);
        }
    }
}
