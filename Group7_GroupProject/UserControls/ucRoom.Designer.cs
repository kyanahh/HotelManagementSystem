
namespace Group7_GroupProject.UserControls
{
    partial class ucRoom
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
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIN = new System.Windows.Forms.DateTimePicker();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.numGuest = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoomUser = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOut
            // 
            this.dtOut.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtOut.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOut.Location = new System.Drawing.Point(475, 177);
            this.dtOut.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtOut.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(229, 23);
            this.dtOut.TabIndex = 82;
            this.dtOut.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // dtIN
            // 
            this.dtIN.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtIN.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIN.Location = new System.Drawing.Point(475, 123);
            this.dtIN.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtIN.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtIN.Name = "dtIN";
            this.dtIN.Size = new System.Drawing.Size(229, 23);
            this.dtIN.TabIndex = 81;
            this.dtIN.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(187, 160);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(97, 16);
            this.lblGuest.TabIndex = 77;
            this.lblGuest.Text = "No. of Guests:";
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIN.Location = new System.Drawing.Point(472, 105);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(105, 16);
            this.lblIN.TabIndex = 78;
            this.lblIN.Text = "Check-In Date:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(187, 213);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 16);
            this.lblRoom.TabIndex = 76;
            this.lblRoom.Text = "Room No.:";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(472, 160);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(116, 16);
            this.lblOut.TabIndex = 74;
            this.lblOut.Text = "Check-Out Date:";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.PeachPuff;
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(190, 232);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(229, 23);
            this.txtRoom.TabIndex = 79;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Select Room Type",
            "Economy",
            "Standard",
            "Premium",
            "Deluxe",
            "Luxury"});
            this.cmbType.Location = new System.Drawing.Point(190, 125);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(229, 25);
            this.cmbType.TabIndex = 83;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(187, 105);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(83, 16);
            this.lblType.TabIndex = 75;
            this.lblType.Text = "Room Type:";
            // 
            // numGuest
            // 
            this.numGuest.BackColor = System.Drawing.Color.PeachPuff;
            this.numGuest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGuest.Location = new System.Drawing.Point(190, 177);
            this.numGuest.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGuest.Name = "numGuest";
            this.numGuest.Size = new System.Drawing.Size(229, 23);
            this.numGuest.TabIndex = 80;
            this.numGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(190, 77);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(229, 23);
            this.txtID.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Client ID";
            // 
            // btnBook
            // 
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Black;
            this.btnBook.Location = new System.Drawing.Point(741, 177);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(99, 30);
            this.btnBook.TabIndex = 84;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "ROOM";
            // 
            // dgvRoomUser
            // 
            this.dgvRoomUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomUser.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvRoomUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomUser.Location = new System.Drawing.Point(190, 272);
            this.dgvRoomUser.Name = "dgvRoomUser";
            this.dgvRoomUser.Size = new System.Drawing.Size(650, 121);
            this.dgvRoomUser.TabIndex = 88;
            this.dgvRoomUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomUser_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(741, 227);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 30);
            this.btnRefresh.TabIndex = 89;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(472, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 90;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(475, 77);
            this.txtUsername.MaxLength = 11;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(229, 23);
            this.txtUsername.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "Room Fee:";
            // 
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(475, 232);
            this.txtFee.MaxLength = 11;
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(229, 23);
            this.txtFee.TabIndex = 93;
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRoomUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.numGuest);
            this.Controls.Add(this.dtIN);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblOut);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(1008, 427);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIN;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown numGuest;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoomUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFee;
    }
}
