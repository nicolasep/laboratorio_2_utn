namespace NicolasEduardo.Perez._2c
{
    partial class FormBar
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.numEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numGenter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(28, 77);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(265, 55);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.Location = new System.Drawing.Point(37, 221);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(155, 55);
            this.lblGente.TabIndex = 3;
            this.lblGente.Text = "Gente";
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(314, 326);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(195, 63);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // numEmpleados
            // 
            this.numEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmpleados.Location = new System.Drawing.Point(314, 77);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.Size = new System.Drawing.Size(195, 61);
            this.numEmpleados.TabIndex = 5;
            this.numEmpleados.ValueChanged += new System.EventHandler(this.numEmpleados_ValueChanged);
            // 
            // numGenter
            // 
            this.numGenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGenter.Location = new System.Drawing.Point(314, 215);
            this.numGenter.Name = "numGenter";
            this.numGenter.Size = new System.Drawing.Size(195, 61);
            this.numGenter.TabIndex = 6;
            this.numGenter.ValueChanged += new System.EventHandler(this.numGenter_ValueChanged);
            // 
            // FormBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.numGenter);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Nicolas Eduardo Perez";
            this.Load += new System.EventHandler(this.FormBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.NumericUpDown numEmpleados;
        private System.Windows.Forms.NumericUpDown numGenter;
    }
}

