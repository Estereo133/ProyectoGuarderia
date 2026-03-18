namespace ProyectoGuarderia
{
    partial class Form_Tutores
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
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texApat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAMate = new System.Windows.Forms.TextBox();
            this.butCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textNUM = new System.Windows.Forms.TextBox();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.butImage = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.textNom = new System.Windows.Forms.TextBox();
            this.butGuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutores";
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(636, 18);
            this.picBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(249, 228);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 3;
            this.picBoxImage.TabStop = false;
            this.picBoxImage.Click += new System.EventHandler(this.picBoxImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Paterno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // texApat
            // 
            this.texApat.Location = new System.Drawing.Point(22, 200);
            this.texApat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.texApat.Name = "texApat";
            this.texApat.Size = new System.Drawing.Size(274, 26);
            this.texApat.TabIndex = 5;
            this.texApat.TextChanged += new System.EventHandler(this.texApat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno";
            // 
            // textAMate
            // 
            this.textAMate.Location = new System.Drawing.Point(18, 278);
            this.textAMate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAMate.Name = "textAMate";
            this.textAMate.Size = new System.Drawing.Size(278, 26);
            this.textAMate.TabIndex = 7;
            this.textAMate.TextChanged += new System.EventHandler(this.textAMate_TextChanged);
            // 
            // butCerrar
            // 
            this.butCerrar.Location = new System.Drawing.Point(752, 415);
            this.butCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(134, 92);
            this.butCerrar.TabIndex = 10;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero de Telefono";
            // 
            // textNUM
            // 
            this.textNUM.Location = new System.Drawing.Point(117, 394);
            this.textNUM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNUM.Name = "textNUM";
            this.textNUM.Size = new System.Drawing.Size(362, 26);
            this.textNUM.TabIndex = 11;
            this.textNUM.TextChanged += new System.EventHandler(this.textNUM_TextChanged);
            // 
            // butImage
            // 
            this.butImage.Location = new System.Drawing.Point(669, 283);
            this.butImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butImage.Name = "butImage";
            this.butImage.Size = new System.Drawing.Size(172, 62);
            this.butImage.TabIndex = 13;
            this.butImage.Text = "Agregar Image";
            this.butImage.UseVisualStyleBackColor = true;
            this.butImage.Click += new System.EventHandler(this.butImage_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(21, 122);
            this.textNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(274, 26);
            this.textNom.TabIndex = 14;
            this.textNom.TextChanged += new System.EventHandler(this.textNom_TextChanged);
            // 
            // butGuar
            // 
            this.butGuar.Location = new System.Drawing.Point(584, 415);
            this.butGuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butGuar.Name = "butGuar";
            this.butGuar.Size = new System.Drawing.Size(134, 92);
            this.butGuar.TabIndex = 15;
            this.butGuar.Text = "Guardar";
            this.butGuar.UseVisualStyleBackColor = true;
            this.butGuar.Click += new System.EventHandler(this.butGuar_Click);
            // 
            // Form_Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoGuarderia.Properties.Resources.doodle_pop___fall_collection_print_artwork;
            this.ClientSize = new System.Drawing.Size(932, 578);
            this.Controls.Add(this.butGuar);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.butImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNUM);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAMate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texApat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.label1);
            this.Name = "Form_Tutores";
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Form_Tutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Label label5;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button butImage;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button butGuar;
        public System.Windows.Forms.TextBox texApat;
        public System.Windows.Forms.TextBox textAMate;
        public System.Windows.Forms.TextBox textNUM;
        public System.Windows.Forms.TextBox textNom;
    }
}