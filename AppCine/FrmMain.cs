using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppCine
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppCine.FrmCargarPelicula formCargarPeli = new FrmCargarPelicula();
            formCargarPeli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppCine.FrmCargarFunciones FrmCargarFuncion = new FrmCargarFunciones();
            FrmCargarFuncion.ShowDialog();
        }
    }
}
