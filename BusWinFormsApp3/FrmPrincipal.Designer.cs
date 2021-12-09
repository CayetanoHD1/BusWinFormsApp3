
namespace BusWinFormsApp3
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel_barra = new System.Windows.Forms.Panel();
            this.restaurar_v2 = new System.Windows.Forms.PictureBox();
            this.minimizar_v2 = new System.Windows.Forms.PictureBox();
            this.maximizar_v2 = new System.Windows.Forms.PictureBox();
            this.cerrar_v2 = new System.Windows.Forms.PictureBox();
            this.panel_Laterar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opcion2 = new System.Windows.Forms.PictureBox();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.PictureBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Btb_conductor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Ruta = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.PictureBox();
            this.panel_Centrar = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerOcultar = new System.Windows.Forms.Timer(this.components);
            this.mostrar = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panels = new System.Windows.Forms.Panel();
            this.panel_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_v2)).BeginInit();
            this.panel_Laterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto)).BeginInit();
            this.panel_Centrar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.panel_barra.Controls.Add(this.restaurar_v2);
            this.panel_barra.Controls.Add(this.minimizar_v2);
            this.panel_barra.Controls.Add(this.maximizar_v2);
            this.panel_barra.Controls.Add(this.cerrar_v2);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_barra.ForeColor = System.Drawing.Color.Black;
            this.panel_barra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(1221, 34);
            this.panel_barra.TabIndex = 0;
            // 
            // restaurar_v2
            // 
            this.restaurar_v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar_v2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar_v2.Image = ((System.Drawing.Image)(resources.GetObject("restaurar_v2.Image")));
            this.restaurar_v2.Location = new System.Drawing.Point(1162, 3);
            this.restaurar_v2.Name = "restaurar_v2";
            this.restaurar_v2.Size = new System.Drawing.Size(25, 25);
            this.restaurar_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar_v2.TabIndex = 3;
            this.restaurar_v2.TabStop = false;
            this.restaurar_v2.Visible = false;
            this.restaurar_v2.Click += new System.EventHandler(this.agrandar_v2_Click);
            // 
            // minimizar_v2
            // 
            this.minimizar_v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar_v2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar_v2.Image = ((System.Drawing.Image)(resources.GetObject("minimizar_v2.Image")));
            this.minimizar_v2.Location = new System.Drawing.Point(1131, 3);
            this.minimizar_v2.Name = "minimizar_v2";
            this.minimizar_v2.Size = new System.Drawing.Size(25, 25);
            this.minimizar_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar_v2.TabIndex = 2;
            this.minimizar_v2.TabStop = false;
            this.minimizar_v2.Click += new System.EventHandler(this.minimizar_v2_Click);
            // 
            // maximizar_v2
            // 
            this.maximizar_v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar_v2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar_v2.Image = ((System.Drawing.Image)(resources.GetObject("maximizar_v2.Image")));
            this.maximizar_v2.Location = new System.Drawing.Point(1162, 0);
            this.maximizar_v2.Name = "maximizar_v2";
            this.maximizar_v2.Size = new System.Drawing.Size(25, 25);
            this.maximizar_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar_v2.TabIndex = 1;
            this.maximizar_v2.TabStop = false;
            this.maximizar_v2.Click += new System.EventHandler(this.maximizar_v2_Click);
            // 
            // cerrar_v2
            // 
            this.cerrar_v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar_v2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar_v2.Image = ((System.Drawing.Image)(resources.GetObject("cerrar_v2.Image")));
            this.cerrar_v2.Location = new System.Drawing.Point(1193, 0);
            this.cerrar_v2.Name = "cerrar_v2";
            this.cerrar_v2.Size = new System.Drawing.Size(25, 25);
            this.cerrar_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_v2.TabIndex = 0;
            this.cerrar_v2.TabStop = false;
            this.cerrar_v2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_Laterar
            // 
            this.panel_Laterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Laterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_Laterar.Controls.Add(this.button1);
            this.panel_Laterar.Controls.Add(this.pictureBox1);
            this.panel_Laterar.Controls.Add(this.opcion2);
            this.panel_Laterar.Controls.Add(this.auto1);
            this.panel_Laterar.Controls.Add(this.btnUsuario);
            this.panel_Laterar.Controls.Add(this.menu);
            this.panel_Laterar.Controls.Add(this.btnVincular);
            this.panel_Laterar.Controls.Add(this.button4);
            this.panel_Laterar.Controls.Add(this.Btb_conductor);
            this.panel_Laterar.Controls.Add(this.button2);
            this.panel_Laterar.Controls.Add(this.Btn_Ruta);
            this.panel_Laterar.Controls.Add(this.auto);
            this.panel_Laterar.Location = new System.Drawing.Point(0, 34);
            this.panel_Laterar.Name = "panel_Laterar";
            this.panel_Laterar.Size = new System.Drawing.Size(206, 562);
            this.panel_Laterar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "DashBoard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // opcion2
            // 
            this.opcion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcion2.Image = ((System.Drawing.Image)(resources.GetObject("opcion2.Image")));
            this.opcion2.Location = new System.Drawing.Point(3, 67);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(39, 40);
            this.opcion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opcion2.TabIndex = 10;
            this.opcion2.TabStop = false;
            this.opcion2.Visible = false;
            // 
            // auto1
            // 
            this.auto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto1.Image = ((System.Drawing.Image)(resources.GetObject("auto1.Image")));
            this.auto1.Location = new System.Drawing.Point(3, 3);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(161, 127);
            this.auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.auto1.TabIndex = 9;
            this.auto1.TabStop = false;
            this.auto1.Click += new System.EventHandler(this.auto1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 277);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(203, 34);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Shop";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(-1861, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(36, 34);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 5;
            this.menu.TabStop = false;
            // 
            // btnVincular
            // 
            this.btnVincular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVincular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVincular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincular.FlatAppearance.BorderSize = 0;
            this.btnVincular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVincular.ForeColor = System.Drawing.Color.White;
            this.btnVincular.Image = ((System.Drawing.Image)(resources.GetObject("btnVincular.Image")));
            this.btnVincular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVincular.Location = new System.Drawing.Point(3, 399);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(203, 34);
            this.btnVincular.TabIndex = 4;
            this.btnVincular.Text = "  Vincular Conductor";
            this.btnVincular.UseVisualStyleBackColor = false;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "   ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btb_conductor
            // 
            this.Btb_conductor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btb_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btb_conductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btb_conductor.FlatAppearance.BorderSize = 0;
            this.Btb_conductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Btb_conductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btb_conductor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btb_conductor.ForeColor = System.Drawing.Color.White;
            this.Btb_conductor.Image = ((System.Drawing.Image)(resources.GetObject("Btb_conductor.Image")));
            this.Btb_conductor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btb_conductor.Location = new System.Drawing.Point(1, 332);
            this.Btb_conductor.Name = "Btb_conductor";
            this.Btb_conductor.Size = new System.Drawing.Size(205, 34);
            this.Btb_conductor.TabIndex = 2;
            this.Btb_conductor.Text = "   Agregar Conductor";
            this.Btb_conductor.UseVisualStyleBackColor = false;
            this.Btb_conductor.Click += new System.EventHandler(this.Btb_conductor_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Bus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Ruta
            // 
            this.Btn_Ruta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Ruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Ruta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ruta.FlatAppearance.BorderSize = 0;
            this.Btn_Ruta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Btn_Ruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ruta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Ruta.ForeColor = System.Drawing.Color.White;
            this.Btn_Ruta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ruta.Image")));
            this.Btn_Ruta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ruta.Location = new System.Drawing.Point(3, 148);
            this.Btn_Ruta.Name = "Btn_Ruta";
            this.Btn_Ruta.Size = new System.Drawing.Size(203, 34);
            this.Btn_Ruta.TabIndex = 0;
            this.Btn_Ruta.Text = "Agregar Ruta";
            this.Btn_Ruta.UseVisualStyleBackColor = false;
            this.Btn_Ruta.Click += new System.EventHandler(this.Btn_Ruta_Click);
            // 
            // auto
            // 
            this.auto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto.Image = ((System.Drawing.Image)(resources.GetObject("auto.Image")));
            this.auto.Location = new System.Drawing.Point(-1011, 4);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(163, 131);
            this.auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.auto.TabIndex = 0;
            this.auto.TabStop = false;
            // 
            // panel_Centrar
            // 
            this.panel_Centrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Centrar.BackColor = System.Drawing.Color.White;
            this.panel_Centrar.Controls.Add(this.name);
            this.panel_Centrar.Location = new System.Drawing.Point(202, 34);
            this.panel_Centrar.Name = "panel_Centrar";
            this.panel_Centrar.Size = new System.Drawing.Size(1019, 562);
            this.panel_Centrar.TabIndex = 2;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Location = new System.Drawing.Point(250, 192);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(479, 146);
            this.name.TabIndex = 2;
            this.name.Tag = "";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 15);
            this.panel1.TabIndex = 3;
            // 
            // timerOcultar
            // 
            this.timerOcultar.Tick += new System.EventHandler(this.timerOcultar_Tick);
            // 
            // mostrar
            // 
            this.mostrar.Tick += new System.EventHandler(this.mostrar_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Violet;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(150, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 100);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGreen;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(100, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 100);
            this.panel8.TabIndex = 2;
            // 
            // panels
            // 
            this.panels.Controls.Add(this.panel_Centrar);
            this.panels.Controls.Add(this.panel_Laterar);
            this.panels.Controls.Add(this.panel1);
            this.panels.Controls.Add(this.panel_barra);
            this.panels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panels.Location = new System.Drawing.Point(0, 0);
            this.panels.Name = "panels";
            this.panels.Size = new System.Drawing.Size(1221, 611);
            this.panels.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 611);
            this.Controls.Add(this.panels);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_v2)).EndInit();
            this.panel_Laterar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto)).EndInit();
            this.panel_Centrar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra;
        private System.Windows.Forms.Panel panel_Laterar;
        private System.Windows.Forms.Panel panel_Centrar;
        private System.Windows.Forms.PictureBox restaurar_v2;
        private System.Windows.Forms.PictureBox minimizar_v2;
        private System.Windows.Forms.PictureBox maximizar_v2;
        private System.Windows.Forms.PictureBox cerrar_v2;
        private System.Windows.Forms.Button Btn_Ruta;
        private System.Windows.Forms.PictureBox auto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Timer timerOcultar;
        private System.Windows.Forms.Timer mostrar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Button btnVincular;
        public System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panels;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.PictureBox opcion2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Btb_conductor;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
    }
}