namespace AvicolaWindows
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTkt = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
            this.label4.Location = new System.Drawing.Point(132, 177);
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.Text = "Alias";
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(241, 175);
            this.BuscarTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarTxt_KeyUp);
            this.BuscarTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarTxt_MouseDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 53);
            this.label1.Size = new System.Drawing.Size(214, 58);
            this.label1.Text = "Clientes";
            // 
            // Seleccionado
            // 
            this.Seleccionado.Location = new System.Drawing.Point(1276, 53);
            // 
            // VerBtn
            // 
            this.VerBtn.Location = new System.Drawing.Point(91, 729);
            this.VerBtn.Click += new System.EventHandler(this.VerBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(1081, 729);
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1157, 166);
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(241, 209);
            // 
            // NuevaOpBtn
            // 
            this.NuevaOpBtn.Location = new System.Drawing.Point(556, 729);
            this.NuevaOpBtn.Click += new System.EventHandler(this.NuevaOpBtn_Click);
            // 
            // FacturaBtn
            // 
            this.FacturaBtn.Location = new System.Drawing.Point(1184, 532);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.DtClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DtClientes.EnableHeadersVisualStyles = false;
            this.DtClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtClientes.Location = new System.Drawing.Point(91, 237);
            this.DtClientes.MultiSelect = false;
            this.DtClientes.Name = "DtClientes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtClientes.RowHeadersVisible = false;
            this.DtClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.DtClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DtClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DtClientes.RowTemplate.Height = 28;
            this.DtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtClientes.Size = new System.Drawing.Size(1154, 500);
            this.DtClientes.TabIndex = 20;
            this.DtClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtClientes_CellClick);
            this.DtClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtClientes_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(933, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 77;
            this.label2.Text = "Total";
            // 
            // TotalTkt
            // 
            this.TotalTkt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTkt.AutoSize = true;
            this.TotalTkt.BackColor = System.Drawing.Color.Transparent;
            this.TotalTkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTkt.ForeColor = System.Drawing.Color.White;
            this.TotalTkt.Location = new System.Drawing.Point(1025, 749);
            this.TotalTkt.Name = "TotalTkt";
            this.TotalTkt.Size = new System.Drawing.Size(93, 32);
            this.TotalTkt.TabIndex = 76;
            this.TotalTkt.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::AvicolaWindows.Properties.Resources.pngocean7;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(38, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 76);
            this.pictureBox6.TabIndex = 87;
            this.pictureBox6.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1378, 854);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTkt);
            this.Controls.Add(this.DtClientes);
            this.Name = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Controls.SetChildIndex(this.ExelBtn, 0);
            this.Controls.SetChildIndex(this.NuevaOpBtn, 0);
            this.Controls.SetChildIndex(this.FacturaBtn, 0);
            this.Controls.SetChildIndex(this.pictureBox9, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.VerBtn, 0);
            this.Controls.SetChildIndex(this.EliminarBtn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BuscarTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Seleccionado, 0);
            this.Controls.SetChildIndex(this.DtClientes, 0);
            this.Controls.SetChildIndex(this.TotalTkt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalTkt;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}