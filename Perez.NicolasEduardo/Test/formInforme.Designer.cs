namespace Test
{
    partial class formInforme
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
            this.rTxtInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxtInforme
            // 
            this.rTxtInforme.Location = new System.Drawing.Point(20, 10);
            this.rTxtInforme.Name = "rTxtInforme";
            this.rTxtInforme.Size = new System.Drawing.Size(758, 428);
            this.rTxtInforme.TabIndex = 0;
            this.rTxtInforme.Text = "";
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtInforme);
            this.Name = "Informe";
            this.Text = "Informe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtInforme;
    }
}