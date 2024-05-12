namespace P1AFm.Formularios
{
    partial class FrmHeredado
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
            this.botonsaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonsaludo
            // 
            this.botonsaludo.Location = new System.Drawing.Point(214, 135);
            this.botonsaludo.Name = "botonsaludo";
            this.botonsaludo.Size = new System.Drawing.Size(77, 44);
            this.botonsaludo.TabIndex = 4;
            this.botonsaludo.Text = "Saludo";
            this.botonsaludo.UseVisualStyleBackColor = true;
            this.botonsaludo.Click += new System.EventHandler(this.botonsaludo_Click);
            // 
            // FrmHeredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonsaludo);
            this.Name = "FrmHeredado";
            this.Controls.SetChildIndex(this.botonsaludo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonsaludo;
    }
}
