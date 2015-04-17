using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int cont=0; cont<=255; cont++)
            {
                cmbrojo.Items.Add(cont.ToString());
                cmbazul.Items.Add(cont.ToString());
                cmbverde.Items.Add(cont.ToString());

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncolorfondo_Click(object sender, EventArgs e)
        {
            int rojo, azul, verde;
            rojo = int.Parse(cmbrojo.Text);
            azul = int.Parse(cmbazul.Text);
            verde = int.Parse(cmbverde.Text);
            BackColor = Color.FromArgb(rojo, azul, verde);
        }
    }
}
