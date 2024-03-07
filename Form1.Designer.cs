namespace NachoAprende
{
    partial class frmNachoAprende
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNachoAprende));
            this.wmpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.wbNavegador = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbNavegador)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpMusica
            // 
            this.wmpMusica.Enabled = true;
            this.wmpMusica.Location = new System.Drawing.Point(429, 12);
            this.wmpMusica.Name = "wmpMusica";
            this.wmpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusica.OcxState")));
            this.wmpMusica.Size = new System.Drawing.Size(307, 346);
            this.wmpMusica.TabIndex = 1;
            // 
            // wbNavegador
            // 
            this.wbNavegador.Enabled = true;
            this.wbNavegador.Location = new System.Drawing.Point(12, 12);
            this.wbNavegador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wbNavegador.OcxState")));
            this.wbNavegador.Size = new System.Drawing.Size(382, 346);
            this.wbNavegador.TabIndex = 0;
            // 
            // frmNachoAprende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.wmpMusica);
            this.Controls.Add(this.wbNavegador);
            this.Name = "frmNachoAprende";
            this.Text = "Nacho Aprende";
            this.Load += new System.EventHandler(this.frmNachoAprende_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbNavegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser wbNavegador;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusica;
    }
}

