using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3_Con_Vectores
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        int contador = 0;
        double[] valores = new double[100];


        private void btRegistrar_Click(object sender, EventArgs e)
        {
            valores[contador] = Convert.ToDouble(tbValor.Text);
            tbValor.Text = "";
            contador++;

        }

      

        private void btnCalcularPromedio_Click_1(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            double promedio = acumulador / contador;
            lbResultado.Text = $"El promedio es: {promedio} ";
            tbResultado.Text = $"El promedio es: {promedio} ";


        }
    }
}
