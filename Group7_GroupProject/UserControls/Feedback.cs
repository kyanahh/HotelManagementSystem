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
    public partial class Feedback : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=hms;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dtr;

        public Feedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO feedback (feedback) VALUES ('" + txtFeedback.Text + "')";
                cmd = new MySqlCommand(sql, con);
                dtr = cmd.ExecuteReader();

                MessageBox.Show("Are you sure you want to rate this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Record added successfulyy", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFeedback.Clear();

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
