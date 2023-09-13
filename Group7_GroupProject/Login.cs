using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group7_GroupProject.UserControls;
using MySql.Data.MySqlClient;

namespace Group7_GroupProject
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();  
        MySqlDataReader dtr;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM login where username = '" + txtUsername.Text + "' AND password = '" + txtPass.Text + "'";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (txtUsername.Text == "admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        UserProfile userProf = new UserProfile(txtUsername.Text);
                        userProf.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    lblWrong.Text = "The username or password you entered is incorrect";
                }
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

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin to reset password", "Forgot Password", MessageBoxButtons.OK);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserDashboard user = new UserDashboard();
            user.Show();
            this.Visible = false;
        }
    }
}
