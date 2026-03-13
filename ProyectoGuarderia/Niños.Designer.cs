namespace ProyectoGuarderia
{
    partial class Form_Niños
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Niños));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarNiño = new System.Windows.Forms.Button();
            this.dgvNinos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(743, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 43);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarNiño
            // 
            this.btnAgregarNiño.Location = new System.Drawing.Point(595, 397);
            this.btnAgregarNiño.Name = "btnAgregarNiño";
            this.btnAgregarNiño.Size = new System.Drawing.Size(142, 43);
            this.btnAgregarNiño.TabIndex = 7;
            this.btnAgregarNiño.Text = "Agregar Niño";
            this.btnAgregarNiño.UseVisualStyleBackColor = true;
            this.btnAgregarNiño.Click += new System.EventHandler(this.btnAgregarNiño_Click);
            // 
            // dgvNinos
            // 
            this.dgvNinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNinos.Location = new System.Drawing.Point(71, 198);
            this.dgvNinos.Name = "dgvNinos";
            this.dgvNinos.Size = new System.Drawing.Size(740, 150);
            this.dgvNinos.TabIndex = 8;
            this.dgvNinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNinos_CellContentClick);
            this.dgvNinos.SelectionChanged += new System.EventHandler(this.dgvNinos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Niños actualmente inscritos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(729, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(120, 135);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 9;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Niños
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.dgvNinos);
            this.Controls.Add(this.btnAgregarNiño);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Niños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niños";
            this.Load += new System.EventHandler(this.Form_Niños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarNiño;
        private System.Windows.Forms.DataGridView dgvNinos;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}