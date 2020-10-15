namespace NicolasEduardo.Perez._2c
{
    partial class ControlPublicoForm
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
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(28, 77);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(265, 55);
            this.lblEmpleados.TabIndex = 2;
            this.lblEmpleados.Text = "Empleados";
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
            this.btnInforme.TabIndex = 3;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEmpleados.Location = new System.Drawing.Point(314, 77);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.Size = new System.Drawing.Size(195, 61);
            this.nudEmpleados.TabIndex = 1;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.nudEmpleados_ValueChanged);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGente.Location = new System.Drawing.Point(314, 215);
            this.nudGente.Name = "nudGente";
            this.nudGente.Size = new System.Drawing.Size(195, 61);
            this.nudGente.TabIndex = 2;
            this.nudGente.ValueChanged += new System.EventHandler(this.nudGente_ValueChanged);
            // 
            // ControlPublicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.nudEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPublicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Nicolas Eduardo Perez";
            this.Load += new System.EventHandler(this.FormBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.NumericUpDown nudGente;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

