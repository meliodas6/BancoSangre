using BancoDeSangre.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre
{
    public partial class FormDonantes : Form
    {
        public FormDonantes()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Fondo3.jpg");
            this.BackgroundImage = img;
        }

        public void CargarDatos(DonantesBL donantesBL, GeneroBL generoBL, TipodeSangreBL tipodeSangre)
        {
            listadeDonantesBindingSource.DataSource =
                donantesBL.ListadeDonantes;

            listaDeGenerosBindingSource.DataSource =
                generoBL.ListaDeGeneros;

            listadeSangreBindingSource.DataSource =
                tipodeSangre.ListadeSangre;
        }

        private void FormDonantes_Load(object sender, EventArgs e)
        {

        }
    }
}
