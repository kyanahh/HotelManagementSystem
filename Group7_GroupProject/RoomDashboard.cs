using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group7_GroupProject
{
    public partial class RoomDashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public RoomDashboard()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Login login = new Login();
            login.Show();
            this.Visible = false;
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RoomDashboard_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT * FROM room";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dgvRoom.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            price();

            try
            {
                con.Open();
                string sql = "INSERT INTO room(login_id, roomType, guest, roomNum, checkIn, checkOut, fee) VALUES (" + txtID.Text + ", '" + cmbType.SelectedItem + "', '" + numGuest.Value + "', '" + txtRoom.Text + "', '" + dtIN.Value.Date.ToString("yyyyMMdd") + "', '" + dtOut.Value.Date.ToString("yyyyMMdd") + "', '"+ txtFee.Text +"')";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to book this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record added successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ClearAll()
        {
            txtRoomID.Clear();
            txtID.Clear();
            cmbType.SelectedIndex = 0;
            numGuest.ResetText();
            txtRoom.Clear();
            dtIN.ResetText();
            dtOut.ResetText();
            txtFee.Clear();
        }

        public void price()
        {
            if (cmbType.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a room type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbType.SelectedIndex == 1)
            {
                txtFee.Text = Convert.ToString(200);
            }
            else if (cmbType.SelectedIndex == 2)
            {
                txtFee.Text = Convert.ToString(300);
            }
            else if (cmbType.SelectedIndex == 3)
            {
                txtFee.Text = Convert.ToString(400);
            }
            else if (cmbType.SelectedIndex == 4)
            {
                txtFee.Text = Convert.ToString(800);
            }
            else if (cmbType.SelectedIndex == 5)
            {
                txtFee.Text = Convert.ToString(1000);
            }
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvRoom.Rows[index];
            txtRoomID.Text = row.Cells[0].Value.ToString();
            txtID.Text = row.Cells[1].Value.ToString();
            cmbType.SelectedItem = row.Cells[2].Value.ToString();
            numGuest.Value = Convert.ToInt32(row.Cells[3].Value.ToString());
            txtRoom.Text = row.Cells[4].Value.ToString();
            dtIN.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            dtOut.Value = DateTime.Parse(row.Cells[6].Value.ToString());
            txtFee.Text = row.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            price();

            try
            {
                con.Open();
                string sql = "UPDATE room SET roomType = '" + cmbType.SelectedItem + "', guest = '" + numGuest.Value + "', roomNum = '" + txtRoom.Text + "', checkIn = '" + dtIN.Value.Date.ToString("yyyyMMdd") + "', checkOut = '" + dtOut.Value.Date.ToString("yyyyMMdd") + "', fee = '"+ txtFee.Text +"' WHERE room_id = '" + txtRoomID.Text + "' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to update this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record updated successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM room WHERE room_id = '" + txtRoomID.Text + "' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to permanently remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record updated successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
