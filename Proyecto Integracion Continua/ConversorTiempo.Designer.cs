namespace Proyecto_Integracion_Continua
{
    partial class ConversorTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorTiempo));
            this.MinutosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SegundosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.HorasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Lbl_minutos = new System.Windows.Forms.Label();
            this.Btn_Convertir = new System.Windows.Forms.Button();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.DiasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinutosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegundosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MinutosNumericUpDown
            // 
            this.MinutosNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.MinutosNumericUpDown.Location = new System.Drawing.Point(304, 90);
            this.MinutosNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinutosNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinutosNumericUpDown.Name = "MinutosNumericUpDown";
            this.MinutosNumericUpDown.Size = new System.Drawing.Size(90, 24);
            this.MinutosNumericUpDown.TabIndex = 31;
            // 
            // SegundosNumericUpDown
            // 
            this.SegundosNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.SegundosNumericUpDown.Location = new System.Drawing.Point(304, 145);
            this.SegundosNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SegundosNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SegundosNumericUpDown.Name = "SegundosNumericUpDown";
            this.SegundosNumericUpDown.Size = new System.Drawing.Size(90, 24);
            this.SegundosNumericUpDown.TabIndex = 30;
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundos.Location = new System.Drawing.Point(133, 146);
            this.lbl_segundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(151, 16);
            this.lbl_segundos.TabIndex = 28;
            this.lbl_segundos.Text = "Indique los segundos:";
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reiniciar.Location = new System.Drawing.Point(442, 137);
            this.Btn_Reiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(124, 50);
            this.Btn_Reiniciar.TabIndex = 27;
            this.Btn_Reiniciar.Text = "Limpiar";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // HorasNumericUpDown
            // 
            this.HorasNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.HorasNumericUpDown.Location = new System.Drawing.Point(304, 39);
            this.HorasNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HorasNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HorasNumericUpDown.Name = "HorasNumericUpDown";
            this.HorasNumericUpDown.Size = new System.Drawing.Size(90, 24);
            this.HorasNumericUpDown.TabIndex = 29;
            // 
            // Lbl_minutos
            // 
            this.Lbl_minutos.AutoSize = true;
            this.Lbl_minutos.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_minutos.Location = new System.Drawing.Point(133, 90);
            this.Lbl_minutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_minutos.Name = "Lbl_minutos";
            this.Lbl_minutos.Size = new System.Drawing.Size(137, 16);
            this.Lbl_minutos.TabIndex = 26;
            this.Lbl_minutos.Text = "Indique los minutos:";
            // 
            // Btn_Convertir
            // 
            this.Btn_Convertir.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convertir.Location = new System.Drawing.Point(442, 39);
            this.Btn_Convertir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Convertir.Name = "Btn_Convertir";
            this.Btn_Convertir.Size = new System.Drawing.Size(124, 51);
            this.Btn_Convertir.TabIndex = 25;
            this.Btn_Convertir.Text = "Convertir";
            this.Btn_Convertir.UseVisualStyleBackColor = true;
            this.Btn_Convertir.Click += new System.EventHandler(this.ConvertirButton_Click);
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(167, 41);
            this.Lbl_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(108, 16);
            this.Lbl_hora.TabIndex = 24;
            this.Lbl_hora.Text = "Indique la hora:";
            // 
            // DiasNumericUpDown
            // 
            this.DiasNumericUpDown.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.DiasNumericUpDown.Location = new System.Drawing.Point(304, 192);
            this.DiasNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiasNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DiasNumericUpDown.Name = "DiasNumericUpDown";
            this.DiasNumericUpDown.Size = new System.Drawing.Size(90, 24);
            this.DiasNumericUpDown.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Indique los dias:";
            // 
            // Form_ConversorTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 252);
            this.Controls.Add(this.DiasNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinutosNumericUpDown);
            this.Controls.Add(this.SegundosNumericUpDown);
            this.Controls.Add(this.lbl_segundos);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.HorasNumericUpDown);
            this.Controls.Add(this.Lbl_minutos);
            this.Controls.Add(this.Btn_Convertir);
            this.Controls.Add(this.Lbl_hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_ConversorTiempo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Integracion Continua";
            ((System.ComponentModel.ISupportInitialize)(this.MinutosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegundosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MinutosNumericUpDown;
        private System.Windows.Forms.NumericUpDown SegundosNumericUpDown;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.NumericUpDown HorasNumericUpDown;
        private System.Windows.Forms.Label Lbl_minutos;
        private System.Windows.Forms.Button Btn_Convertir;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.NumericUpDown DiasNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}