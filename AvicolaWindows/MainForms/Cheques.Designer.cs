namespace AvicolaWindows.MainForms
{
    partial class Cheques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtClientes = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTkt = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BuscarPorNumTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevaOpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 115);
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.Text = "ID";
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(105, 115);
            this.BuscarTxt.Size = new System.Drawing.Size(105, 19);
            this.BuscarTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarTxt_KeyUp);
            this.BuscarTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarTxt_MouseDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(107, 34);
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.Text = "Cartera de Cheques";
            // 
            // VerBtn
            // 
            this.VerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerBtn.Location = new System.Drawing.Point(804, 287);
            this.VerBtn.Visible = false;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(708, 517);
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(777, 116);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(105, 137);
            this.pictureBox9.Size = new System.Drawing.Size(105, 1);
            // 
            // NuevaOpBtn
            // 
            this.NuevaOpBtn.Location = new System.Drawing.Point(804, 353);
            this.NuevaOpBtn.Visible = false;
            // 
            // FacturaBtn
            // 
            this.FacturaBtn.Location = new System.Drawing.Point(817, 439);
            this.FacturaBtn.Visible = false;
            // 
            // ExelBtn
            // 
            this.ExelBtn.FlatAppearance.BorderSize = 0;
            this.ExelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExelBtn.Location = new System.Drawing.Point(840, 115);
            this.ExelBtn.Size = new System.Drawing.Size(30, 28);
            this.ExelBtn.Click += new System.EventHandler(this.ExelBtn_Click);
            // 
            // DtClientes
            // 
            this.DtClientes.AllowUserToAddRows = false;
            this.DtClientes.AllowUserToDeleteRows = false;
            this.DtClientes.AllowUserToResizeColumns = false;
            this.DtClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            this.DtClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.DtClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DtClientes.EnableHeadersVisualStyles = false;
            this.DtClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.Location = new System.Drawing.Point(64, 162);
            this.DtClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DtClientes.MultiSelect = false;
            this.DtClientes.Name = "DtClientes";
            this.DtClientes.RowHeadersVisible = false;
            this.DtClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.DtClientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DtClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DtClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DtClientes.RowTemplate.Height = 28;
            this.DtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtClientes.Size = new System.Drawing.Size(769, 341);
            this.DtClientes.TabIndex = 76;
            this.DtClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtClientes_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 78;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(462, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "Fecha";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::AvicolaWindows.Properties.Resources.CajaPic;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(25, 23);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 49);
            this.pictureBox6.TabIndex = 90;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(295, 552);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Total";
            this.label2.Visible = false;
            // 
            // TotalTkt
            // 
            this.TotalTkt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTkt.AutoSize = true;
            this.TotalTkt.BackColor = System.Drawing.Color.Transparent;
            this.TotalTkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTkt.ForeColor = System.Drawing.Color.White;
            this.TotalTkt.Location = new System.Drawing.Point(356, 552);
            this.TotalTkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTkt.Name = "TotalTkt";
            this.TotalTkt.Size = new System.Drawing.Size(60, 24);
            this.TotalTkt.TabIndex = 91;
            this.TotalTkt.Text = "label2";
            this.TotalTkt.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(639, 114);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 93;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(281, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 1);
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // BuscarPorNumTxt
            // 
            this.BuscarPorNumTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BuscarPorNumTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BuscarPorNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarPorNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorNumTxt.ForeColor = System.Drawing.Color.White;
            this.BuscarPorNumTxt.Location = new System.Drawing.Point(281, 114);
            this.BuscarPorNumTxt.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarPorNumTxt.Name = "BuscarPorNumTxt";
            this.BuscarPorNumTxt.Size = new System.Drawing.Size(149, 19);
            this.BuscarPorNumTxt.TabIndex = 94;
            this.BuscarPorNumTxt.Text = " Buscar";
            this.BuscarPorNumTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarPorNumTxt_KeyUp);
            this.BuscarPorNumTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarPorNumTxt_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "N°";
            // 
            // Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BuscarPorNumTxt);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTkt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DtClientes);
            this.Name = "Cheques";
            this.Text = "Cheques";
            this.Load += new System.EventHandler(this.Cheques_Load);
            this.Controls.SetChildIndex(this.VerBtn, 0);
            this.Controls.SetChildIndex(this.EliminarBtn, 0);
            this.Controls.SetChildIndex(this.NuevaOpBtn, 0);
            this.Controls.SetChildIndex(this.FacturaBtn, 0);
            this.Controls.SetChildIndex(this.DtClientes, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BuscarTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Seleccionado, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox9, 0);
            this.Controls.SetChildIndex(this.ExelBtn, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.TotalTkt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.BuscarPorNumTxt, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevaOpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DtClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalTkt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox BuscarPorNumTxt;
        public System.Windows.Forms.Label label3;
    }
}