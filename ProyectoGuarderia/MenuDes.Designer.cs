namespace ProyectoGuarderia
{
    partial class MenuDes
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
            this.paneMenu = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.button_niños = new System.Windows.Forms.Button();
            this.SubPanel_Niños = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.paneMenu.SuspendLayout();
            this.SubPanel_Niños.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMenu
            // 
            this.paneMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneMenu.Controls.Add(this.SubPanel_Niños);
            this.paneMenu.Controls.Add(this.button_niños);
            this.paneMenu.Controls.Add(this.panelImagen);
            this.paneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneMenu.Location = new System.Drawing.Point(0, 0);
            this.paneMenu.Name = "paneMenu";
            this.paneMenu.Size = new System.Drawing.Size(300, 450);
            this.paneMenu.TabIndex = 0;
            // 
            // panelImagen
            // 
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(300, 100);
            this.panelImagen.TabIndex = 1;
            // 
            // button_niños
            // 
            this.button_niños.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_niños.Location = new System.Drawing.Point(0, 100);
            this.button_niños.Name = "button_niños";
            this.button_niños.Size = new System.Drawing.Size(300, 45);
            this.button_niños.TabIndex = 1;
            this.button_niños.Text = "button1";
            this.button_niños.UseVisualStyleBackColor = true;
            // 
            // SubPanel_Niños
            // 
            this.SubPanel_Niños.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubPanel_Niños.Controls.Add(this.button4);
            this.SubPanel_Niños.Controls.Add(this.button3);
            this.SubPanel_Niños.Controls.Add(this.button2);
            this.SubPanel_Niños.Controls.Add(this.button1);
            this.SubPanel_Niños.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanel_Niños.Location = new System.Drawing.Point(0, 145);
            this.SubPanel_Niños.Name = "SubPanel_Niños";
            this.SubPanel_Niños.Size = new System.Drawing.Size(300, 167);
            this.SubPanel_Niños.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MenuDes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.paneMenu);
            this.Name = "MenuDes";
            this.Text = "MenuDes";
            this.paneMenu.ResumeLayout(false);
            this.SubPanel_Niños.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMenu;
        private System.Windows.Forms.Button button_niños;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Panel SubPanel_Niños;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}