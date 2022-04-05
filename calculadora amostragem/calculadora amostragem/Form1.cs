using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_amostragem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z = cbox_nivelConfia.Text;
           
        }
        private void txterroAmostral_TextChanged(object sender, EventArgs e)
        {
            string ez= txterroAmostral.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Z = 0, P, E;
            int N;
            string valor;

            P = double.Parse(txtEstimativa.Text);
            P /= 100;
            E = double.Parse(txterroAmostral.Text);
            E /= 100;
            valor = cbox_nivelConfia.Text;

            if(valor == "90%")
            {
                Z = 1.65F;
            }
            if(valor == "95%")
            {
                Z = 1.96F;
            }
            if(valor == "95.5%")
            {
                Z = 2F;
            }
            if(valor == "99%")
            {
                Z = 2.57F;
            }

            N = int.Parse(txtPopulacao.Text, CultureInfo.InvariantCulture);

            var amostra_tamanho = (float) ((N * Math.Pow(Z, 2)) * P * (1 - P)) / ((Math.Pow(E, 2)) * (N - 1) + Math.Pow(Z, 2) * P * (1 - P));

            string Resultado = String.Format("{0:0.00}", amostra_tamanho);

            MessageBox.Show(Resultado, "Resultado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string n = txtPopulacao.Text;
        }

        private void txtEstimativa_TextChanged(object sender, EventArgs e)
        {
            string p = txtEstimativa.Text;
            if (p != "50")
            {
                p = txtEstimativa.Text;
            }
            else
            {
                txtEstimativa.Text = "50";
            }
        }
        
    }
}
