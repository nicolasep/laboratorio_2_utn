namespace NicolasEduardo.Perez._2c
{
    partial class FormInformes
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
            this.components = new System.ComponentModel.Container();
            this.textInformes = new System.Windows.Forms.TextBox();
            this.datosFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInformes
            // 
            this.textInformes.Location = new System.Drawing.Point(16, 23);
            this.textInformes.Multiline = true;
            this.textInformes.Name = "textInformes";
            this.textInformes.Size = new System.Drawing.Size(614, 363);
            this.textInformes.TabIndex = 0;
            // 
            // datosFormBindingSource
            // 
            this.datosFormBindingSource.DataSource = typeof(NicolasEduardo.Perez._2c.DatosForm);
            // 
            // datosFormBindingSource1
            // 
            this.datosFormBindingSource1.DataSource = typeof(NicolasEduardo.Perez._2c.DatosForm);
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 398);
            this.Controls.Add(this.textInformes);
            this.Name = "FormInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformes";
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInformes;
        private System.Windows.Forms.BindingSource datosFormBindingSource;
        private System.Windows.Forms.BindingSource datosFormBindingSource1;
    }
}