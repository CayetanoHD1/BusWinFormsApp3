
namespace BusWinFormsApp3
{
    partial class ventana1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caja_correo = new System.Windows.Forms.TextBox();
            this.caja_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restaurar_v1 = new System.Windows.Forms.PictureBox();
            this.maximizar_v1 = new System.Windows.Forms.PictureBox();
            this.minimizar_v2 = new System.Windows.Forms.PictureBox();
            this.cerrar_v1 = new System.Windows.Forms.PictureBox();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_v1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(157, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(157, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // caja_correo
            // 
            this.caja_correo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caja_correo.Location = new System.Drawing.Point(234, 145);
            this.caja_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caja_correo.Multiline = true;
            this.caja_correo.Name = "caja_correo";
            this.caja_correo.Size = new System.Drawing.Size(233, 30);
            this.caja_correo.TabIndex = 3;
            // 
            // caja_pass
            // 
            this.caja_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caja_pass.Location = new System.Drawing.Point(234, 198);
            this.caja_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caja_pass.Multiline = true;
            this.caja_pass.Name = "caja_pass";
            this.caja_pass.PasswordChar = '*';
            this.caja_pass.Size = new System.Drawing.Size(233, 30);
            this.caja_pass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(157, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acceso";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(377, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.restaurar_v1);
            this.panel1.Controls.Add(this.maximizar_v1);
            this.panel1.Controls.Add(this.minimizar_v2);
            this.panel1.Controls.Add(this.cerrar_v1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 35);
            this.panel1.TabIndex = 8;
            // 
            // restaurar_v1
            // 
            this.restaurar_v1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar_v1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar_v1.Image = ((System.Drawing.Image)(resources.GetObject("restaurar_v1.Image")));
            this.restaurar_v1.Location = new System.Drawing.Point(476, 3);
            this.restaurar_v1.Name = "restaurar_v1";
            this.restaurar_v1.Size = new System.Drawing.Size(25, 25);
            this.restaurar_v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar_v1.TabIndex = 13;
            this.restaurar_v1.TabStop = false;
            this.restaurar_v1.Visible = false;
            this.restaurar_v1.Click += new System.EventHandler(this.restaurar_v2_Click);
            // 
            // maximizar_v1
            // 
            this.maximizar_v1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar_v1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar_v1.Image = ((System.Drawing.Image)(resources.GetObject("maximizar_v1.Image")));
            this.maximizar_v1.Location = new System.Drawing.Point(476, 3);
            this.maximizar_v1.Name = "maximizar_v1";
            this.maximizar_v1.Size = new System.Drawing.Size(25, 25);
            this.maximizar_v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar_v1.TabIndex = 12;
            this.maximizar_v1.TabStop = false;
            this.maximizar_v1.Click += new System.EventHandler(this.maximizar_v1_Click);
            // 
            // minimizar_v2
            // 
            this.minimizar_v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar_v2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar_v2.Image = ((System.Drawing.Image)(resources.GetObject("minimizar_v2.Image")));
            this.minimizar_v2.Location = new System.Drawing.Point(442, 3);
            this.minimizar_v2.Name = "minimizar_v2";
            this.minimizar_v2.Size = new System.Drawing.Size(25, 25);
            this.minimizar_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar_v2.TabIndex = 11;
            this.minimizar_v2.TabStop = false;
            this.minimizar_v2.Click += new System.EventHandler(this.minimizar_v2_Click);
            // 
            // cerrar_v1
            // 
            this.cerrar_v1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cerrar_v1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar_v1.Image = ((System.Drawing.Image)(resources.GetObject("cerrar_v1.Image")));
            this.cerrar_v1.Location = new System.Drawing.Point(507, 3);
            this.cerrar_v1.Name = "cerrar_v1";
            this.cerrar_v1.Size = new System.Drawing.Size(25, 25);
            this.cerrar_v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_v1.TabIndex = 11;
            this.cerrar_v1.TabStop = false;
            this.cerrar_v1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.ForeColor = System.Drawing.Color.Black;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmb_Rol.Location = new System.Drawing.Point(230, 240);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(237, 23);
            this.cmb_Rol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(191, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 13);
            this.panel2.TabIndex = 11;
            // 
            // ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caja_pass);
            this.Controls.Add(this.caja_correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ventana1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_v1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caja_correo;
        private System.Windows.Forms.TextBox caja_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Rol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox cerrar_v1;
        private System.Windows.Forms.PictureBox minimizar_v2;
        private System.Windows.Forms.PictureBox maximizar_v1;
        private System.Windows.Forms.PictureBox restaurar_v1;
        private System.Windows.Forms.Panel panel2;
    }
}

