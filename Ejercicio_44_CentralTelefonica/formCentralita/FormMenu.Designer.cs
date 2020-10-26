namespace formCentralita
{
    partial class FormMenu
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
            this.btnLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamada
            // 
            this.btnLlamada.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLlamada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLlamada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLlamada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLlamada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnLlamada.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamada.ForeColor = System.Drawing.Color.Black;
            this.btnLlamada.Location = new System.Drawing.Point(41, 12);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(349, 85);
            this.btnLlamada.TabIndex = 0;
            this.btnLlamada.Text = "Generar Llamada";
            this.btnLlamada.UseVisualStyleBackColor = false;
            this.btnLlamada.Click += new System.EventHandler(this.btnLlamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFacturacionTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacionTotal.ForeColor = System.Drawing.Color.Black;
            this.btnFacturacionTotal.Location = new System.Drawing.Point(41, 119);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(349, 85);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = false;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFacturacionLocal.ForeColor = System.Drawing.Color.Black;
            this.btnFacturacionLocal.Location = new System.Drawing.Point(41, 219);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(349, 85);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = false;
            this.btnFacturacionLocal.Click += new System.EventHandler(this.btnFacturacionLocal_Click);
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(41, 319);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(349, 85);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = false;
            this.btnFacturacionProvincial.Click += new System.EventHandler(this.btnFacturacionProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(41, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(349, 85);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 533);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnLlamada);
            this.Name = "FormMenu";
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLlamada;
        private System.Windows.Forms.Button btnFacturacionLocal;
    }
}

