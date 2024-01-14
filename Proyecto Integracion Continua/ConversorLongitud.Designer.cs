namespace Proyecto_Integracion_Continua
{
    partial class Form_ConversorLongitud
    {
        /// <summary>
        /// Required designer variable.
        /// date 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// prueba 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConversorLongitud));
            this.ReiniciarButton = new System.Windows.Forms.Button();
            this.LongitudEnMillasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LongitudEnKilometrosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Img_ConversorLongitud = new System.Windows.Forms.PictureBox();
            this.Lbl_LongitudMi = new System.Windows.Forms.Label();
            this.ConvertirButton = new System.Windows.Forms.Button();
            this.Lbl_LongitudKm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudEnMillasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudEnKilometrosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorLongitud)).BeginInit();
            this.SuspendLayout();
            // 
            // ReiniciarButton
            // 
            this.ReiniciarButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReiniciarButton.Location = new System.Drawing.Point(519, 146);
            this.ReiniciarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReiniciarButton.Name = "ReiniciarButton";
            this.ReiniciarButton.Size = new System.Drawing.Size(152, 34);
            this.ReiniciarButton.TabIndex = 16;
            this.ReiniciarButton.Text = "Reiniciar";
            this.ReiniciarButton.UseVisualStyleBackColor = true;
            this.ReiniciarButton.Click += new System.EventHandler(this.ReiniciarButton_Click);
            // 
            // LongitudEnMillasNumericUpDown
            // 
            this.LongitudEnMillasNumericUpDown.DecimalPlaces = 2;
            this.LongitudEnMillasNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudEnMillasNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LongitudEnMillasNumericUpDown.Location = new System.Drawing.Point(367, 151);
            this.LongitudEnMillasNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LongitudEnMillasNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LongitudEnMillasNumericUpDown.Name = "LongitudEnMillasNumericUpDown";
            this.LongitudEnMillasNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.LongitudEnMillasNumericUpDown.TabIndex = 15;
            // 
            // LongitudEnKilometrosNumericUpDown
            // 
            this.LongitudEnKilometrosNumericUpDown.DecimalPlaces = 2;
            this.LongitudEnKilometrosNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudEnKilometrosNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LongitudEnKilometrosNumericUpDown.Location = new System.Drawing.Point(367, 52);
            this.LongitudEnKilometrosNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LongitudEnKilometrosNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LongitudEnKilometrosNumericUpDown.Name = "LongitudEnKilometrosNumericUpDown";
            this.LongitudEnKilometrosNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.LongitudEnKilometrosNumericUpDown.TabIndex = 14;
            // 
            // Img_ConversorLongitud
            // 
            this.Img_ConversorLongitud.Image = ((System.Drawing.Image)(resources.GetObject("Img_ConversorLongitud.Image")));
            this.Img_ConversorLongitud.InitialImage = ((System.Drawing.Image)(resources.GetObject("Img_ConversorLongitud.InitialImage")));
            this.Img_ConversorLongitud.Location = new System.Drawing.Point(204, 244);
            this.Img_ConversorLongitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Img_ConversorLongitud.Name = "Img_ConversorLongitud";
            this.Img_ConversorLongitud.Size = new System.Drawing.Size(209, 185);
            this.Img_ConversorLongitud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_ConversorLongitud.TabIndex = 13;
            this.Img_ConversorLongitud.TabStop = false;
            // 
            // Lbl_LongitudMi
            // 
            this.Lbl_LongitudMi.AutoSize = true;
            this.Lbl_LongitudMi.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LongitudMi.Location = new System.Drawing.Point(17, 154);
            this.Lbl_LongitudMi.Name = "Lbl_LongitudMi";
            this.Lbl_LongitudMi.Size = new System.Drawing.Size(300, 19);
            this.Lbl_LongitudMi.TabIndex = 12;
            this.Lbl_LongitudMi.Text = "Indique la longitud en millas (Mi):";
            // 
            // ConvertirButton
            // 
            this.ConvertirButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertirButton.Location = new System.Drawing.Point(519, 47);
            this.ConvertirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConvertirButton.Name = "ConvertirButton";
            this.ConvertirButton.Size = new System.Drawing.Size(152, 34);
            this.ConvertirButton.TabIndex = 11;
            this.ConvertirButton.Text = "Convertir";
            this.ConvertirButton.UseVisualStyleBackColor = true;
            this.ConvertirButton.Click += new System.EventHandler(this.ConvertirButton_Click);
            // 
            // Lbl_LongitudKm
            // 
            this.Lbl_LongitudKm.AutoSize = true;
            this.Lbl_LongitudKm.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LongitudKm.Location = new System.Drawing.Point(17, 54);
            this.Lbl_LongitudKm.Name = "Lbl_LongitudKm";
            this.Lbl_LongitudKm.Size = new System.Drawing.Size(343, 19);
            this.Lbl_LongitudKm.TabIndex = 10;
            this.Lbl_LongitudKm.Text = "Indique la longitud en kilometros (Km):";
            // 
            // Form_ConversorLongitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 458);
            this.Controls.Add(this.ReiniciarButton);
            this.Controls.Add(this.LongitudEnMillasNumericUpDown);
            this.Controls.Add(this.LongitudEnKilometrosNumericUpDown);
            this.Controls.Add(this.Img_ConversorLongitud);
            this.Controls.Add(this.Lbl_LongitudMi);
            this.Controls.Add(this.ConvertirButton);
            this.Controls.Add(this.Lbl_LongitudKm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_ConversorLongitud";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proyecto Integracion Continua";
            ((System.ComponentModel.ISupportInitialize)(this.LongitudEnMillasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudEnKilometrosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorLongitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReiniciarButton;
        private System.Windows.Forms.NumericUpDown LongitudEnMillasNumericUpDown;
        private System.Windows.Forms.NumericUpDown LongitudEnKilometrosNumericUpDown;
        private System.Windows.Forms.PictureBox Img_ConversorLongitud;
        private System.Windows.Forms.Label Lbl_LongitudMi;
        private System.Windows.Forms.Button ConvertirButton;
        private System.Windows.Forms.Label Lbl_LongitudKm;
    }
}