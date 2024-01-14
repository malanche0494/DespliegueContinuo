using System;
using System.Windows.Forms;

namespace Proyecto_Integracion_Continua
{
    /// <summary>
    /// Formulario principal de la aplicación.
    /// </summary>
    public partial class Form_DefaultUI : Form
    {
        /// <summary>
        /// Constructor para inicializar los componentes del formulario.
        /// </summary>
        public Form_DefaultUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para abrir el formulario de Conversión de Peso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ConversorPeso_Click(object sender, EventArgs e)
        {
            Form_ConversorPeso ConversorPeso = new Form_ConversorPeso(); //Creación instancia de formulario de Conversion de Peso

            ConversorPeso.ShowDialog(); //Mostrar formulario de Conversion de Peso
        }
        /// <summary>
        /// Método para abrir el formulario de Conversión de Longitud.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ConversorLongitud_Click(object sender, EventArgs e)
        {
            Form_ConversorLongitud ConversorLongitud = new Form_ConversorLongitud(); //Creación instancia de formulario de Conversion de Longitud
                       
            ConversorLongitud.ShowDialog(); //Mostrar formulario de Conversion de Longitud
        }

        private void Btn_ConversorVelocidad_Click(object sender, EventArgs e)
        {
            ConversorVelocidad ConversorVelocidad = new ConversorVelocidad();
            ConversorVelocidad.ShowDialog();
        }

        private void Btn_ConversorTiempo_Click(object sender, EventArgs e)
        {
            ConversorTiempo conversortiempo = new ConversorTiempo();
            conversortiempo.ShowDialog();
        }
    }
}
