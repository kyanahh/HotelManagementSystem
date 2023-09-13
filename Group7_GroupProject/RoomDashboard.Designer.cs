
namespace Group7_GroupProject
{
    partial class RoomDashboard
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numGuest = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblGuest = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIN = new System.Windows.Forms.DateTimePicker();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(31, 89);
            this.txtID.MaxLength = 11;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 23);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "Client ID";
            // 
            // numGuest
            // 
            this.numGuest.BackColor = System.Drawing.Color.PeachPuff;
            this.numGuest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGuest.Location = new System.Drawing.Point(31, 189);
            this.numGuest.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGuest.Name = "numGuest";
            this.numGuest.Size = new System.Drawing.Size(229, 23);
            this.numGuest.TabIndex = 3;
            this.numGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(28, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(83, 16);
            this.lblType.TabIndex = 88;
            this.lblType.Text = "Room Type:";
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
            this.cmbType.Location = new System.Drawing.Point(31, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(229, 25);
            this.cmbType.TabIndex = 2;
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(28, 172);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(97, 16);
            this.lblGuest.TabIndex = 90;
            this.lblGuest.Text = "No. of Guests:";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(12, 283);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.Size = new System.Drawing.Size(776, 202);
            this.dgvRoom.TabIndex = 71;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            // 
            // dtOut
            // 
            this.dtOut.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtOut.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOut.Location = new System.Drawing.Point(316, 191);
            this.dtOut.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtOut.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(229, 23);
            this.dtOut.TabIndex = 6;
            this.dtOut.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // dtIN
            // 
            this.dtIN.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.dtIN.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.dtIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIN.Location = new System.Drawing.Point(316, 137);
            this.dtIN.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtIN.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtIN.Name = "dtIN";
            this.dtIN.Size = new System.Drawing.Size(229, 23);
            this.dtIN.TabIndex = 5;
            this.dtIN.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIN.Location = new System.Drawing.Point(313, 117);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(105, 16);
            this.lblIN.TabIndex = 91;
            this.lblIN.Text = "Check-In Date:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(313, 70);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 16);
            this.lblRoom.TabIndex = 89;
            this.lblRoom.Text = "Room No.:";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(313, 172);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(116, 16);
            this.lblOut.TabIndex = 87;
            this.lblOut.Text = "Check-Out Date:";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.PeachPuff;
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(316, 89);
            this.txtRoom.MaxLength = 11;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(229, 23);
            this.txtRoom.TabIndex = 4;
            this.txtRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoom_KeyPress);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(721, 53);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 27);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(97, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(588, 235);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(339, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(217, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(463, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(721, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 27);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(31, 40);
            this.txtRoomID.MaxLength = 11;
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(229, 23);
            this.txtRoomID.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Room ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Room Fee:";
            // 
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(314, 39);
            this.txtFee.MaxLength = 11;
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(229, 23);
            this.txtFee.TabIndex = 101;
            // 
            // RoomDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGuest);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.dtIN);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.dgvRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RoomDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.Load += new System.EventHandler(this.RoomDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGuest;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIN;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFee;
    }
}