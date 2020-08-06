namespace AvicolaWindows.MainForms
{
    partial class InventarioHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioHistorico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker1
            // 
            this.DatePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.DatePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DatePicker1.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.DatePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DatePicker1.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.DatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker1.Location = new System.Drawing.Point(132, 31);
            this.DatePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(98, 20);
            this.DatePicker1.TabIndex = 97;
            this.DatePicker1.ValueChanged += new System.EventHandler(this.DatePicker1_ValueChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.BackgroundImage = global::AvicolaWindows.Properties.Resources.Back;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.Location = new System.Drawing.Point(31, 11);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 57);
            this.BackBtn.TabIndex = 98;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(276, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 57);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DtStock
            // 
            this.DtStock.AllowUserToAddRows = false;
            this.DtStock.AllowUserToDeleteRows = false;
            this.DtStock.AllowUserToResizeColumns = false;
            this.DtStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.DtStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtStock.BackgroundColor = System.Drawing.Color.White;
            this.DtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DtStock.EnableHeadersVisualStyles = false;
            this.DtStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DtStock.Location = new System.Drawing.Point(2, 82);
            this.DtStock.Margin = new System.Windows.Forms.Padding(2);
            this.DtStock.MultiSelect = false;
            this.DtStock.Name = "DtStock";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtStock.RowHeadersVisible = false;
            this.DtStock.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DtStock.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DtStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DtStock.RowTemplate.Height = 28;
            this.DtStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtStock.Size = new System.Drawing.Size(393, 533);
            this.DtStock.TabIndex = 100;
            // 
            // InventarioHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 617);
            this.Controls.Add(this.DtStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DatePicker1);
            this.Name = "InventarioHistorico";
            this.Text = "InventarioHistorico";
            this.Load += new System.EventHandler(this.InventarioHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DatePicker1;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView DtStock;
    }
}