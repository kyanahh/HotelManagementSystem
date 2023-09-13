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
    public partial class ucProfile : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public ucProfile(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "UPDATE login SET lastname = '" + txtLast.Text + "', phone = '" + txtPhone.Text + "', email = '" + txtEmail.Text + "', street = '" + txtStreet.Text + "', brgy = '" + txtBrgy.Text + "', city = '" + txtCity.Text + "', state = '" + txtState.Text + "', zip = '" + txtZip.Text + "', username = '" + txtUsername.Text + "', password = '" + txtPass.Text + "' WHERE login_id = " + txtID.Text + " ";
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

        private void ucProfile_Load(object sender, EventArgs e)
        {
            string gender = "";
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

                string sql = "SELECT * FROM login WHERE username = '"+ txtUsername.Text +"' ";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    txtID.Text = dtr.GetValue(0).ToString();
                    txtFirst.Text = dtr.GetValue(1).ToString();
                    txtLast.Text = dtr.GetValue(2).ToString();
                    dtBday.Value = DateTime.Parse(dtr.GetValue(3).ToString());
                    gender = dtr.GetValue(4).ToString();
                    txtPhone.Text = dtr.GetValue(5).ToString();
                    txtEmail.Text = dtr.GetValue(6).ToString();
                    txtStreet.Text = dtr.GetValue(7).ToString();
                    txtBrgy.Text = dtr.GetValue(8).ToString();
                    txtCity.Text = dtr.GetValue(9).ToString();
                    txtState.Text = dtr.GetValue(10).ToString();
                    txtZip.Text = dtr.GetValue(11).ToString();
                    txtUsername.Text = dtr.GetValue(12).ToString();
                    txtPass.Text = dtr.GetValue(13).ToString();
                }
            }catch(Exception ex)
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
