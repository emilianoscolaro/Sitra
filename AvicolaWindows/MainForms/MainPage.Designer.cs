namespace AvicolaWindows
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CajaPanel = new System.Windows.Forms.Panel();
            this.CobranzasBtn = new System.Windows.Forms.Button();
            this.PagosBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OpPanel = new System.Windows.Forms.Panel();
            this.OpProveeBtn = new System.Windows.Forms.Button();
            this.OpClientBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.XBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.CajaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OpBtn = new System.Windows.Forms.Button();
            this.InventarioBtn = new System.Windows.Forms.Button();
            this.ProveedoresBtn = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CajaPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.OpPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 208);
            this.panel2.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.Location = new System.Drawing.Point(99, 86);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(86, 25);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Usuario";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(114, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdminBtn.FlatAppearance.BorderSize = 0;
            this.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.Black;
            this.AdminBtn.Location = new System.Drawing.Point(0, 208);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AdminBtn.Size = new System.Drawing.Size(215, 72);
            this.AdminBtn.TabIndex = 2;
            this.AdminBtn.Text = "Administrar Usuarios";
            this.AdminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            this.AdminBtn.MouseEnter += new System.EventHandler(this.AdminBtn_MouseEnter);
            this.AdminBtn.MouseLeave += new System.EventHandler(this.AdminBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CajaPanel);
            this.panel1.Controls.Add(this.CajaBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.OpPanel);
            this.panel1.Controls.Add(this.OpBtn);
            this.panel1.Controls.Add(this.InventarioBtn);
            this.panel1.Controls.Add(this.ProveedoresBtn);
            this.panel1.Controls.Add(this.ClientesBtn);
            this.panel1.Controls.Add(this.AdminBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 976);
            this.panel1.TabIndex = 6;
            // 
            // CajaPanel
            // 
            this.CajaPanel.Controls.Add(this.CobranzasBtn);
            this.CajaPanel.Controls.Add(this.PagosBtn);
            this.CajaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CajaPanel.Location = new System.Drawing.Point(0, 753);
            this.CajaPanel.Name = "CajaPanel";
            this.CajaPanel.Size = new System.Drawing.Size(215, 113);
            this.CajaPanel.TabIndex = 16;
            this.CajaPanel.Visible = false;
            // 
            // CobranzasBtn
            // 
            this.CobranzasBtn.BackColor = System.Drawing.Color.Transparent;
            this.CobranzasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CobranzasBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CobranzasBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CobranzasBtn.FlatAppearance.BorderSize = 0;
            this.CobranzasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CobranzasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CobranzasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobranzasBtn.ForeColor = System.Drawing.Color.Black;
            this.CobranzasBtn.Location = new System.Drawing.Point(0, 0);
            this.CobranzasBtn.Name = "CobranzasBtn";
            this.CobranzasBtn.Padding = new System.Windows.Forms.Padding(50, 0, 10, 0);
            this.CobranzasBtn.Size = new System.Drawing.Size(215, 50);
            this.CobranzasBtn.TabIndex = 13;
            this.CobranzasBtn.Text = "Cobranzas";
            this.CobranzasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CobranzasBtn.UseVisualStyleBackColor = false;
            this.CobranzasBtn.Click += new System.EventHandler(this.CobranzasBtn_Click);
            // 
            // PagosBtn
            // 
            this.PagosBtn.BackColor = System.Drawing.Color.Transparent;
            this.PagosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PagosBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PagosBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PagosBtn.FlatAppearance.BorderSize = 0;
            this.PagosBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PagosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagosBtn.ForeColor = System.Drawing.Color.Black;
            this.PagosBtn.Location = new System.Drawing.Point(0, 63);
            this.PagosBtn.Name = "PagosBtn";
            this.PagosBtn.Padding = new System.Windows.Forms.Padding(50, 0, 10, 0);
            this.PagosBtn.Size = new System.Drawing.Size(215, 50);
            this.PagosBtn.TabIndex = 12;
            this.PagosBtn.Text = "Pagos";
            this.PagosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PagosBtn.UseVisualStyleBackColor = false;
            this.PagosBtn.Click += new System.EventHandler(this.PagosBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 938);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 121);
            this.panel4.TabIndex = 13;
            // 
            // OpPanel
            // 
            this.OpPanel.Controls.Add(this.OpProveeBtn);
            this.OpPanel.Controls.Add(this.OpClientBtn);
            this.OpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpPanel.Location = new System.Drawing.Point(0, 568);
            this.OpPanel.Name = "OpPanel";
            this.OpPanel.Size = new System.Drawing.Size(215, 113);
            this.OpPanel.TabIndex = 12;
            this.OpPanel.Visible = false;
            // 
            // OpProveeBtn
            // 
            this.OpProveeBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpProveeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpProveeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpProveeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpProveeBtn.FlatAppearance.BorderSize = 0;
            this.OpProveeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpProveeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpProveeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpProveeBtn.ForeColor = System.Drawing.Color.Black;
            this.OpProveeBtn.Location = new System.Drawing.Point(0, 50);
            this.OpProveeBtn.Name = "OpProveeBtn";
            this.OpProveeBtn.Padding = new System.Windows.Forms.Padding(50, 0, 10, 0);
            this.OpProveeBtn.Size = new System.Drawing.Size(215, 50);
            this.OpProveeBtn.TabIndex = 13;
            this.OpProveeBtn.Text = "Compra";
            this.OpProveeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpProveeBtn.UseVisualStyleBackColor = false;
            this.OpProveeBtn.Click += new System.EventHandler(this.OpProveeBtn_Click);
            // 
            // OpClientBtn
            // 
            this.OpClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpClientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpClientBtn.FlatAppearance.BorderSize = 0;
            this.OpClientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpClientBtn.ForeColor = System.Drawing.Color.Black;
            this.OpClientBtn.Location = new System.Drawing.Point(0, 0);
            this.OpClientBtn.Name = "OpClientBtn";
            this.OpClientBtn.Padding = new System.Windows.Forms.Padding(50, 0, 10, 0);
            this.OpClientBtn.Size = new System.Drawing.Size(215, 50);
            this.OpClientBtn.TabIndex = 12;
            this.OpClientBtn.Text = "Venta";
            this.OpClientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpClientBtn.UseVisualStyleBackColor = false;
            this.OpClientBtn.Click += new System.EventHandler(this.OpClientBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.MinBtn);
            this.panel3.Controls.Add(this.MaxBtn);
            this.panel3.Controls.Add(this.XBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(241, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 66);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown_1);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove_1);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp_1);
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(1194, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(60, 66);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(1254, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(60, 66);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.Text = "■";
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // XBtn
            // 
            this.XBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.XBtn.FlatAppearance.BorderSize = 0;
            this.XBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBtn.ForeColor = System.Drawing.Color.White;
            this.XBtn.Location = new System.Drawing.Point(1314, 0);
            this.XBtn.Name = "XBtn";
            this.XBtn.Size = new System.Drawing.Size(86, 66);
            this.XBtn.TabIndex = 0;
            this.XBtn.Text = "X";
            this.XBtn.UseVisualStyleBackColor = true;
            this.XBtn.Click += new System.EventHandler(this.XBtn_Click);
            this.XBtn.MouseEnter += new System.EventHandler(this.XBtn_MouseEnter);
            this.XBtn.MouseLeave += new System.EventHandler(this.XBtn_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainPanel.BackgroundImage = global::AvicolaWindows.Properties.Resources.FondoUno;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.pictureBox3);
            this.MainPanel.Controls.Add(this.NuevoBtn);
            this.MainPanel.Controls.Add(this.BackBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(241, 66);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1400, 910);
            this.MainPanel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::AvicolaWindows.Properties.Resources.AvicolaLogo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(466, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(533, 199);
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NuevoBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.NuevoBtn;
            this.NuevoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NuevoBtn.FlatAppearance.BorderSize = 0;
            this.NuevoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NuevoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBtn.ForeColor = System.Drawing.Color.White;
            this.NuevoBtn.Location = new System.Drawing.Point(0, 267);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(56, 163);
            this.NuevoBtn.TabIndex = 0;
            this.NuevoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoBtn.UseVisualStyleBackColor = false;
            this.NuevoBtn.Visible = false;
            this.NuevoBtn.Click += new System.EventHandler(this.NuevoBtn_Click);
            this.NuevoBtn.MouseEnter += new System.EventHandler(this.NuevoBtn_MouseEnter);
            this.NuevoBtn.MouseLeave += new System.EventHandler(this.NuevoBtn_MouseLeave);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Back;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.Location = new System.Drawing.Point(24, 29);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(111, 88);
            this.BackBtn.TabIndex = 71;
            this.BackBtn.TabStop = false;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CajaBtn
            // 
            this.CajaBtn.BackColor = System.Drawing.Color.Transparent;
            this.CajaBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Caja;
            this.CajaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CajaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CajaBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CajaBtn.FlatAppearance.BorderSize = 0;
            this.CajaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.CajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CajaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaBtn.ForeColor = System.Drawing.Color.Black;
            this.CajaBtn.Location = new System.Drawing.Point(0, 681);
            this.CajaBtn.Name = "CajaBtn";
            this.CajaBtn.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.CajaBtn.Size = new System.Drawing.Size(215, 72);
            this.CajaBtn.TabIndex = 15;
            this.CajaBtn.Text = "Caja";
            this.CajaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CajaBtn.UseVisualStyleBackColor = false;
            this.CajaBtn.Click += new System.EventHandler(this.CajaBtn_Click);
            this.CajaBtn.MouseEnter += new System.EventHandler(this.CajaBtn_MouseEnter);
            this.CajaBtn.MouseLeave += new System.EventHandler(this.CajaBtn_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AvicolaWindows.Properties.Resources.pngocean6;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::AvicolaWindows.Properties.Resources.pngocean1;
            this.button1.Location = new System.Drawing.Point(0, 866);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(215, 72);
            this.button1.TabIndex = 14;
            this.button1.Text = "Configuracion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AvicolaWindows.Properties.Resources.Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(48, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 44);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // OpBtn
            // 
            this.OpBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Operaciones;
            this.OpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpBtn.FlatAppearance.BorderSize = 0;
            this.OpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.OpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpBtn.ForeColor = System.Drawing.Color.Black;
            this.OpBtn.Location = new System.Drawing.Point(0, 496);
            this.OpBtn.Name = "OpBtn";
            this.OpBtn.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.OpBtn.Size = new System.Drawing.Size(215, 72);
            this.OpBtn.TabIndex = 11;
            this.OpBtn.Text = "Operaciones";
            this.OpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpBtn.UseVisualStyleBackColor = false;
            this.OpBtn.Click += new System.EventHandler(this.OpBtn_Click);
            this.OpBtn.MouseEnter += new System.EventHandler(this.OpBtn_MouseEnter);
            this.OpBtn.MouseLeave += new System.EventHandler(this.OpBtn_MouseLeave);
            // 
            // InventarioBtn
            // 
            this.InventarioBtn.BackColor = System.Drawing.Color.Transparent;
            this.InventarioBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Stock;
            this.InventarioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventarioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventarioBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InventarioBtn.FlatAppearance.BorderSize = 0;
            this.InventarioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.InventarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioBtn.ForeColor = System.Drawing.Color.Black;
            this.InventarioBtn.Location = new System.Drawing.Point(0, 424);
            this.InventarioBtn.Name = "InventarioBtn";
            this.InventarioBtn.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.InventarioBtn.Size = new System.Drawing.Size(215, 72);
            this.InventarioBtn.TabIndex = 10;
            this.InventarioBtn.Text = "Inventario";
            this.InventarioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventarioBtn.UseVisualStyleBackColor = false;
            this.InventarioBtn.Click += new System.EventHandler(this.InventarioBtn_Click);
            this.InventarioBtn.MouseEnter += new System.EventHandler(this.InventarioBtn_MouseEnter);
            this.InventarioBtn.MouseLeave += new System.EventHandler(this.InventarioBtn_MouseLeave);
            // 
            // ProveedoresBtn
            // 
            this.ProveedoresBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Proveedores;
            this.ProveedoresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProveedoresBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProveedoresBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProveedoresBtn.FlatAppearance.BorderSize = 0;
            this.ProveedoresBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.ProveedoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProveedoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresBtn.ForeColor = System.Drawing.Color.Black;
            this.ProveedoresBtn.Location = new System.Drawing.Point(0, 352);
            this.ProveedoresBtn.Name = "ProveedoresBtn";
            this.ProveedoresBtn.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.ProveedoresBtn.Size = new System.Drawing.Size(215, 72);
            this.ProveedoresBtn.TabIndex = 9;
            this.ProveedoresBtn.Text = "Proveedores";
            this.ProveedoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProveedoresBtn.UseVisualStyleBackColor = false;
            this.ProveedoresBtn.Click += new System.EventHandler(this.ProveedoresBtn_Click);
            this.ProveedoresBtn.MouseEnter += new System.EventHandler(this.ProveedoresBtn_MouseEnter);
            this.ProveedoresBtn.MouseLeave += new System.EventHandler(this.ProveedoresBtn_MouseLeave);
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClientesBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Clientes;
            this.ClientesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClientesBtn.FlatAppearance.BorderSize = 0;
            this.ClientesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(173)))), ((int)(((byte)(97)))));
            this.ClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.ForeColor = System.Drawing.Color.Black;
            this.ClientesBtn.Location = new System.Drawing.Point(0, 280);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.ClientesBtn.Size = new System.Drawing.Size(215, 72);
            this.ClientesBtn.TabIndex = 8;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientesBtn.UseVisualStyleBackColor = false;
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            this.ClientesBtn.MouseEnter += new System.EventHandler(this.ClientesBtn_MouseEnter);
            this.ClientesBtn.MouseLeave += new System.EventHandler(this.ClientesBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AvicolaWindows.Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 59);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1641, 976);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "MainPage";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.CajaPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.OpPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button XBtn;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ProveedoresBtn;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Button InventarioBtn;
        private System.Windows.Forms.Button OpBtn;
        private System.Windows.Forms.Panel OpPanel;
        private System.Windows.Forms.Button OpProveeBtn;
        private System.Windows.Forms.Button OpClientBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel CajaPanel;
        private System.Windows.Forms.Button CobranzasBtn;
        private System.Windows.Forms.Button PagosBtn;
        private System.Windows.Forms.Button CajaBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}