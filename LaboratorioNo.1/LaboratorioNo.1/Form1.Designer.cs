namespace LaboratorioNo._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BCargar = new System.Windows.Forms.Button();
            this.DGVVerPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVerPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Talent Hub";
            // 
            // BBuscar
            // 
            this.BBuscar.Enabled = false;
            this.BBuscar.Location = new System.Drawing.Point(147, 163);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(84, 41);
            this.BBuscar.TabIndex = 1;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Enabled = false;
            this.TBBuscar.Location = new System.Drawing.Point(36, 172);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(105, 22);
            this.TBBuscar.TabIndex = 2;
            // 
            // BCargar
            // 
            this.BCargar.Location = new System.Drawing.Point(36, 98);
            this.BCargar.Name = "BCargar";
            this.BCargar.Size = new System.Drawing.Size(119, 33);
            this.BCargar.TabIndex = 3;
            this.BCargar.Text = "Cargar formato";
            this.BCargar.UseVisualStyleBackColor = true;
            this.BCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVVerPersonas
            // 
            this.DGVVerPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVerPersonas.Location = new System.Drawing.Point(312, 80);
            this.DGVVerPersonas.Name = "DGVVerPersonas";
            this.DGVVerPersonas.ReadOnly = true;
            this.DGVVerPersonas.RowHeadersWidth = 51;
            this.DGVVerPersonas.RowTemplate.Height = 24;
            this.DGVVerPersonas.Size = new System.Drawing.Size(392, 300);
            this.DGVVerPersonas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVVerPersonas);
            this.Controls.Add(this.BCargar);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Laboratorio No.1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVVerPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Button BCargar;
        private System.Windows.Forms.DataGridView DGVVerPersonas;
    }
}

