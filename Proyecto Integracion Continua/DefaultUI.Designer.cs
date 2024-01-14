namespace Proyecto_Integracion_Continua
{
    partial class Form_DefaultUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DefaultUI));
            this.Btn_ConversorPeso = new System.Windows.Forms.Button();
            this.Btn_ConversorLongitud = new System.Windows.Forms.Button();
            this.Lbl_Mensaje = new System.Windows.Forms.Label();
            this.Img_ConversorUnidades = new System.Windows.Forms.PictureBox();
            this.Btn_ConversorVelocidad = new System.Windows.Forms.Button();
            this.Btn_ConversorTiempo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ConversorPeso
            // 
            this.Btn_ConversorPeso.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConversorPeso.Location = new System.Drawing.Point(56, 93);
            this.Btn_ConversorPeso.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ConversorPeso.Name = "Btn_ConversorPeso";
            this.Btn_ConversorPeso.Size = new System.Drawing.Size(87, 43);
            this.Btn_ConversorPeso.TabIndex = 10;
            this.Btn_ConversorPeso.Text = "Conversor de Peso";
            this.Btn_ConversorPeso.UseVisualStyleBackColor = true;
            this.Btn_ConversorPeso.Click += new System.EventHandler(this.Btn_ConversorPeso_Click);
            // 
            // Btn_ConversorLongitud
            // 
            this.Btn_ConversorLongitud.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConversorLongitud.Location = new System.Drawing.Point(186, 93);
            this.Btn_ConversorLongitud.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ConversorLongitud.Name = "Btn_ConversorLongitud";
            this.Btn_ConversorLongitud.Size = new System.Drawing.Size(98, 43);
            this.Btn_ConversorLongitud.TabIndex = 11;
            this.Btn_ConversorLongitud.Text = "Conversor de Longitud";
            this.Btn_ConversorLongitud.UseVisualStyleBackColor = true;
            this.Btn_ConversorLongitud.Click += new System.EventHandler(this.Btn_ConversorLongitud_Click);
            // 
            // Lbl_Mensaje
            // 
            this.Lbl_Mensaje.AutoSize = true;
            this.Lbl_Mensaje.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensaje.Location = new System.Drawing.Point(10, 22);
            this.Lbl_Mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Mensaje.Name = "Lbl_Mensaje";
            this.Lbl_Mensaje.Size = new System.Drawing.Size(661, 45);
            this.Lbl_Mensaje.TabIndex = 12;
            this.Lbl_Mensaje.Text = "Bienvenido a nuestro sistema de conversión de unidades.\r\n\r\nPor favor seleccione a" +
    "lguna de las opciones disponibles, presionando en uno de los botones de abajo.";
            this.Lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Img_ConversorUnidades
            // 
            this.Img_ConversorUnidades.Image = ((System.Drawing.Image)(resources.GetObject("Img_ConversorUnidades.Image")));
            this.Img_ConversorUnidades.InitialImage = ((System.Drawing.Image)(resources.GetObject("Img_ConversorUnidades.InitialImage")));
            this.Img_ConversorUnidades.Location = new System.Drawing.Point(234, 177);
            this.Img_ConversorUnidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Img_ConversorUnidades.Name = "Img_ConversorUnidades";
            this.Img_ConversorUnidades.Size = new System.Drawing.Size(200, 203);
            this.Img_ConversorUnidades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_ConversorUnidades.TabIndex = 13;
            this.Img_ConversorUnidades.TabStop = false;
            // 
            // Btn_ConversorVelocidad
            // 
            this.Btn_ConversorVelocidad.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConversorVelocidad.Location = new System.Drawing.Point(334, 93);
            this.Btn_ConversorVelocidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ConversorVelocidad.Name = "Btn_ConversorVelocidad";
            this.Btn_ConversorVelocidad.Size = new System.Drawing.Size(114, 42);
            this.Btn_ConversorVelocidad.TabIndex = 14;
            this.Btn_ConversorVelocidad.Text = "Conversor de Velocidad";
            this.Btn_ConversorVelocidad.UseMnemonic = false;
            this.Btn_ConversorVelocidad.UseVisualStyleBackColor = true;
            this.Btn_ConversorVelocidad.Click += new System.EventHandler(this.Btn_ConversorVelocidad_Click);
            // 
            // Btn_ConversorTiempo
            // 
            this.Btn_ConversorTiempo.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConversorTiempo.Location = new System.Drawing.Point(499, 93);
            this.Btn_ConversorTiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ConversorTiempo.Name = "Btn_ConversorTiempo";
            this.Btn_ConversorTiempo.Size = new System.Drawing.Size(114, 42);
            this.Btn_ConversorTiempo.TabIndex = 15;
            this.Btn_ConversorTiempo.Text = "Conversor de Tiempo";
            this.Btn_ConversorTiempo.UseVisualStyleBackColor = true;
            this.Btn_ConversorTiempo.Click += new System.EventHandler(this.Btn_ConversorTiempo_Click);
            // 
            // Form_DefaultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.Btn_ConversorTiempo);
            this.Controls.Add(this.Btn_ConversorVelocidad);
            this.Controls.Add(this.Img_ConversorUnidades);
            this.Controls.Add(this.Lbl_Mensaje);
            this.Controls.Add(this.Btn_ConversorLongitud);
            this.Controls.Add(this.Btn_ConversorPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_DefaultUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Integracion Continua";
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ConversorPeso;
        private System.Windows.Forms.Button Btn_ConversorLongitud;
        private System.Windows.Forms.Label Lbl_Mensaje;
        private System.Windows.Forms.PictureBox Img_ConversorUnidades;
        private System.Windows.Forms.Button Btn_ConversorVelocidad;
        private System.Windows.Forms.Button Btn_ConversorTiempo;
    }
}