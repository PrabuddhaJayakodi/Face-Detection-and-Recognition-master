namespace FaceDetectionAndRecognition
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_surname = new System.Windows.Forms.TextBox();
            this.txtbox_fulname = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.txtbox_phone1 = new System.Windows.Forms.TextBox();
            this.txtbox_phone2 = new System.Windows.Forms.TextBox();
            this.txtbox_vehocleno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_bday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_gender = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbox_nic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.BackColor = System.Drawing.Color.Transparent;
            this.cameraBox.Location = new System.Drawing.Point(12, 12);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(640, 480);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(704, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(167, 52);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start Detection and Recognition";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(1052, 609);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 41);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Face";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(848, 104);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(379, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(723, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // btn_find1
            // 
            this.btn_find1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_find1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find1.ForeColor = System.Drawing.Color.White;
            this.btn_find1.Location = new System.Drawing.Point(848, 609);
            this.btn_find1.Name = "btn_find1";
            this.btn_find1.Size = new System.Drawing.Size(133, 41);
            this.btn_find1.TabIndex = 8;
            this.btn_find1.Text = "Find";
            this.btn_find1.UseVisualStyleBackColor = false;
            this.btn_find1.Click += new System.EventHandler(this.btn_find1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(723, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(723, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "fulname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(723, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(723, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "phone no.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(723, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "phone no.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(723, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "vehicle no.";
            // 
            // txtbox_surname
            // 
            this.txtbox_surname.Location = new System.Drawing.Point(848, 141);
            this.txtbox_surname.Multiline = true;
            this.txtbox_surname.Name = "txtbox_surname";
            this.txtbox_surname.Size = new System.Drawing.Size(379, 22);
            this.txtbox_surname.TabIndex = 15;
            // 
            // txtbox_fulname
            // 
            this.txtbox_fulname.Location = new System.Drawing.Point(848, 183);
            this.txtbox_fulname.Multiline = true;
            this.txtbox_fulname.Name = "txtbox_fulname";
            this.txtbox_fulname.Size = new System.Drawing.Size(379, 22);
            this.txtbox_fulname.TabIndex = 17;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Location = new System.Drawing.Point(848, 222);
            this.txtbox_address.Multiline = true;
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(379, 45);
            this.txtbox_address.TabIndex = 18;
            // 
            // txtbox_phone1
            // 
            this.txtbox_phone1.Location = new System.Drawing.Point(848, 325);
            this.txtbox_phone1.Name = "txtbox_phone1";
            this.txtbox_phone1.Size = new System.Drawing.Size(379, 22);
            this.txtbox_phone1.TabIndex = 19;
            // 
            // txtbox_phone2
            // 
            this.txtbox_phone2.Location = new System.Drawing.Point(848, 366);
            this.txtbox_phone2.Name = "txtbox_phone2";
            this.txtbox_phone2.Size = new System.Drawing.Size(379, 22);
            this.txtbox_phone2.TabIndex = 20;
            // 
            // txtbox_vehocleno
            // 
            this.txtbox_vehocleno.Location = new System.Drawing.Point(848, 446);
            this.txtbox_vehocleno.Name = "txtbox_vehocleno";
            this.txtbox_vehocleno.Size = new System.Drawing.Size(379, 22);
            this.txtbox_vehocleno.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(723, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "birthday";
            // 
            // txtbox_bday
            // 
            this.txtbox_bday.Location = new System.Drawing.Point(848, 493);
            this.txtbox_bday.Name = "txtbox_bday";
            this.txtbox_bday.Size = new System.Drawing.Size(379, 22);
            this.txtbox_bday.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.Location = new System.Drawing.Point(723, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "email";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(848, 406);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(379, 22);
            this.txtbox_email.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(723, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Gender";
            // 
            // txtbox_gender
            // 
            this.txtbox_gender.Location = new System.Drawing.Point(848, 287);
            this.txtbox_gender.Name = "txtbox_gender";
            this.txtbox_gender.Size = new System.Drawing.Size(379, 22);
            this.txtbox_gender.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label11.Location = new System.Drawing.Point(723, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nic";
            // 
            // txtbox_nic
            // 
            this.txtbox_nic.Location = new System.Drawing.Point(848, 534);
            this.txtbox_nic.Name = "txtbox_nic";
            this.txtbox_nic.Size = new System.Drawing.Size(379, 22);
            this.txtbox_nic.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.txtbox_nic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbox_gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_bday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_vehocleno);
            this.Controls.Add(this.txtbox_phone2);
            this.Controls.Add(this.txtbox_phone1);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_fulname);
            this.Controls.Add(this.txtbox_surname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = "/";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_surname;
        private System.Windows.Forms.TextBox txtbox_fulname;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.TextBox txtbox_phone1;
        private System.Windows.Forms.TextBox txtbox_phone2;
        private System.Windows.Forms.TextBox txtbox_vehocleno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_bday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbox_nic;
    }
}

