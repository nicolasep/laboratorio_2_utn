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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxInformes = new System.Windows.Forms.RichTextBox();
            this.datosFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(8, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // richTextBoxInformes
            // 
            this.richTextBoxInformes.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxInformes.Name = "richTextBoxInformes";
            this.richTextBoxInformes.Size = new System.Drawing.Size(431, 427);
            this.richTextBoxInformes.TabIndex = 2;
            this.richTextBoxInformes.Text = "";
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
            this.ClientSize = new System.Drawing.Size(455, 451);
            this.Controls.Add(this.richTextBoxInformes);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "FormInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosFormBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource datosFormBindingSource;
        private System.Windows.Forms.BindingSource datosFormBindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBoxInformes;
    }
}