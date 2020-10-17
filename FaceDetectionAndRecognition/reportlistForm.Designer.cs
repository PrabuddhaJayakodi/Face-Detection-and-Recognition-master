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
            this.reportlist_gridview = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_contact = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_retrive = new System.Windows.Forms.Button();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_latitude = new System.Windows.Forms.TextBox();
            this.txtbox_complainID = new System.Windows.Forms.TextBox();
            this.txtbox_longitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_getlocation = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportlist_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // reportlist_gridview
            // 
            this.reportlist_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportlist_gridview.Location = new System.Drawing.Point(83, 110);
            this.reportlist_gridview.Name = "reportlist_gridview";
            this.reportlist_gridview.RowHeadersWidth = 51;
            this.reportlist_gridview.RowTemplate.Height = 24;
            this.reportlist_gridview.Size = new System.Drawing.Size(1105, 160);
            this.reportlist_gridview.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(177, 45);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(178, 43);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(392, 383);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(231, 22);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_contact
            // 
            this.txtbox_contact.Location = new System.Drawing.Point(392, 496);
            this.txtbox_contact.Name = "txtbox_contact";
            this.txtbox_contact.Size = new System.Drawing.Size(231, 22);
            this.txtbox_contact.TabIndex = 3;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Location = new System.Drawing.Point(392, 438);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(231, 22);
            this.txtbox_address.TabIndex = 4;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "contact";
            // 
            // btn_retrive
            // 
            this.btn_retrive.Location = new System.Drawing.Point(405, 558);
            this.btn_retrive.Name = "btn_retrive";
            this.btn_retrive.Size = new System.Drawing.Size(75, 23);
            this.btn_retrive.TabIndex = 8;
            this.btn_retrive.Text = "retrive";
            this.btn_retrive.UseVisualStyleBackColor = true;
            this.btn_retrive.Click += new System.EventHandler(this.btn_retrive_Click);
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(392, 331);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(231, 22);
            this.txtbox_id.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "id";
            // 
            // txtbox_latitude
            // 
            this.txtbox_latitude.Location = new System.Drawing.Point(908, 383);
            this.txtbox_latitude.Name = "txtbox_latitude";
            this.txtbox_latitude.Size = new System.Drawing.Size(231, 22);
            this.txtbox_latitude.TabIndex = 11;
            // 
            // txtbox_complainID
            // 
            this.txtbox_complainID.Location = new System.Drawing.Point(722, 334);
            this.txtbox_complainID.Name = "txtbox_complainID";
            this.txtbox_complainID.Size = new System.Drawing.Size(231, 22);
            this.txtbox_complainID.TabIndex = 12;
            // 
            // txtbox_longitude
            // 
            this.txtbox_longitude.Location = new System.Drawing.Point(908, 427);
            this.txtbox_longitude.Name = "txtbox_longitude";
            this.txtbox_longitude.Size = new System.Drawing.Size(231, 22);
            this.txtbox_longitude.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "latitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "longitude";
            // 
            // btn_getlocation
            // 
            this.btn_getlocation.Location = new System.Drawing.Point(1022, 324);
            this.btn_getlocation.Name = "btn_getlocation";
            this.btn_getlocation.Size = new System.Drawing.Size(117, 43);
            this.btn_getlocation.TabIndex = 17;
            this.btn_getlocation.Text = "get location";
            this.btn_getlocation.UseVisualStyleBackColor = true;
            this.btn_getlocation.Click += new System.EventHandler(this.btn_getlocation_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(995, 570);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(193, 43);
            this.btn_find.TabIndex = 18;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // reportlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_getlocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_longitude);
            this.Controls.Add(this.txtbox_complainID);
            this.Controls.Add(this.txtbox_latitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.btn_retrive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_contact);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.reportlist_gridview);
            this.Name = "reportlistForm";
            this.Text = "reportlistForm";
            this.Load += new System.EventHandler(this.reportlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportlist_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportlist_gridview;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_contact;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_retrive;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_latitude;
        private System.Windows.Forms.TextBox txtbox_complainID;
        private System.Windows.Forms.TextBox txtbox_longitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_getlocation;
        private System.Windows.Forms.Button btn_find;
    }
}