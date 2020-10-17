namespace AccessSpeadSheetGoogle
{
    partial class Form1
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
            this.btn_get = new System.Windows.Forms.Button();
            this.lst_data = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(12, 12);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(114, 44);
            this.btn_get.TabIndex = 0;
            this.btn_get.Text = "Read Spread Sheet";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lst_data
            // 
            this.lst_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.lst_data.GridLines = true;
            this.lst_data.Location = new System.Drawing.Point(12, 62);
            this.lst_data.Name = "lst_data";
            this.lst_data.Size = new System.Drawing.Size(619, 337);
            this.lst_data.TabIndex = 1;
            this.lst_data.UseCompatibleStateImageBehavior = false;
            this.lst_data.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa chỉ email";
            this.columnHeader1.Width = 306;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 301;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccessSpeadSheetGoogle.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(570, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessSpeadSheetGoogle.Properties.Resources.google_sheet;
            this.pictureBox1.Location = new System.Drawing.Point(494, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lst_data);
            this.Controls.Add(this.btn_get);
            this.Name = "Form1";
            this.Text = "Access SpeadSheet Google Api - https://laptrinhvb.net";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.ListView lst_data;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

