namespace ProyectoGuarderia
{
    partial class Form_Padres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Padres));
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPadres = new System.Windows.Forms.DataGridView();
            this.lblBuscarPadre = new System.Windows.Forms.Label();
            this.txtBuscarPadre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarPadre = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadres)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1090, 561);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 43);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Padres Registrados";
            // 
            // dgvPadres
            // 
            this.dgvPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadres.Location = new System.Drawing.Point(26, 187);
            this.dgvPadres.Name = "dgvPadres";
            this.dgvPadres.RowHeadersWidth = 62;
            this.dgvPadres.Size = new System.Drawing.Size(937, 229);
            this.dgvPadres.TabIndex = 3;
            this.dgvPadres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadres_CellContentClick);
            this.dgvPadres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadres_CellDoubleClick);
            // 
            // lblBuscarPadre
            // 
            this.lblBuscarPadre.AutoSize = true;
            this.lblBuscarPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPadre.Location = new System.Drawing.Point(34, 134);
            this.lblBuscarPadre.Name = "lblBuscarPadre";
            this.lblBuscarPadre.Size = new System.Drawing.Size(158, 29);
            this.lblBuscarPadre.TabIndex = 5;
            this.lblBuscarPadre.Text = "BuscarPadre:";
            // 
            // txtBuscarPadre
            // 
            this.txtBuscarPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPadre.Location = new System.Drawing.Point(198, 131);
            this.txtBuscarPadre.Name = "txtBuscarPadre";
            this.txtBuscarPadre.Size = new System.Drawing.Size(282, 35);
            this.txtBuscarPadre.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(486, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 42);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarPadre
            // 
            this.btnAgregarPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPadre.Location = new System.Drawing.Point(51, 458);
            this.btnAgregarPadre.Name = "btnAgregarPadre";
            this.btnAgregarPadre.Size = new System.Drawing.Size(215, 51);
            this.btnAgregarPadre.TabIndex = 8;
            this.btnAgregarPadre.Text = "Agregar Padre";
            this.btnAgregarPadre.UseVisualStyleBackColor = true;
            this.btnAgregarPadre.Click += new System.EventHandler(this.btnAgregarPadre_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(324, 459);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 51);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(486, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 51);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form_Padres
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 616);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarPadre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarPadre);
            this.Controls.Add(this.lblBuscarPadre);
            this.Controls.Add(this.dgvPadres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Padres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padres";
            this.Load += new System.EventHandler(this.Form_Padres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPadres;
        private System.Windows.Forms.Label lblBuscarPadre;
        private System.Windows.Forms.TextBox txtBuscarPadre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarPadre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}