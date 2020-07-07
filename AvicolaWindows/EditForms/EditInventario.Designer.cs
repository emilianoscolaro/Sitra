namespace AvicolaWindows.EditForms
{
    partial class EditInventario
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
            this.button2 = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.NameEdit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionEntry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(461, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 54);
            this.button2.TabIndex = 78;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(179, 39);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(229, 31);
            this.TitleLabel.TabIndex = 77;
            this.TitleLabel.Text = "Editar Inventario";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(166, 130);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(212, 1);
            this.pictureBox8.TabIndex = 76;
            this.pictureBox8.TabStop = false;
            // 
            // NameEdit
            // 
            this.NameEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameEdit.BackgroundImage = global::AvicolaWindows.Properties.Resources.edit_4218;
            this.NameEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NameEdit.Location = new System.Drawing.Point(405, 101);
            this.NameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(23, 25);
            this.NameEdit.TabIndex = 75;
            this.NameEdit.TabStop = false;
            this.NameEdit.Click += new System.EventHandler(this.NameEdit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Descripcion";
            // 
            // DescripcionEntry
            // 
            this.DescripcionEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripcionEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DescripcionEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescripcionEntry.Enabled = false;
            this.DescripcionEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionEntry.ForeColor = System.Drawing.Color.White;
            this.DescripcionEntry.Location = new System.Drawing.Point(166, 111);
            this.DescripcionEntry.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionEntry.Name = "DescripcionEntry";
            this.DescripcionEntry.Size = new System.Drawing.Size(212, 16);
            this.DescripcionEntry.TabIndex = 74;
            // 
            // EditInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(589, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionEntry);
            this.Name = "EditInventario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditInventario";
            this.Load += new System.EventHandler(this.EditInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox NameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionEntry;
    }
}