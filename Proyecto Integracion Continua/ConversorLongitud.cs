using System;
using System.Windows.Forms;

namespace Proyecto_Integracion_Continua
{
    public partial class Form_ConversorLongitud : Form
    {
        private double _conversion;
        private const double ValorKilometros = 1.60934;

        public Form_ConversorLongitud()
        {
            InitializeComponent();
            _conversion = 0; // Inicializa la variable _conversion a 0.
        }

        /// <summary>
        /// Realiza la conversión de longitud de kilómetros a millas y viceversa, y actualiza los valores en los controles correspondientes.
        /// </summary>
        private void Convertir()

        {
            if (LongitudEnKilometrosNumericUpDown.Value > 0)
            {
                _conversion = (double)LongitudEnKilometrosNumericUpDown.Value / ValorKilometros;
                LongitudEnMillasNumericUpDown.Value = (decimal)_conversion;
            }
            else if (LongitudEnMillasNumericUpDown.Value > 0)
            {

                if (LongitudEnMillasNumericUpDown.Value > 0)
                {
                    _conversion = (double)LongitudEnMillasNumericUpDown.Value * ValorKilometros;
                    LongitudEnKilometrosNumericUpDown.Value = (decimal)_conversion;
                }
            }
        }

        private void ReiniciarValores()

        {
            LongitudEnKilometrosNumericUpDown.Value = 0;
            LongitudEnMillasNumericUpDown.Value = 0;
        }

        private void LongitudEnKilometrosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LongitudEnMillasNumericUpDown.Enabled = LongitudEnKilometrosNumericUpDown.Value <= 0;
        }
        private void LongitudEnMillasNumericUpDown_ValueChanged(object sender, EventArgs e)

        {
            LongitudEnKilometrosNumericUpDown.Enabled = LongitudEnMillasNumericUpDown.Value <= 0;
        }

        private void ConvertirButton_Click(object sender, EventArgs e)
        {
            Convertir();
        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            ReiniciarValores();
        }
    }
}
