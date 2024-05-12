using P1AFm.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AFm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido!!!!");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
         
        }
        int intentos = 0;
        private void btnIngreso_Click(object sender, EventArgs e)
        {

            labeltitulo.Text = "Bienvenido a mi App";

            if (textBoxusr.Text.Equals("admin", StringComparison.OrdinalIgnoreCase) && textBoxpwd.Text.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                FrmIngreso format = new FrmIngreso();
                format.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválido");
                intentos++;
                textBoxusr.Clear();
                textBoxpwd.Clear();

                if (intentos >= 3)
                {
                    btnIngreso.Enabled = false;
                }
                else
                {
                    btnIngreso.Enabled = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
