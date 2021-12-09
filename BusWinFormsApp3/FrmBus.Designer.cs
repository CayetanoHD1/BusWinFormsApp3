
namespace BusWinFormsApp3
{
    partial class ventana5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana5));
            this.panel1Bus = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1Bus
            // 
            this.panel1Bus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.panel1Bus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1Bus.Location = new System.Drawing.Point(0, 466);
            this.panel1Bus.Name = "panel1Bus";
            this.panel1Bus.Size = new System.Drawing.Size(1301, 15);
            this.panel1Bus.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnOk);
            this.panel2.Controls.Add(this.txt_color);
            this.panel2.Controls.Add(this.txt_año);
            this.panel2.Controls.Add(this.txt_placa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_modelo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_marca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 466);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(731, 369);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(140, 46);
            this.BtnOk.TabIndex = 34;
            this.BtnOk.Text = "Agregar";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click_1);
            // 
            // txt_color
            // 
            this.txt_color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_color.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_color.Location = new System.Drawing.Point(833, 209);
            this.txt_color.Multiline = true;
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(268, 33);
            this.txt_color.TabIndex = 33;
            // 
            // txt_año
            // 
            this.txt_año.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_año.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_año.Location = new System.Drawing.Point(833, 142);
            this.txt_año.Multiline = true;
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(268, 33);
            this.txt_año.TabIndex = 32;
            this.txt_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_año_KeyPress);
            // 
            // txt_placa
            // 
            this.txt_placa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_placa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_placa.Location = new System.Drawing.Point(479, 265);
            this.txt_placa.Multiline = true;
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(268, 33);
            this.txt_placa.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(404, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Placa:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(772, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Año:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(770, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Color:";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_modelo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_modelo.Location = new System.Drawing.Point(479, 204);
            this.txt_modelo.Multiline = true;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(268, 33);
            this.txt_modelo.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(404, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Modelo:";
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_marca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_marca.Location = new System.Drawing.Point(479, 145);
            this.txt_marca.Multiline = true;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(268, 33);
            this.txt_marca.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(404, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(627, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Agregar AutoBus";
            // 
            // ventana5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1Bus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventana5";
            this.Text = "ventana5";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1Bus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}