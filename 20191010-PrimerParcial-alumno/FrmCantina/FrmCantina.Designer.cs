namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbCerbeza = new System.Windows.Forms.RadioButton();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barra = new ControlCantina.Barra();
            this.barra1 = new ControlCantina.Barra();
            this.barra2 = new ControlCantina.Barra();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numContenido);
            this.groupBox1.Controls.Add(this.numCapacidad);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbCerbeza);
            this.groupBox1.Controls.Add(this.cmbBotellaTipo);
            this.groupBox1.Controls.Add(this.textMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(387, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(279, 115);
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(73, 22);
            this.numContenido.TabIndex = 9;
            this.numContenido.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.DarEstadoInicial);
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(179, 115);
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(73, 22);
            this.numCapacidad.TabIndex = 8;
            this.numCapacidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Agua";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbCerbeza
            // 
            this.rdbCerbeza.AutoSize = true;
            this.rdbCerbeza.Location = new System.Drawing.Point(24, 53);
            this.rdbCerbeza.Name = "rdbCerbeza";
            this.rdbCerbeza.Size = new System.Drawing.Size(81, 21);
            this.rdbCerbeza.TabIndex = 6;
            this.rdbCerbeza.TabStop = true;
            this.rdbCerbeza.Text = "Cerveza";
            this.rdbCerbeza.UseVisualStyleBackColor = true;
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(371, 50);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(127, 24);
            this.cmbBotellaTipo.TabIndex = 5;
            this.cmbBotellaTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBotellaTipo_SelectedIndexChanged);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(181, 52);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(150, 22);
            this.textMarca.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contenido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Botella Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(0, 13);
            this.barra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(560, 367);
            this.barra.TabIndex = 0;
            this.barra.Load += new System.EventHandler(this.barra3_Load);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(0, 0);
            this.barra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(735, 453);
            this.barra1.TabIndex = 0;
            // 
            // barra2
            // 
            this.barra2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra2.BackgroundImage")));
            this.barra2.Location = new System.Drawing.Point(0, 0);
            this.barra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barra2.Name = "barra2";
            this.barra2.Size = new System.Drawing.Size(735, 453);
            this.barra2.TabIndex = 0;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barra);
            this.Name = "FrmCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra1;
        private ControlCantina.Barra barra2;
        private ControlCantina.Barra barra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbCerbeza;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

