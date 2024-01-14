using System;
using System.Windows.Forms;

namespace Proyecto_Integracion_Continua
{
    /// <summary>
    /// Formulario conversor de peso
    /// </summary>
    public partial class Form_ConversorPeso : Form
    {
        /// <summary>
        /// Variables y constantes
        /// </summary>
        private const double ValorKilos = 2.20462262185;

        /// <summary>
        /// Constructor de los componentes y variables del formulario
        /// </summary>
        public Form_ConversorPeso()
        {
            InitializeComponent();
        }

        private void Convertir()
        {
            if (pesoEnKilosNumericUpDown.Value > 0)
            {
                double conversion = (double)pesoEnKilosNumericUpDown.Value * ValorKilos;
                pesoEnLibrasNumericUpDown.Value = (decimal)conversion;
            }
            else if (pesoEnLibrasNumericUpDown.Value > 0)
            {

                if (pesoEnLibrasNumericUpDown.Value > 0)
                {
                    pesoEnKilosNumericUpDown.Value = (decimal)((double)pesoEnLibrasNumericUpDown.Value / ValorKilos);
                }
            }
        }


        private void ReiniciarValores()
        {
            pesoEnKilosNumericUpDown.Value = 0;
            pesoEnLibrasNumericUpDown.Value = 0;
        }

        private void PesoEnKilosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pesoEnLibrasNumericUpDown.Enabled = pesoEnKilosNumericUpDown.Value <= 0;
        }

        private void PesoEnLibrasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pesoEnKilosNumericUpDown.Enabled = pesoEnLibrasNumericUpDown.Value <= 0;
        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            ReiniciarValores();
        }

        private void ConvertirButton_Click(object sender, EventArgs e)
        {
            Convertir();
        }
    }
}
