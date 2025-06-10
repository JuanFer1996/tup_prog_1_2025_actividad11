using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class FormPrncipal : Form
    {
        public FormPrncipal()
        {
            InitializeComponent();
        }
        double promedio = 0;
        int contador = 0;
        double[] valores = new double[100];
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            valores[contador] = Convert.ToDouble(tbValor.Text);
            tbValor.Text = "";
            contador++;

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            promedio = acumulador / contador;
            lbResultado.Text = $"El promedio es: {promedio} ";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            bool encotado = false;
            for (int i = 0; i < contador; i++)
            {
                if (valores[i] == Convert.ToDouble(tbBuscar.Text))
                {
                    lbResultadoBusqueda.Text = $"El valor {tbBuscar.Text} se encuentra en la posición {i + 1}";
                    encotado = true;
                }

            }
            if (!encotado)
            {
                lbResultadoBusqueda.Text = $"El valor {tbBuscar.Text} no se encuentra en la lista";
            }
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            double aux;

            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }

            for (int i = 0; i < contador; i++)
            {

                tbResultado.Text += $"{valores[i]} ";


            }

        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            double max = valores[0];
            for (int i = 0; i < contador; i++)
            {
                if (valores[i] > max)
                {
                    max = valores[i];
                }
            }
            lbMaximo.Text = Convert.ToString(max);
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            double min = valores[0];
            for (int i = 0; i < contador; i++)
            {
                if (valores[i] < min)
                {

                    min = valores[i];

                }
                lbMinimo.Text = Convert.ToString(min);
            }
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            

            for (int i = 0; i < contador; i++)
            {
                if (valores[i]>promedio)
                tbResultado.Text += $"{valores[i]} ";


            }


        }
    }
}