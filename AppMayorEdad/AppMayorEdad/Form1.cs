using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMayorEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            persona persona1 = new persona(TXTNOMBRE.Text, int.Parse(TXTEDAD.Text));
            if (persona1.Edad >= 18)
            {
                MessageBox.Show("LA edad de: " + persona1.Nombre + " es " + persona1.Edad + "años,  mayor de 18");
            }
            else
            {
                MessageBox.Show("LA edad de: " + persona1.Nombre + " es  " + persona1.Edad + " años, menor de 18");
            }
        }
    }
}
