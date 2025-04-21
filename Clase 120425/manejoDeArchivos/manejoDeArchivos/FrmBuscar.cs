using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace manejoDeArchivos
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            string[] array = new string[4];
            StreamReader lectura = File.OpenText("Agenda.txt");
            cadena = lectura.ReadToEnd();

            while (cadena != null)
            {
                array=cadena.Split('|');
                if (textBox1.Text == array[0])
                {
                    textBox2.Text = array[0]; 
                    textBox3.Text=array[1];
                    textBox4.Text=array[2];
                    textBox5.Text =array[3];

                }
            }
            lectura.Close();
        }
    }
}
