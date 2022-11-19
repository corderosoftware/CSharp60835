namespace IMC_WinForms
{
    partial class FrmDiagnostico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcularIMC = new System.Windows.Forms.Button();
            this.LblDiagnostico = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblIMC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAltura);
            this.groupBox1.Controls.Add(this.TxtPeso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbGenero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(142, 124);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 23);
            this.TxtAltura.TabIndex = 7;
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(141, 96);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 23);
            this.TxtPeso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso:";
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Items.AddRange(new object[] {
            "F",
            "M",
            "X"});
            this.CmbGenero.Location = new System.Drawing.Point(139, 59);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(121, 23);
            this.CmbGenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero:";
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Location = new System.Drawing.Point(139, 27);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(368, 23);
            this.TxtPaciente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y aplellido:";
            // 
            // BtnCalcularIMC
            // 
            this.BtnCalcularIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCalcularIMC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcularIMC.Location = new System.Drawing.Point(186, 247);
            this.BtnCalcularIMC.Name = "BtnCalcularIMC";
            this.BtnCalcularIMC.Size = new System.Drawing.Size(352, 76);
            this.BtnCalcularIMC.TabIndex = 1;
            this.BtnCalcularIMC.Text = "CALCULAR IMC";
            this.BtnCalcularIMC.UseVisualStyleBackColor = false;
            this.BtnCalcularIMC.Click += new System.EventHandler(this.BtnCalcularIMC_Click);
            // 
            // LblDiagnostico
            // 
            this.LblDiagnostico.AutoSize = true;
            this.LblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDiagnostico.Location = new System.Drawing.Point(47, 391);
            this.LblDiagnostico.Name = "LblDiagnostico";
            this.LblDiagnostico.Size = new System.Drawing.Size(202, 37);
            this.LblDiagnostico.TabIndex = 2;
            this.LblDiagnostico.Text = "DIAGNOSTICO";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.Location = new System.Drawing.Point(575, 459);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(125, 39);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblIMC
            // 
            this.LblIMC.AutoSize = true;
            this.LblIMC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIMC.ForeColor = System.Drawing.Color.Yellow;
            this.LblIMC.Location = new System.Drawing.Point(47, 339);
            this.LblIMC.Name = "LblIMC";
            this.LblIMC.Size = new System.Drawing.Size(69, 37);
            this.LblIMC.TabIndex = 7;
            this.LblIMC.Text = "IMC";
            // 
            // FrmDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(712, 510);
            this.Controls.Add(this.LblIMC);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblDiagnostico);
            this.Controls.Add(this.BtnCalcularIMC);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC Calculator V 2.0 - Diagnostico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtAltura;
        private TextBox TxtPeso;
        private Label label4;
        private Label label3;
        private ComboBox CmbGenero;
        private Label label2;
        private TextBox TxtPaciente;
        private Label label1;
        private Button BtnCalcularIMC;
        private Label LblDiagnostico;
        private Button BtnSalir;
        private Label LblIMC;
    }
}