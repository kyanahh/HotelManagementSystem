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

namespace Group7_GroupProject.UserControls
{

    
    public partial class ucRoom : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public ucRoom(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
             price();

            try
            {
                con.Open();
                string sql = "INSERT INTO room(login_id, roomType, guest, roomNum, checkIn, checkOut, fee) VALUES ('" + txtID.Text + "', '" + cmbType.SelectedItem + "', '" + numGuest.Value + "', '" + txtRoom.Text + "', '" + dtIN.Value.Date.ToString("yyyyMMdd") + "', '" + dtOut.Value.Date.ToString("yyyyMMdd") + "', '"+ txtFee.Text +"')";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to add this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void ClearAll()
        {
            cmbType.SelectedIndex = 0;
            numGuest.ResetText();
            txtRoom.Clear();
            dtIN.ResetText();
            dtOut.ResetText();
            txtFee.Clear();
        }

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT room.room_id, login.login_id, login.username, room.roomType, room.guest, room.roomNum, room.checkIN, room.checkOut, room.fee from login INNER JOIN room on login.login_id = room.login_id WHERE username = '"+ txtUsername.Text +"' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dgvRoomUser.DataSource = dt;

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

        private void ucRoom_Load(object sender, EventArgs e)
        {
            price();

            try
            {
                con.Open();

                string sql = "SELECT * FROM login WHERE username = '" + txtUsername.Text + "' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    txtID.Text = dtr.GetValue(0).ToString();
                    txtUsername.Text = dtr.GetValue(12).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvRoomUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
