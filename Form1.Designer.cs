namespace almacen2._0
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btninicio = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtusuario
            // 
            resources.ApplyResources(this.Txtusuario, "Txtusuario");
            this.Txtusuario.Name = "Txtusuario";
            // 
            // txtcontraseña
            // 
            resources.ApplyResources(this.txtcontraseña, "txtcontraseña");
            this.txtcontraseña.Name = "txtcontraseña";
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btninicio, "btninicio");
            this.btninicio.Name = "btninicio";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblusuario
            // 
            resources.ApplyResources(this.lblusuario, "lblusuario");
            this.lblusuario.Name = "lblusuario";
            // 
            // lblcontraseña
            // 
            resources.ApplyResources(this.lblcontraseña, "lblcontraseña");
            this.lblcontraseña.Name = "lblcontraseña";
            // 
            // frmlogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.Txtusuario);
            this.Name = "frmlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
    }
}

