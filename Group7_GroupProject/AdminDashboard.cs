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
    public partial class AdminDashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            try
            {
                con.Open();

                string sql = "SELECT * FROM login";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dgvRecord.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            try
            {
                con.Open();
                string sql = "INSERT INTO login(firstname, lastname, bday, sex, phone, email, street, brgy, city, state, zip, username, password) VALUES ('" + txtFirst.Text +"', '"+ txtLast.Text + "', '" + dtBday.Value.Date.ToString("yyyyMMdd") + "', '" + gender + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtStreet.Text + "', '" + txtBrgy.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', " + txtZip.Text + ", '" + txtUsername.Text + "', '" + txtPass.Text +"')";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to add this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record added successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '&' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtBrgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sex;

            if(rbFemale.Checked == true)
            {
                sex = rbFemale.Text;
            }
            else if(rbMale.Checked)
            {
                sex = rbMale.Text;
            }

            int index = e.RowIndex;
            DataGridViewRow row = dgvRecord.Rows[index];
            txtID.Text = row.Cells[0].Value.ToString();
            txtFirst.Text = row.Cells[1].Value.ToString();
            txtLast.Text = row.Cells[2].Value.ToString();
            dtBday.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            sex = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();
            txtStreet.Text = row.Cells[7].Value.ToString();
            txtBrgy.Text = row.Cells[8].Value.ToString();
            txtCity.Text = row.Cells[9].Value.ToString();
            txtState.Text = row.Cells[10].Value.ToString();
            txtZip.Text = row.Cells[11].Value.ToString();
            txtUsername.Text = row.Cells[12].Value.ToString();
            txtPass.Text = row.Cells[13].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "UPDATE login SET lastname = '"+ txtLast.Text + "', phone = '" + txtPhone.Text + "', email = '" + txtEmail.Text + "', street = '" + txtStreet.Text + "', brgy = '" + txtBrgy.Text + "', city = '" + txtCity.Text + "', state = '" + txtState.Text + "', zip = '" + txtZip.Text + "', username = '" + txtUsername.Text + "', password = '" + txtPass.Text + "' WHERE login_id = "+ txtID.Text +" ";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM login WHERE login_id = '"+ txtID.Text +"' ";
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

        public void ClearAll()
        {
            txtID.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            dtBday.ResetText();
            rbFemale.Checked = false;
            rbMale.Checked = false;
            txtPhone.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtBrgy.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtUsername.Clear();
            txtPass.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                con.Open();

                if (cbSearch.Text == "Client ID")
                {
                    sql = "SELECT * FROM login WHERE login_id = " + txtSearch.Text + " ";
                }
                else if (cbSearch.Text == "Last Name")
                {
                    sql = "SELECT * FROM login WHERE lastname = '" + txtSearch.Text + "'";
                }
                else if (cbSearch.Text == "Phone Number")
                {
                    sql = "SELECT * FROM login WHERE phone = '" + txtSearch.Text + "'";
                }
                else if (cbSearch.Text == "Sex")
                {
                    sql = "SELECT * FROM login WHERE sex = '" + txtSearch.Text + "'";
                }
                else if (cbSearch.Text == "Email")
                {
                    sql = "SELECT * FROM login WHERE email = '" + txtSearch.Text + "'";
                }else if (cbSearch.Text == "City")
                {
                    sql = "SELECT * FROM login WHERE city = '" + txtSearch.Text + "'";
                }else if (cbSearch.Text == "Username")
                {
                    sql = "SELECT * FROM login WHERE username = '" + txtSearch.Text + "'";
                }

                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dgvRecord.DataSource = dt;

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            RoomDashboard room = new RoomDashboard();
            room.Show();
            this.Visible = false;
        }

        private void dtBday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
