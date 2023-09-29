using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// para agregar  la la cosa de toolbox en serch y buscamos esa madre
namespace formMultidim
{
    public partial class Form1 : Form
    {
        private bool intro=true;
        private Multidimensional m1;
        private Multidimensional m2;
        private Multidimensional m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (intro)
            {
                m1= Multidimensional.Leer(textBox1.Text);
                lbmatriz1.Text=m1.ToString();
                intro = false;
            }
            else
            {
                m2 = Multidimensional.Leer(textBox1.Text);
                lbmatriz2.Text = m2.ToString();
                intro = false;
            }
            textBox1.Clear();
        }

        

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Deg Seleccionado");
            }
            m3 = m1 + m2;
            txtbresultado.Text = m3.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }
    }
}
