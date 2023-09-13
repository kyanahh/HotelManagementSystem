
namespace Group7_GroupProject.UserControls
{
    partial class ucProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblBrgy = new System.Windows.Forms.Label();
            this.txtBrgy = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dtBday = new System.Windows.Forms.DateTimePicker();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(824, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 30);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Location = new System.Drawing.Point(642, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 136);
            this.panel2.TabIndex = 74;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(20, 64);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(72, 16);
            this.lblPass.TabIndex = 61;
            this.lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(23, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(229, 23);
            this.txtPass.TabIndex = 14;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(23, 32);
            this.txtUsername.MaxLength = 11;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(229, 23);
            this.txtUsername.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.txtStreet);
            this.panel3.Controls.Add(this.lblStreet);
            this.panel3.Controls.Add(this.lblBrgy);
            this.panel3.Controls.Add(this.txtBrgy);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.lblCity);
            this.panel3.Controls.Add(this.txtZip);
            this.panel3.Controls.Add(this.lblZip);
            this.panel3.Controls.Add(this.txtState);
            this.panel3.Controls.Add(this.lblState);
            this.panel3.Location = new System.Drawing.Point(342, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 346);
            this.panel3.TabIndex = 73;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(25, 32);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.PeachPuff;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(25, 83);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(229, 23);
            this.txtStreet.TabIndex = 8;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(22, 64);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(174, 16);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "Street / House No. / Subd:";
            // 
            // lblBrgy
            // 
            this.lblBrgy.AutoSize = true;
            this.lblBrgy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrgy.Location = new System.Drawing.Point(22, 119);
            this.lblBrgy.Name = "lblBrgy";
            this.lblBrgy.Size = new System.Drawing.Size(77, 16);
            this.lblBrgy.TabIndex = 9;
            this.lblBrgy.Text = "Barangay:";
            // 
            // txtBrgy
            // 
            this.txtBrgy.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBrgy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrgy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrgy.Location = new System.Drawing.Point(25, 139);
            this.txtBrgy.MaxLength = 50;
            this.txtBrgy.Name = "txtBrgy";
            this.txtBrgy.Size = new System.Drawing.Size(229, 23);
            this.txtBrgy.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(25, 191);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(229, 23);
            this.txtCity.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(22, 172);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City:";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.PeachPuff;
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(25, 299);
            this.txtZip.MaxLength = 50;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(229, 23);
            this.txtZip.TabIndex = 12;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(22, 279);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(71, 16);
            this.lblZip.TabIndex = 19;
            this.lblZip.Text = "Zip Code:";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.PeachPuff;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(25, 245);
            this.txtState.MaxLength = 50;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(229, 23);
            this.txtState.TabIndex = 11;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(22, 226);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 16);
            this.lblState.TabIndex = 17;
            this.lblState.Text = " State:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 25);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "MY PROFILE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.dtBday);
            this.panel1.Controls.Add(this.lblFirst);
            this.panel1.Controls.Add(this.lblLast);
            this.panel1.Controls.Add(this.lblBday);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Location = new System.Drawing.Point(43, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 346);
            this.panel1.TabIndex = 72;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(154, 248);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(64, 248);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(21, 32);
            this.txtID.MaxLength = 11;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(229, 23);
            this.txtID.TabIndex = 23;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(18, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Client ID:";
            // 
            // dtBday
            // 
            this.dtBday.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtBday.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtBday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBday.Location = new System.Drawing.Point(22, 191);
            this.dtBday.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtBday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtBday.Name = "dtBday";
            this.dtBday.Size = new System.Drawing.Size(231, 23);
            this.dtBday.TabIndex = 3;
            this.dtBday.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(18, 64);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(80, 16);
            this.lblFirst.TabIndex = 6;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(20, 119);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(80, 16);
            this.lblLast.TabIndex = 7;
            this.lblLast.Text = "Last Name:";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.Location = new System.Drawing.Point(18, 172);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(67, 16);
            this.lblBday.TabIndex = 8;
            this.lblBday.Text = "Birthday:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(18, 226);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 16);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Sex:";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(21, 83);
            this.txtFirst.MaxLength = 50;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(231, 23);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.PeachPuff;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(21, 139);
            this.txtLast.MaxLength = 50;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(231, 23);
            this.txtLast.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(18, 279);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 16);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(21, 299);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(229, 23);
            this.txtPhone.TabIndex = 6;
            // 
            // ucProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "ucProfile";
            this.Size = new System.Drawing.Size(1002, 417);
            this.Load += new System.EventHandler(this.ucProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblBrgy;
        private System.Windows.Forms.TextBox txtBrgy;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtBday;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
    }
}
