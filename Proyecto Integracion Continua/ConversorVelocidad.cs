using System;
using System.Windows.Forms;

namespace Proyecto_Integracion_Continua
{
    public partial class ConversorVelocidad : Form
    {
        public ConversorVelocidad()
        {
            InitializeComponent();
        }

        private void ConvertirVelocidad()
        {
            decimal valorKmh = KmhNumericUpDown.Value;
            decimal valorMph = MphNumericUpDown.Value;
            decimal valorMs = MsNumericUpDown.Value;

            if (valorKmh > 0)
            {
                valorMph = valorKmh * (decimal)0.621371;
                valorMs = valorKmh / (decimal)3.6;

                MphNumericUpDown.Value = valorMph;
                MsNumericUpDown.Value = valorMs;
            }
            else if (valorMph > 0)
            {
                valorKmh = valorMph / (decimal)0.621371;
                valorMs = valorKmh / (decimal)3.6;

                KmhNumericUpDown.Value = valorKmh;
                MsNumericUpDown.Value = valorMs;
            }
            else if (valorMs > 0)
            {
                valorKmh = valorMs * (decimal)3.6;
                valorMph = valorKmh * (decimal)0.621371;

                KmhNumericUpDown.Value = valorKmh;
                MphNumericUpDown.Value = valorMph;
            }
            else
            {
                // Manejo de caso en el que todos los valores son cero o inválidos
                MessageBox.Show("Por favor, ingrese al menos un valor mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void LimpiarCampos()
        {
            KmhNumericUpDown.Value = 0;
            MphNumericUpDown.Value = 0;
            MsNumericUpDown.Value = 0;
        }

        private void ConvertirButton_Click(object sender, EventArgs e)
        {
            ConvertirVelocidad();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}


