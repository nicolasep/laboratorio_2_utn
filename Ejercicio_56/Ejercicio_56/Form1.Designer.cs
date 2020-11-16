namespace Ejercicio_56
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
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.menuOpciones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpciones
            // 
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(891, 28);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrir,
            this.menuGuardar,
            this.menuGuardarComo});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.abrirToolStripMenuItem.Text = "Archivo";
            // 
            // menuAbrir
            // 
            this.menuAbrir.Name = "menuAbrir";
            this.menuAbrir.Size = new System.Drawing.Size(224, 26);
            this.menuAbrir.Text = "Abrir";
            this.menuAbrir.Click += new System.EventHandler(this.menuAbrir_Click);
            // 
            // menuGuardar
            // 
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(224, 26);
            this.menuGuardar.Text = "Guardar";
            this.menuGuardar.Click += new System.EventHandler(this.menuGuardar_Click);
            // 
            // menuGuardarComo
            // 
            this.menuGuardarComo.Name = "menuGuardarComo";
            this.menuGuardarComo.Size = new System.Drawing.Size(224, 26);
            this.menuGuardarComo.Text = "Guardar Como";
            this.menuGuardarComo.Click += new System.EventHandler(this.menuGuardarComo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabel3.Text = "caracteres";
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Location = new System.Drawing.Point(0, 28);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(891, 529);
            this.rtbTexto.TabIndex = 2;
            this.rtbTexto.Text = "";
            this.rtbTexto.TextChanged += new System.EventHandler(this.rtbTexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 583);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuGuardarComo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}

