namespace ProyectoGuarderia
{
    partial class Form_Menu
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
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelApp = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(-2, -3);
            this.lbl_Menu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(219, 82);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "Menu";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 1050);
            this.panelMenu.TabIndex = 1;
            // 
            // panelApp
            // 
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApp.Location = new System.Drawing.Point(320, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(1604, 1050);
            this.panelApp.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pcLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(320, 155);
            this.panelLogo.TabIndex = 0;
            // 
            // pcLogo
            // 
            this.pcLogo.Location = new System.Drawing.Point(12, 12);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(293, 130);
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lbl_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.PictureBox pcLogo;
    }
}

