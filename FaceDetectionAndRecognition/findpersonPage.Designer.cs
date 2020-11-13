namespace FaceDetectionAndRecognition
{
    partial class findpersonPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findpersonPage));
            this.dataGridView_details = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_details
            // 
            this.dataGridView_details.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_details.ColumnHeadersHeight = 50;
            this.dataGridView_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno});
            this.dataGridView_details.Location = new System.Drawing.Point(46, 103);
            this.dataGridView_details.Name = "dataGridView_details";
            this.dataGridView_details.RowHeadersWidth = 51;
            this.dataGridView_details.RowTemplate.Height = 24;
            this.dataGridView_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_details.Size = new System.Drawing.Size(1179, 434);
            this.dataGridView_details.TabIndex = 0;
            // 
            // btn_display
            // 
            this.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display.Location = new System.Drawing.Point(46, 21);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(104, 34);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "DISPLAY";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1123, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(170, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 34);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(815, 33);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(281, 22);
            this.txtbox_search.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(777, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(792, 567);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 22);
            this.textBox2.TabIndex = 6;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(792, 636);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(281, 22);
            this.txtbox_email.TabIndex = 7;
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(1112, 630);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(113, 35);
            this.btn_email.TabIndex = 8;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1112, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Message";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Sno";
            this.Sno.MinimumWidth = 6;
            this.Sno.Name = "Sno";
            this.Sno.Width = 125;
            // 
            // findpersonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.dataGridView_details);
            this.Name = "findpersonPage";
            this.Text = "findpersonPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_details;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
    }
}