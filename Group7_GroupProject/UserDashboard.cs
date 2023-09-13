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
    public partial class UserDashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.')
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

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '&' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            try
            {
                con.Open();
                string sql = "INSERT INTO login(firstname, lastname, bday, sex, phone, email, street, brgy, city, state, zip, username, password) VALUES ('" + txtFirst.Text + "', '" + txtLast.Text + "', '" + dtBday.Value.Date.ToString("yyyyMMdd") + "', '" + gender + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtStreet.Text + "', '" + txtBrgy.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', " + txtZip.Text + ", '" + txtUsername.Text + "', '" + txtPass.Text + "')";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to create this account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record added successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();

                Login login = new Login();
                login.Show();
                this.Visible = false;

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

        public void ClearAll()
        {
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Visible = false;
        }
    }
}
