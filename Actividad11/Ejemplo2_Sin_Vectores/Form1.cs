using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2_Sin_Vectores
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        int contador = 0;
        double acumulador = 0;

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            acumulador += Convert.ToDouble(tbValor.Text);
            tbValor.Text = "";
            contador++;

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio = acumulador / contador;
                lbResultado.Text = $"El promedio es: {promedio} ";
                tbResultado.Text = $"El promedio es: {promedio} ";
            }

        }
    }
}
