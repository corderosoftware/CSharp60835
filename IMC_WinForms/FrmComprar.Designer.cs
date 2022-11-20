namespace IMC_WinForms
{
    partial class FrmComprar
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvCompras = new System.Windows.Forms.DataGridView();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(87, 28);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(131, 23);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblProducto.Location = new System.Drawing.Point(27, 70);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(270, 30);
            this.LblProducto.TabIndex = 2;
            this.LblProducto.Text = "DESCRIPCION PRODUCTO";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPrecio.ForeColor = System.Drawing.Color.Red;
            this.LblPrecio.Location = new System.Drawing.Point(27, 115);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(65, 25);
            this.LblPrecio.TabIndex = 3;
            this.LblPrecio.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvCompras
            // 
            this.DgvCompras.AllowUserToAddRows = false;
            this.DgvCompras.AllowUserToDeleteRows = false;
            this.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodProd,
            this.ColNombre,
            this.ColCant,
            this.ColPrecio,
            this.ColSubTotal});
            this.DgvCompras.Location = new System.Drawing.Point(27, 163);
            this.DgvCompras.Name = "DgvCompras";
            this.DgvCompras.ReadOnly = true;
            this.DgvCompras.RowTemplate.Height = 25;
            this.DgvCompras.Size = new System.Drawing.Size(829, 210);
            this.DgvCompras.TabIndex = 5;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPagar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPagar.Location = new System.Drawing.Point(360, 392);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(211, 54);
            this.BtnPagar.TabIndex = 6;
            this.BtnPagar.Text = "PAGAR";
            this.BtnPagar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColCodProd
            // 
            this.ColCodProd.DataPropertyName = "CodProducto";
            this.ColCodProd.HeaderText = "Código";
            this.ColCodProd.Name = "ColCodProd";
            this.ColCodProd.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "NombreProducto";
            this.ColNombre.HeaderText = "Producto";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.DataPropertyName = "Cantidad";
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.DataPropertyName = "SubTotal";
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.DgvCompras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FrmComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtCodigo;
        private Label LblProducto;
        private Label LblPrecio;
        private Button button1;
        private DataGridView DgvCompras;
        private Button BtnPagar;
        private Button button2;
        private DataGridViewTextBoxColumn ColCodProd;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColCant;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColSubTotal;
    }
}