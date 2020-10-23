namespace Test
{
    partial class formPrincipal
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtValorDeCompraProducto = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblValorProductor = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSmartphone = new System.Windows.Forms.RadioButton();
            this.rbtnLineaBlanca = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(239, 67);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(305, 22);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtValorDeCompraProducto
            // 
            this.txtValorDeCompraProducto.Location = new System.Drawing.Point(239, 153);
            this.txtValorDeCompraProducto.Name = "txtValorDeCompraProducto";
            this.txtValorDeCompraProducto.Size = new System.Drawing.Size(305, 22);
            this.txtValorDeCompraProducto.TabIndex = 1;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(25, 67);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(101, 29);
            this.lblNombreP.TabIndex = 2;
            this.lblNombreP.Text = "Nombre";
            // 
            // lblValorProductor
            // 
            this.lblValorProductor.AutoSize = true;
            this.lblValorProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProductor.Location = new System.Drawing.Point(25, 153);
            this.lblValorProductor.Name = "lblValorProductor";
            this.lblValorProductor.Size = new System.Drawing.Size(190, 29);
            this.lblValorProductor.TabIndex = 3;
            this.lblValorProductor.Text = "Valor de compra";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(244, 242);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(300, 24);
            this.cmbOrigen.TabIndex = 4;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(27, 242);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(87, 29);
            this.lblOrigen.TabIndex = 5;
            this.lblOrigen.Text = "Origen";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(37, 371);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(178, 31);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(443, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 31);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(222, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mostrar Productos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(239, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(178, 31);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnLineaBlanca);
            this.groupBox1.Controls.Add(this.rbtnSmartphone);
            this.groupBox1.Location = new System.Drawing.Point(51, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion";
            // 
            // rbtnSmartphone
            // 
            this.rbtnSmartphone.AutoSize = true;
            this.rbtnSmartphone.Location = new System.Drawing.Point(100, 33);
            this.rbtnSmartphone.Name = "rbtnSmartphone";
            this.rbtnSmartphone.Size = new System.Drawing.Size(106, 21);
            this.rbtnSmartphone.TabIndex = 0;
            this.rbtnSmartphone.TabStop = true;
            this.rbtnSmartphone.Text = "Smartphone";
            this.rbtnSmartphone.UseVisualStyleBackColor = true;
            // 
            // rbtnLineaBlanca
            // 
            this.rbtnLineaBlanca.AutoSize = true;
            this.rbtnLineaBlanca.Location = new System.Drawing.Point(311, 33);
            this.rbtnLineaBlanca.Name = "rbtnLineaBlanca";
            this.rbtnLineaBlanca.Size = new System.Drawing.Size(111, 21);
            this.rbtnLineaBlanca.TabIndex = 1;
            this.rbtnLineaBlanca.TabStop = true;
            this.rbtnLineaBlanca.Text = "Linea Blanca";
            this.rbtnLineaBlanca.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblValorProductor);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.txtValorDeCompraProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNicolasEduardoPerez";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtValorDeCompraProducto;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblValorProductor;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLineaBlanca;
        private System.Windows.Forms.RadioButton rbtnSmartphone;
    }
}

