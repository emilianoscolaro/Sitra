namespace AvicolaWindows
{
    partial class Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtClientes = new System.Windows.Forms.DataGridView();
            this.TotalTkt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.EditaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevaOpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(88, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.Text = "Alias";
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(161, 114);
            this.BuscarTxt.Margin = new System.Windows.Forms.Padding(1);
            this.BuscarTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarTxt_KeyUp);
            this.BuscarTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarTxt_MouseDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(107, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.Text = "Proveedores";
            // 
            // Seleccionado
            // 
            this.Seleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // VerBtn
            // 
            this.VerBtn.Location = new System.Drawing.Point(275, 519);
            this.VerBtn.Margin = new System.Windows.Forms.Padding(1);
            this.VerBtn.Click += new System.EventHandler(this.VerBtn_Click_1);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(721, 519);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(1);
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(771, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(161, 136);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(1);
            // 
            // NuevaOpBtn
            // 
            this.NuevaOpBtn.Location = new System.Drawing.Point(511, 519);
            this.NuevaOpBtn.Margin = new System.Windows.Forms.Padding(1);
            this.NuevaOpBtn.Click += new System.EventHandler(this.NuevaOpBtn_Click);
            // 
            // FacturaBtn
            // 
            this.FacturaBtn.Location = new System.Drawing.Point(0, 340);
            this.FacturaBtn.Margin = new System.Windows.Forms.Padding(1);
            this.FacturaBtn.Visible = false;
            // 
            // ExelBtn
            // 
            this.ExelBtn.FlatAppearance.BorderSize = 0;
            this.ExelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExelBtn.Click += new System.EventHandler(this.ExelBtn_Click);
            // 
            // DtClientes
            // 
            this.DtClientes.AllowUserToAddRows = false;
            this.DtClientes.AllowUserToDeleteRows = false;
            this.DtClientes.AllowUserToResizeColumns = false;
            this.DtClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            this.DtClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DtClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtClientes.DefaultCellStyle = dataGridViewCellStyle13;
            this.DtClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DtClientes.EnableHeadersVisualStyles = false;
            this.DtClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.Location = new System.Drawing.Point(61, 154);
            this.DtClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DtClientes.MultiSelect = false;
            this.DtClientes.Name = "DtClientes";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DtClientes.RowHeadersVisible = false;
            this.DtClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.DtClientes.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DtClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DtClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DtClientes.RowTemplate.Height = 28;
            this.DtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtClientes.Size = new System.Drawing.Size(769, 325);
            this.DtClientes.TabIndex = 0;
            this.DtClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtClientes_CellClick_1);
            this.DtClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtClientes_CellDoubleClick);
            // 
            // TotalTkt
            // 
            this.TotalTkt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTkt.AutoSize = true;
            this.TotalTkt.BackColor = System.Drawing.Color.Transparent;
            this.TotalTkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTkt.ForeColor = System.Drawing.Color.White;
            this.TotalTkt.Location = new System.Drawing.Point(685, 487);
            this.TotalTkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTkt.Name = "TotalTkt";
            this.TotalTkt.Size = new System.Drawing.Size(60, 24);
            this.TotalTkt.TabIndex = 50;
            this.TotalTkt.Text = "label2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(623, 487);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Total";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::AvicolaWindows.Properties.Resources.pngocean_com__2_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(27, 34);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 38);
            this.pictureBox6.TabIndex = 87;
            this.pictureBox6.TabStop = false;
            // 
            // EditaBtn
            // 
            this.EditaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditaBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditaBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.EditBtn;
            this.EditaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditaBtn.FlatAppearance.BorderSize = 0;
            this.EditaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditaBtn.Location = new System.Drawing.Point(61, 519);
            this.EditaBtn.Name = "EditaBtn";
            this.EditaBtn.Size = new System.Drawing.Size(109, 26);
            this.EditaBtn.TabIndex = 89;
            this.EditaBtn.UseVisualStyleBackColor = false;
            this.EditaBtn.Click += new System.EventHandler(this.EditaBtn_Click);
            this.EditaBtn.MouseEnter += new System.EventHandler(this.EditaBtn_MouseEnter);
            this.EditaBtn.MouseLeave += new System.EventHandler(this.EditaBtn_MouseLeave);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 576);
            this.Controls.Add(this.EditaBtn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTkt);
            this.Controls.Add(this.DtClientes);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.Controls.SetChildIndex(this.ExelBtn, 0);
            this.Controls.SetChildIndex(this.NuevaOpBtn, 0);
            this.Controls.SetChildIndex(this.FacturaBtn, 0);
            this.Controls.SetChildIndex(this.pictureBox9, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BuscarTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Seleccionado, 0);
            this.Controls.SetChildIndex(this.VerBtn, 0);
            this.Controls.SetChildIndex(this.EliminarBtn, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.DtClientes, 0);
            this.Controls.SetChildIndex(this.TotalTkt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.EditaBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevaOpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DtClientes;
        private System.Windows.Forms.Label TotalTkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button EditaBtn;
    }
}