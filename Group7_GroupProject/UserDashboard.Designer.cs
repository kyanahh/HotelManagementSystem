
namespace Group7_GroupProject
{
    partial class UserDashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtBday = new System.Windows.Forms.DateTimePicker();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtBrgy = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBrgy = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group7_GroupProject.Properties.Resources.png_transparent_facility_management_rr_residency_hotel_management_system_hotel_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(79, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // dtBday
            // 
            this.dtBday.CalendarTitleBackColor = System.Drawing.Color.DarkBlue;
            this.dtBday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBday.Location = new System.Drawing.Point(21, 154);
            this.dtBday.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtBday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtBday.Name = "dtBday";
            this.dtBday.Size = new System.Drawing.Size(231, 23);
            this.dtBday.TabIndex = 3;
            this.dtBday.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.PeachPuff;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(25, 202);
            this.txtState.MaxLength = 50;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(220, 23);
            this.txtState.TabIndex = 13;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(25, 147);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 23);
            this.txtCity.TabIndex = 12;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.PeachPuff;
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(25, 261);
            this.txtZip.MaxLength = 20;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(220, 23);
            this.txtZip.TabIndex = 14;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // txtBrgy
            // 
            this.txtBrgy.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBrgy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrgy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrgy.Location = new System.Drawing.Point(25, 93);
            this.txtBrgy.MaxLength = 50;
            this.txtBrgy.Name = "txtBrgy";
            this.txtBrgy.Size = new System.Drawing.Size(220, 23);
            this.txtBrgy.TabIndex = 11;
            this.txtBrgy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrgy_KeyPress);
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.PeachPuff;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(25, 37);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(220, 23);
            this.txtStreet.TabIndex = 10;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(21, 378);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 23);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(21, 318);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(21, 263);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(231, 23);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.PeachPuff;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(21, 93);
            this.txtLast.MaxLength = 50;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(231, 23);
            this.txtLast.TabIndex = 2;
            this.txtLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLast_KeyPress);
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(21, 37);
            this.txtFirst.MaxLength = 50;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(231, 23);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(22, 243);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(71, 16);
            this.lblZip.TabIndex = 78;
            this.lblZip.Text = "Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(22, 185);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 16);
            this.lblState.TabIndex = 76;
            this.lblState.Text = " State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(22, 128);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 75;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(22, 18);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(174, 16);
            this.lblStreet.TabIndex = 73;
            this.lblStreet.Text = "Street / House No. / Subd:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 72;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(18, 359);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 71;
            this.lblUsername.Text = "Username:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(18, 244);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 16);
            this.lblPhone.TabIndex = 70;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(18, 190);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 16);
            this.lblSex.TabIndex = 69;
            this.lblSex.Text = "Sex:";
            // 
            // lblBrgy
            // 
            this.lblBrgy.AutoSize = true;
            this.lblBrgy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrgy.Location = new System.Drawing.Point(22, 74);
            this.lblBrgy.Name = "lblBrgy";
            this.lblBrgy.Size = new System.Drawing.Size(77, 16);
            this.lblBrgy.TabIndex = 68;
            this.lblBrgy.Text = "Barangay:";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.Location = new System.Drawing.Point(18, 134);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(67, 16);
            this.lblBday.TabIndex = 67;
            this.lblBday.Text = "Birthday:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(18, 74);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(80, 16);
            this.lblLast.TabIndex = 66;
            this.lblLast.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 33);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hotel Management System ";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(18, 18);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(80, 16);
            this.lblFirst.TabIndex = 65;
            this.lblFirst.Text = "First Name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.lblFirst);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.lblLast);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.dtBday);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.lblBday);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 484);
            this.panel1.TabIndex = 104;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(18, 415);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(72, 16);
            this.lblPass.TabIndex = 100;
            this.lblPass.Text = "Password:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(153, 211);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(21, 434);
            this.txtPass.MaxLength = 25;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 23);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(63, 211);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtZip);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.lblZip);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblStreet);
            this.panel2.Controls.Add(this.txtBrgy);
            this.panel2.Controls.Add(this.txtStreet);
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.lblBrgy);
            this.panel2.Location = new System.Drawing.Point(312, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 318);
            this.panel2.TabIndex = 105;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(338, 423);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 30);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(459, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(515, 542);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 30);
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(611, 592);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtBday;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtBrgy;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBrgy;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}