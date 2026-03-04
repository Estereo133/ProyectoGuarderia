namespace ProyectoGuarderia
{
    partial class Form_Niño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Niño));
            this.btnAgregarPadre = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPadre
            // 
            this.btnAgregarPadre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarPadre.Location = new System.Drawing.Point(640, 320);
            this.btnAgregarPadre.Name = "btnAgregarPadre";
            this.btnAgregarPadre.Size = new System.Drawing.Size(167, 42);
            this.btnAgregarPadre.TabIndex = 6;
            this.btnAgregarPadre.Text = "Agregar Padre";
            this.btnAgregarPadre.UseVisualStyleBackColor = false;
            this.btnAgregarPadre.Click += new System.EventHandler(this.btnAgregarPadre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombre.Location = new System.Drawing.Point(37, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApaterno
            // 
            this.txtApaterno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtApaterno.Location = new System.Drawing.Point(37, 191);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApaterno.TabIndex = 8;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAmaterno.Location = new System.Drawing.Point(37, 261);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAmaterno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(46, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apaterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(46, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amaterno";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(23, 362);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 13;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(350, 260);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(640, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(732, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(657, 96);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(109, 94);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 17;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(666, 230);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(100, 23);
            this.btnSeleccionarFoto.TabIndex = 18;
            this.btnSeleccionarFoto.Text = "Agregar foto";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = false;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(334, 362);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 20;
            this.dtpFechaRegistro.ValueChanged += new System.EventHandler(this.dtpFechaRegistro_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de inscripción";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Registro para nuevos alumnos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Niño
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSeleccionarFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmaterno);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregarPadre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Niño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niño";
            this.Load += new System.EventHandler(this.Form_Niño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPadre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}