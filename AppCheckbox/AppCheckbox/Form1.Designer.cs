namespace AppCheckbox
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
            this.chkingles = new System.Windows.Forms.CheckBox();
            this.chkfrances = new System.Windows.Forms.CheckBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.chkAleman = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkingles
            // 
            this.chkingles.AutoSize = true;
            this.chkingles.Location = new System.Drawing.Point(92, 38);
            this.chkingles.Name = "chkingles";
            this.chkingles.Size = new System.Drawing.Size(54, 17);
            this.chkingles.TabIndex = 0;
            this.chkingles.Text = "Ingles";
            this.chkingles.UseVisualStyleBackColor = true;
            // 
            // chkfrances
            // 
            this.chkfrances.AutoSize = true;
            this.chkfrances.Location = new System.Drawing.Point(92, 70);
            this.chkfrances.Name = "chkfrances";
            this.chkfrances.Size = new System.Drawing.Size(64, 17);
            this.chkfrances.TabIndex = 1;
            this.chkfrances.Text = "Francés";
            this.chkfrances.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(81, 153);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(88, 23);
            this.btnmostrar.TabIndex = 2;
            this.btnmostrar.Text = "Mostrar Idioma";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // chkAleman
            // 
            this.chkAleman.AutoSize = true;
            this.chkAleman.Location = new System.Drawing.Point(92, 107);
            this.chkAleman.Name = "chkAleman";
            this.chkAleman.Size = new System.Drawing.Size(61, 17);
            this.chkAleman.TabIndex = 3;
            this.chkAleman.Text = "Alemán";
            this.chkAleman.UseVisualStyleBackColor = true;
            this.chkAleman.CheckedChanged += new System.EventHandler(this.chkAleman_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkAleman);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.chkfrances);
            this.Controls.Add(this.chkingles);
            this.Name = "Form1";
            this.Text = "Programa IDIOMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkingles;
        private System.Windows.Forms.CheckBox chkfrances;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.CheckBox chkAleman;
    }
}

