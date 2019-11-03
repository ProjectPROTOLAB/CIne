using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIneDB
{
    public partial class Main : Form
    {
        AccesoDatos datos;
        public Main()
        {
            InitializeComponent();
            datos = new AccesoDatos(@"Provider=SQLNCLI11;Data Source=T480-00298\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=cine");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                   
                    string sql = "select * from clasificacion_pelicula";
                    
                    dgvConsultas.DataSource= datos.consultar(sql);
                    break;
                case 1:
                    MessageBox.Show("soy el 0");
                    break;
                case 2:
                    MessageBox.Show("soy el 0");
                    break;
                case 3:
                    MessageBox.Show("soy el 0");
                    break;
                case 4:
                    MessageBox.Show("soy el 0");
                    break;
                case 5:
                    MessageBox.Show("soy el 0");
                    break;
                case 6:
                    MessageBox.Show("soy el 0");
                    break;
                case 7:
                    MessageBox.Show("soy el 0");
                    break;
                case 8:
                    MessageBox.Show("soy el 0");
                    break;
                case 9:
                    MessageBox.Show("soy el 0");
                    break;
                case 10:
                    MessageBox.Show("soy el 0");
                    break;
                case 11:
                    MessageBox.Show("soy el 0");
                    break;
                case 12:
                    MessageBox.Show("soy el 0");
                    break;

            }
        }

      
    }
}
