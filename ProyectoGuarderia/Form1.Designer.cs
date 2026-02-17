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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnTutores = new System.Windows.Forms.Button();
            this.btnPadres = new System.Windows.Forms.Button();
            this.btnNiños = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelDivicion = new System.Windows.Forms.Label();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panelApp = new System.Windows.Forms.Panel();
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
            this.lbl_Menu.Size = new System.Drawing.Size(149, 55);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "Menu";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Cyan;
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnDomicilio);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnTutores);
            this.panelMenu.Controls.Add(this.btnPadres);
            this.panelMenu.Controls.Add(this.btnNiños);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 616);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(0, 572);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(320, 44);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDomicilio.FlatAppearance.BorderSize = 0;
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomicilio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDomicilio.Image = global::ProyectoGuarderia.Properties.Resources.casa;
            this.btnDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicilio.Location = new System.Drawing.Point(0, 331);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(320, 44);
            this.btnDomicilio.TabIndex = 4;
            this.btnDomicilio.Text = "Domicilio";
            this.btnDomicilio.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPagos.Image = global::ProyectoGuarderia.Properties.Resources.mano;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 287);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(320, 44);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            // 
            // btnTutores
            // 
            this.btnTutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTutores.FlatAppearance.BorderSize = 0;
            this.btnTutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTutores.Image = global::ProyectoGuarderia.Properties.Resources.usuario;
            this.btnTutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutores.Location = new System.Drawing.Point(0, 243);
            this.btnTutores.Name = "btnTutores";
            this.btnTutores.Size = new System.Drawing.Size(320, 44);
            this.btnTutores.TabIndex = 2;
            this.btnTutores.Text = "Tutores";
            this.btnTutores.UseVisualStyleBackColor = true;
            this.btnTutores.Click += new System.EventHandler(this.btnTutores_Click);
            // 
            // btnPadres
            // 
            this.btnPadres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPadres.FlatAppearance.BorderSize = 0;
            this.btnPadres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPadres.Image = global::ProyectoGuarderia.Properties.Resources.bebe;
            this.btnPadres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPadres.Location = new System.Drawing.Point(0, 199);
            this.btnPadres.Name = "btnPadres";
            this.btnPadres.Size = new System.Drawing.Size(320, 44);
            this.btnPadres.TabIndex = 1;
            this.btnPadres.Text = "Padres";
            this.btnPadres.UseVisualStyleBackColor = true;
            this.btnPadres.Click += new System.EventHandler(this.btnPadres_Click);
            // 
            // btnNiños
            // 
            this.btnNiños.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNiños.FlatAppearance.BorderSize = 0;
            this.btnNiños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNiños.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNiños.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNiños.Image = global::ProyectoGuarderia.Properties.Resources.ninos;
            this.btnNiños.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNiños.Location = new System.Drawing.Point(0, 155);
            this.btnNiños.Name = "btnNiños";
            this.btnNiños.Size = new System.Drawing.Size(320, 44);
            this.btnNiños.TabIndex = 0;
            this.btnNiños.Text = "Niños";
            this.btnNiños.UseVisualStyleBackColor = true;
            this.btnNiños.Click += new System.EventHandler(this.btnNiños_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelDivicion);
            this.panelLogo.Controls.Add(this.pcLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(320, 155);
            this.panelLogo.TabIndex = 0;
            // 
            // labelDivicion
            // 
            this.labelDivicion.AutoSize = true;
            this.labelDivicion.BackColor = System.Drawing.Color.Cyan;
            this.labelDivicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivicion.ForeColor = System.Drawing.Color.White;
            this.labelDivicion.Location = new System.Drawing.Point(-5, 129);
            this.labelDivicion.Name = "labelDivicion";
            this.labelDivicion.Size = new System.Drawing.Size(431, 18);
            this.labelDivicion.TabIndex = 1;
            this.labelDivicion.Text = "_______________________________________________";
            this.labelDivicion.Click += new System.EventHandler(this.labelDivicion_Click);
            // 
            // pcLogo
            // 
            this.pcLogo.Image = global::ProyectoGuarderia.Properties.Resources.guarderia;
            this.pcLogo.Location = new System.Drawing.Point(12, 12);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(302, 128);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApp.Location = new System.Drawing.Point(320, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(879, 616);
            this.panelApp.TabIndex = 2;
            this.panelApp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelApp_Paint);
            // 
            // Form_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1199, 616);
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
            this.panelLogo.PerformLayout();
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
        private System.Windows.Forms.Label labelDivicion;
        private System.Windows.Forms.Button btnNiños;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnTutores;
        private System.Windows.Forms.Button btnPadres;
        private System.Windows.Forms.Button btnAyuda;
    }
}

