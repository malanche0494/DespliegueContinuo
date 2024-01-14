namespace Proyecto_Integracion_Continua
{
    partial class ConversorVelocidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorVelocidad));
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.Lbl_PesoLB = new System.Windows.Forms.Label();
            this.Btn_Convertir = new System.Windows.Forms.Button();
            this.Lbl_PesoKG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MphNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KmhNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MphNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KmhNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reiniciar.Location = new System.Drawing.Point(619, 181);
            this.Btn_Reiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(165, 62);
            this.Btn_Reiniciar.TabIndex = 15;
            this.Btn_Reiniciar.Text = "Limpiar";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // Lbl_PesoLB
            // 
            this.Lbl_PesoLB.AutoSize = true;
            this.Lbl_PesoLB.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesoLB.Location = new System.Drawing.Point(152, 125);
            this.Lbl_PesoLB.Name = "Lbl_PesoLB";
            this.Lbl_PesoLB.Size = new System.Drawing.Size(181, 16);
            this.Lbl_PesoLB.TabIndex = 12;
            this.Lbl_PesoLB.Text = "Indique las millas por hora:";
            // 
            // Btn_Convertir
            // 
            this.Btn_Convertir.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convertir.Location = new System.Drawing.Point(619, 60);
            this.Btn_Convertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Convertir.Name = "Btn_Convertir";
            this.Btn_Convertir.Size = new System.Drawing.Size(165, 63);
            this.Btn_Convertir.TabIndex = 11;
            this.Btn_Convertir.Text = "Convertir";
            this.Btn_Convertir.UseVisualStyleBackColor = true;
            this.Btn_Convertir.Click += new System.EventHandler(this.ConvertirButton_Click);
            // 
            // Lbl_PesoKG
            // 
            this.Lbl_PesoKG.AutoSize = true;
            this.Lbl_PesoKG.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesoKG.Location = new System.Drawing.Point(111, 60);
            this.Lbl_PesoKG.Name = "Lbl_PesoKG";
            this.Lbl_PesoKG.Size = new System.Drawing.Size(215, 16);
            this.Lbl_PesoKG.TabIndex = 10;
            this.Lbl_PesoKG.Text = "Indique los kilómetros por hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Indique los metros por segundo:";
            // 
            // MsNumericUpDown
            // 
            this.MsNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.MsNumericUpDown.Location = new System.Drawing.Point(434, 201);
            this.MsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MsNumericUpDown.Name = "MsNumericUpDown";
            this.MsNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.MsNumericUpDown.TabIndex = 22;
            // 
            // MphNumericUpDown
            // 
            this.MphNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.MphNumericUpDown.Location = new System.Drawing.Point(434, 123);
            this.MphNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MphNumericUpDown.Name = "MphNumericUpDown";
            this.MphNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.MphNumericUpDown.TabIndex = 23;
            // 
            // KmhNumericUpDown
            // 
            this.KmhNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.KmhNumericUpDown.Location = new System.Drawing.Point(434, 58);
            this.KmhNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KmhNumericUpDown.Name = "KmhNumericUpDown";
            this.KmhNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.KmhNumericUpDown.TabIndex = 21;
            // 
            // Form_ConversorVelocidad
            // 
            this.ClientSize = new System.Drawing.Size(849, 282);
            this.Controls.Add(this.MphNumericUpDown);
            this.Controls.Add(this.MsNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.KmhNumericUpDown);
            this.Controls.Add(this.Lbl_PesoLB);
            this.Controls.Add(this.Btn_Convertir);
            this.Controls.Add(this.Lbl_PesoKG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ConversorVelocidad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Integracion Continua";
            ((System.ComponentModel.ISupportInitialize)(this.MsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MphNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KmhNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convertidorVelocidad;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.Label Lbl_PesoLB;
        private System.Windows.Forms.Button Btn_Convertir;
        private System.Windows.Forms.Label Lbl_PesoKG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MsNumericUpDown;
        private System.Windows.Forms.NumericUpDown MphNumericUpDown;
        private System.Windows.Forms.NumericUpDown KmhNumericUpDown;
    }
}