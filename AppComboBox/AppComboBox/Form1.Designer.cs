namespace AppComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblrojo = new System.Windows.Forms.Label();
            this.lblverde = new System.Windows.Forms.Label();
            this.lblazul = new System.Windows.Forms.Label();
            this.cmbrojo = new System.Windows.Forms.ComboBox();
            this.cmbverde = new System.Windows.Forms.ComboBox();
            this.cmbazul = new System.Windows.Forms.ComboBox();
            this.btncolorfondo = new System.Windows.Forms.Button();
            this.lblazul2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrojo
            // 
            this.lblrojo.AutoSize = true;
            this.lblrojo.Location = new System.Drawing.Point(13, 13);
            this.lblrojo.Name = "lblrojo";
            this.lblrojo.Size = new System.Drawing.Size(36, 13);
            this.lblrojo.TabIndex = 0;
            this.lblrojo.Text = "ROJO";
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.Location = new System.Drawing.Point(16, 47);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(44, 13);
            this.lblverde.TabIndex = 1;
            this.lblverde.Text = "VERDE";
            // 
            // lblazul
            // 
            this.lblazul.AutoSize = true;
            this.lblazul.Location = new System.Drawing.Point(16, 73);
            this.lblazul.Name = "lblazul";
            this.lblazul.Size = new System.Drawing.Size(0, 13);
            this.lblazul.TabIndex = 2;
            // 
            // cmbrojo
            // 
            this.cmbrojo.FormattingEnabled = true;
            this.cmbrojo.Location = new System.Drawing.Point(107, 4);
            this.cmbrojo.Name = "cmbrojo";
            this.cmbrojo.Size = new System.Drawing.Size(121, 21);
            this.cmbrojo.TabIndex = 3;
            // 
            // cmbverde
            // 
            this.cmbverde.FormattingEnabled = true;
            this.cmbverde.Location = new System.Drawing.Point(107, 38);
            this.cmbverde.Name = "cmbverde";
            this.cmbverde.Size = new System.Drawing.Size(121, 21);
            this.cmbverde.TabIndex = 4;
            // 
            // cmbazul
            // 
            this.cmbazul.FormattingEnabled = true;
            this.cmbazul.Location = new System.Drawing.Point(107, 73);
            this.cmbazul.Name = "cmbazul";
            this.cmbazul.Size = new System.Drawing.Size(121, 21);
            this.cmbazul.TabIndex = 5;
            // 
            // btncolorfondo
            // 
            this.btncolorfondo.Location = new System.Drawing.Point(83, 139);
            this.btncolorfondo.Name = "btncolorfondo";
            this.btncolorfondo.Size = new System.Drawing.Size(145, 23);
            this.btncolorfondo.TabIndex = 6;
            this.btncolorfondo.Text = "COLOREAR FONDO";
            this.btncolorfondo.UseVisualStyleBackColor = true;
            this.btncolorfondo.Click += new System.EventHandler(this.btncolorfondo_Click);
            // 
            // lblazul2
            // 
            this.lblazul2.AutoSize = true;
            this.lblazul2.Location = new System.Drawing.Point(23, 80);
            this.lblazul2.Name = "lblazul2";
            this.lblazul2.Size = new System.Drawing.Size(35, 13);
            this.lblazul2.TabIndex = 7;
            this.lblazul2.Text = "AZUL";
            this.lblazul2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblazul2);
            this.Controls.Add(this.btncolorfondo);
            this.Controls.Add(this.cmbazul);
            this.Controls.Add(this.cmbverde);
            this.Controls.Add(this.cmbrojo);
            this.Controls.Add(this.lblazul);
            this.Controls.Add(this.lblverde);
            this.Controls.Add(this.lblrojo);
            this.Name = "Form1";
            this.Text = "Combo Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrojo;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Label lblazul;
        private System.Windows.Forms.ComboBox cmbrojo;
        private System.Windows.Forms.ComboBox cmbverde;
        private System.Windows.Forms.ComboBox cmbazul;
        private System.Windows.Forms.Button btncolorfondo;
        private System.Windows.Forms.Label lblazul2;

    }
}

