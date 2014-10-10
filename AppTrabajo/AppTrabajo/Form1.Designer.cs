namespace AppTrabajo
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
            this.chkExplorer = new System.Windows.Forms.CheckBox();
            this.chkMozilla = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.lbltexto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkExplorer
            // 
            this.chkExplorer.AutoSize = true;
            this.chkExplorer.Location = new System.Drawing.Point(59, 32);
            this.chkExplorer.Name = "chkExplorer";
            this.chkExplorer.Size = new System.Drawing.Size(64, 17);
            this.chkExplorer.TabIndex = 0;
            this.chkExplorer.Text = "Explorer";
            this.chkExplorer.UseVisualStyleBackColor = true;
            // 
            // chkMozilla
            // 
            this.chkMozilla.AutoSize = true;
            this.chkMozilla.Location = new System.Drawing.Point(59, 71);
            this.chkMozilla.Name = "chkMozilla";
            this.chkMozilla.Size = new System.Drawing.Size(92, 17);
            this.chkMozilla.TabIndex = 1;
            this.chkMozilla.Text = "Mozilla Firefox";
            this.chkMozilla.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(59, 111);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(62, 17);
            this.chkChrome.TabIndex = 2;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(41, 145);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(96, 13);
            this.lbltexto.TabIndex = 3;
            this.lbltexto.Text = "Su Navegador es: ";
            this.lbltexto.Click += new System.EventHandler(this.lbltexto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar Navegador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkMozilla);
            this.Controls.Add(this.chkExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExplorer;
        private System.Windows.Forms.CheckBox chkMozilla;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Button button1;
    }
}

