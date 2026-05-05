namespace ProyectoGuarderia
{
    partial class Form_Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Busqueda));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPadre = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPadre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(319, 145);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de alumno";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(340, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(30, 265);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(744, 173);
            this.dgvResultado.TabIndex = 3;
            this.dgvResultado.SelectionChanged += new System.EventHandler(this.dgvResultado_SelectionChanged_1);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxFoto.Location = new System.Drawing.Point(581, 69);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(193, 174);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 4;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ProyectoGuarderia.Properties.Resources.icons8_búsqueda_30;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Busqueda rapida   ";
            // 
            // pictureBoxPadre
            // 
            this.pictureBoxPadre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPadre.Location = new System.Drawing.Point(30, 69);
            this.pictureBoxPadre.Name = "pictureBoxPadre";
            this.pictureBoxPadre.Size = new System.Drawing.Size(200, 174);
            this.pictureBoxPadre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPadre.TabIndex = 6;
            this.pictureBoxPadre.TabStop = false;
            this.pictureBoxPadre.Click += new System.EventHandler(this.dgvResultado_SelectionChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Padre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hijo";
            // 
            // Form_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPadre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Busqueda";
            this.Text = "Form_Busqueda";
            this.Load += new System.EventHandler(this.Form_Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPadre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPadre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}