namespace Proyecto_Integracion_Continua
{
    partial class Form_ConversorPeso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConversorPeso));
            this.Lbl_PesoKG = new System.Windows.Forms.Label();
            this.Btn_Convertir = new System.Windows.Forms.Button();
            this.Lbl_PesoLB = new System.Windows.Forms.Label();
            this.pesoEnKilosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pesoEnLibrasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.Img_ConversorPeso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pesoEnKilosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoEnLibrasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_PesoKG
            // 
            this.Lbl_PesoKG.AutoSize = true;
            this.Lbl_PesoKG.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesoKG.Location = new System.Drawing.Point(23, 38);
            this.Lbl_PesoKG.Name = "Lbl_PesoKG";
            this.Lbl_PesoKG.Size = new System.Drawing.Size(310, 19);
            this.Lbl_PesoKG.TabIndex = 0;
            this.Lbl_PesoKG.Text = "Indique el peso en kilogramos (Kg):";
            // 
            // Btn_Convertir
            // 
            this.Btn_Convertir.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convertir.Location = new System.Drawing.Point(539, 31);
            this.Btn_Convertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Convertir.Name = "Btn_Convertir";
            this.Btn_Convertir.Size = new System.Drawing.Size(152, 34);
            this.Btn_Convertir.TabIndex = 3;
            this.Btn_Convertir.Text = "Convertir";
            this.Btn_Convertir.UseVisualStyleBackColor = true;
            this.Btn_Convertir.Click += new System.EventHandler(this.ConvertirButton_Click);
            // 
            // Lbl_PesoLB
            // 
            this.Lbl_PesoLB.AutoSize = true;
            this.Lbl_PesoLB.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesoLB.Location = new System.Drawing.Point(23, 138);
            this.Lbl_PesoLB.Name = "Lbl_PesoLB";
            this.Lbl_PesoLB.Size = new System.Drawing.Size(260, 19);
            this.Lbl_PesoLB.TabIndex = 4;
            this.Lbl_PesoLB.Text = "Indique el peso en libras (Lb):";
            // 
            // pesoEnKilosNumericUpDown
            // 
            this.pesoEnKilosNumericUpDown.DecimalPlaces = 2;
            this.pesoEnKilosNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoEnKilosNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pesoEnKilosNumericUpDown.Location = new System.Drawing.Point(372, 36);
            this.pesoEnKilosNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesoEnKilosNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pesoEnKilosNumericUpDown.Name = "pesoEnKilosNumericUpDown";
            this.pesoEnKilosNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.pesoEnKilosNumericUpDown.TabIndex = 7;
            // 
            // pesoEnLibrasNumericUpDown
            // 
            this.pesoEnLibrasNumericUpDown.DecimalPlaces = 2;
            this.pesoEnLibrasNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoEnLibrasNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pesoEnLibrasNumericUpDown.Location = new System.Drawing.Point(372, 135);
            this.pesoEnLibrasNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesoEnLibrasNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pesoEnLibrasNumericUpDown.Name = "pesoEnLibrasNumericUpDown";
            this.pesoEnLibrasNumericUpDown.Size = new System.Drawing.Size(120, 28);
            this.pesoEnLibrasNumericUpDown.TabIndex = 8;
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reiniciar.Location = new System.Drawing.Point(539, 130);
            this.Btn_Reiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(152, 34);
            this.Btn_Reiniciar.TabIndex = 9;
            this.Btn_Reiniciar.Text = "Reiniciar";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.ReiniciarButton_Click);
            // 
            // Img_ConversorPeso
            // 
            this.Img_ConversorPeso.Image = ((System.Drawing.Image)(resources.GetObject("Img_ConversorPeso.Image")));
            this.Img_ConversorPeso.InitialImage = ((System.Drawing.Image)(resources.GetObject("Img_ConversorPeso.InitialImage")));
            this.Img_ConversorPeso.Location = new System.Drawing.Point(209, 228);
            this.Img_ConversorPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Img_ConversorPeso.Name = "Img_ConversorPeso";
            this.Img_ConversorPeso.Size = new System.Drawing.Size(209, 185);
            this.Img_ConversorPeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_ConversorPeso.TabIndex = 6;
            this.Img_ConversorPeso.TabStop = false;
            // 
            // Form_ConversorPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.pesoEnLibrasNumericUpDown);
            this.Controls.Add(this.pesoEnKilosNumericUpDown);
            this.Controls.Add(this.Img_ConversorPeso);
            this.Controls.Add(this.Lbl_PesoLB);
            this.Controls.Add(this.Btn_Convertir);
            this.Controls.Add(this.Lbl_PesoKG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_ConversorPeso";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proyecto Integracion Continua";
            ((System.ComponentModel.ISupportInitialize)(this.pesoEnKilosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoEnLibrasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_ConversorPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_PesoKG;
        private System.Windows.Forms.Button Btn_Convertir;
        private System.Windows.Forms.Label Lbl_PesoLB;
        private System.Windows.Forms.NumericUpDown pesoEnKilosNumericUpDown;
        private System.Windows.Forms.NumericUpDown pesoEnLibrasNumericUpDown;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.PictureBox Img_ConversorPeso;
    }
}

