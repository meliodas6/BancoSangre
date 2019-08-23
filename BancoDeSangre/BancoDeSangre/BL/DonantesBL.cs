using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class DonantesBL
    {
        public BindingList<Donantes> ListadeDonantes { get; set; }

        public DonantesBL()
        {
            ListadeDonantes = new BindingList<Donantes>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Tipos de Sangres
            var tipo1 = new TipodeSangre("A Positivo");
            var tipo2 = new TipodeSangre("A Negativo");
            var tipo3 = new TipodeSangre("B Positivo");
            var tipo4 = new TipodeSangre("B Negativo");
            var tipo5 = new TipodeSangre("AB Positivo");
            var tipo6 = new TipodeSangre("AB Negativo");

            //Generos
            var genero1 = new Genero(1, "Masculino");
            var genero2 = new Genero(2, "Femenino");

            //Donantes
            var donante1 = new Donantes(1, "Miguel Lopez", 24, "0504-1995-13422", tipo1, genero1);
            var donante2 = new Donantes(2, "Daniela Martinez", 35, "0511-1984-00263", tipo5, genero2);
            var donante3 = new Donantes(3, "Pedro Mejia", 28, "0501-1991-01452", tipo3, genero1);
            var donante4 = new Donantes(4, "Karla Perez", 31, "0506-1988-33932", tipo2, genero2);

            ListadeDonantes.Add(donante1);
            ListadeDonantes.Add(donante2);
            ListadeDonantes.Add(donante3);
            ListadeDonantes.Add(donante4);
        }
    }
}
