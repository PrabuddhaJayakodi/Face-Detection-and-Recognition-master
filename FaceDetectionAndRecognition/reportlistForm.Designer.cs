namespace FaceDetectionAndRecognition
{
    partial class reportlistForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportlist_gridview = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn_find = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportlist_gridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportlist_gridview
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.reportlist_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.reportlist_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportlist_gridview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportlist_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.reportlist_gridview.ColumnHeadersHeight = 45;
            this.reportlist_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportlist_gridview.DefaultCellStyle = dataGridViewCellStyle11;
            this.reportlist_gridview.EnableHeadersVisualStyles = false;
            this.reportlist_gridview.GridColor = System.Drawing.Color.DarkGreen;
            this.reportlist_gridview.Location = new System.Drawing.Point(12, 79);
            this.reportlist_gridview.Name = "reportlist_gridview";
            this.reportlist_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reportlist_gridview.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportlist_gridview.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.reportlist_gridview.RowTemplate.Height = 24;
            this.reportlist_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportlist_gridview.Size = new System.Drawing.Size(1225, 574);
            this.reportlist_gridview.TabIndex = 0;
            this.reportlist_gridview.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.reportlist_gridview_RowPostPaint);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(363, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 40);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Navy;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(527, 23);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(137, 40);
            this.btn_find.TabIndex = 18;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_find);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Location = new System.Drawing.Point(12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 84);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "    COMPLAINT MANAGER";
            // 
            // no
            // 
            this.no.HeaderText = "Case number";
            this.no.MinimumWidth = 15;
            this.no.Name = "no";
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // reportlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportlist_gridview);
            this.Name = "reportlistForm";
            this.Text = "reportlistForm";
            this.Load += new System.EventHandler(this.reportlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportlist_gridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportlist_gridview;
        private System.Windows.Forms.Button btn_refresh;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
    }
}