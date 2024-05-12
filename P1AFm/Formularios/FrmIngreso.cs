using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AFm.Formularios
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        decimal vuno, vdos, res;
        private void button1_Click(object sender, EventArgs e)
        {
            vuno = decimal.Parse(uno.Text);
            vdos = decimal.Parse(dos.Text);
            res = vuno + vdos;
            resultado.Text= res.ToString();

            comboBoxFacultades.Items.Add("Ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");



        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem.ToString());
        }
    }
}
