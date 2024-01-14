using System;
using System.Windows.Forms;

namespace Proyecto_Integracion_Continua
{
    public partial class ConversorTiempo : Form
    {
        public ConversorTiempo()
        {
            InitializeComponent();
        }

        private void ConvertirTiempo()
        {
            decimal valorHoras = HorasNumericUpDown.Value;
            decimal valorMinutos = MinutosNumericUpDown.Value;
            decimal valorSegundos = SegundosNumericUpDown.Value;
            decimal valorDias = DiasNumericUpDown.Value;

            if (valorHoras > 0)
            {
                valorMinutos = valorHoras * 60;
                valorSegundos = valorHoras * 3600;
                valorDias = valorHoras / 24;

                MinutosNumericUpDown.Value = valorMinutos;
                SegundosNumericUpDown.Value = valorSegundos;
                DiasNumericUpDown.Value = valorDias;
            }
            else if (valorMinutos > 0)
            {
                valorHoras = valorMinutos / 60;
                valorSegundos = valorMinutos * 60;
                valorDias = valorHoras / 24;

                HorasNumericUpDown.Value = valorHoras;
                SegundosNumericUpDown.Value = valorSegundos;
                DiasNumericUpDown.Value = valorDias;
            }
            else if (valorSegundos > 0)
            {
                valorHoras = valorSegundos / 3600;
                valorMinutos = valorSegundos / 60;
                valorDias = valorHoras / 24;

                HorasNumericUpDown.Value = valorHoras;
                MinutosNumericUpDown.Value = valorMinutos;
                DiasNumericUpDown.Value = valorDias;
            }
            else if (valorDias > 0)
            {
                valorHoras = valorDias * 24;
                valorMinutos = valorHoras * 60;
                valorSegundos = valorHoras * 3600;

                HorasNumericUpDown.Value = valorHoras;
                MinutosNumericUpDown.Value = valorMinutos;
                SegundosNumericUpDown.Value = valorSegundos;
            }
            else
            {
               
                MessageBox.Show("Por favor, ingrese al menos un valor mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            HorasNumericUpDown.Value = 0;
            MinutosNumericUpDown.Value = 0;
            SegundosNumericUpDown.Value = 0;
            DiasNumericUpDown.Value = 0;
        }

        private void ConvertirButton_Click(object sender, EventArgs e)
        {
            ConvertirTiempo();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
