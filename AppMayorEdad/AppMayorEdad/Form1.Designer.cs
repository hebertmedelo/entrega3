namespace AppMayorEdad
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
            this.LBLNOMBRE = new System.Windows.Forms.Label();
            this.LBLEDAD = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNOMBRE
            // 
            this.LBLNOMBRE.AutoSize = true;
            this.LBLNOMBRE.Location = new System.Drawing.Point(52, 69);
            this.LBLNOMBRE.Name = "LBLNOMBRE";
            this.LBLNOMBRE.Size = new System.Drawing.Size(54, 13);
            this.LBLNOMBRE.TabIndex = 0;
            this.LBLNOMBRE.Text = "NOMBRE";
            // 
            // LBLEDAD
            // 
            this.LBLEDAD.AutoSize = true;
            this.LBLEDAD.Location = new System.Drawing.Point(52, 137);
            this.LBLEDAD.Name = "LBLEDAD";
            this.LBLEDAD.Size = new System.Drawing.Size(37, 13);
            this.LBLEDAD.TabIndex = 1;
            this.LBLEDAD.Text = "EDAD";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(183, 66);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 2;
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(183, 134);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTEDAD.TabIndex = 3;
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.Location = new System.Drawing.Point(55, 205);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(248, 23);
            this.BTNCALCULAR.TabIndex = 4;
            this.BTNCALCULAR.Text = "CALCULAR MAYOR EDAD";
            this.BTNCALCULAR.UseVisualStyleBackColor = true;
            this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(364, 262);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTEDAD);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.LBLEDAD);
            this.Controls.Add(this.LBLNOMBRE);
            this.Name = "Form1";
            this.Text = "MAYOR EDAD";
            this.TransparencyKey = System.Drawing.Color.Azure;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNOMBRE;
        private System.Windows.Forms.Label LBLEDAD;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.Button BTNCALCULAR;
    }
}

