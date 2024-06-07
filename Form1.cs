using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Eficiência_do_carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int V = Convert.ToInt32(textBoxV.Text);
            int T = Convert.ToInt32(textBoxT.Text);
            int E = Convert.ToInt32(textBoxE.Text);

            double D = (V * T) / E;
            lblE.Text = "Eficiência por km é: " + D.ToString();
        }
    }
}
