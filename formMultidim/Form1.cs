using System;
using System.Windows.Forms;

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

        private void btnIntro_Click(object sender, EventArgs e)
        {
            if (intro)
            {
                m1 = Multidimensional.Leer(textBox1.Text);
                lbmatriz1.Text = m1.ToString();
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
            m3 = m1 - m2;
            txtbresultado.Text = m3.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            
            m3 = m1 * m2;
            txtbresultado.Text = m3.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked) //radians
            {
                MessageBox.Show("Rad Seleccionado"); //%
                m3 = m1 % m2;
                txtbresultado.Text = m3.ToString();

            }
            else
            {
                if (radioButton2.Checked) //degrees
                {
                    MessageBox.Show("Deg Seleccionado"); //&
                    m3 = m3 & m2; ;

                    txtbresultado.Text = m3.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccionar Rad o Deg");
                }
            }
            
        }
    }
}

