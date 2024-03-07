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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 411);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 411);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(26, 392);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(147, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Ingrese el contenido a buscar";
            // 
            // frmNachoAprende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.wmpMusica);
            this.Controls.Add(this.wbNavegador);
            this.Name = "frmNachoAprende";
            this.Text = "Nacho Aprende";
            this.Load += new System.EventHandler(this.frmNachoAprende_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbNavegador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSHDocVw.AxWebBrowser wbNavegador;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusica;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

