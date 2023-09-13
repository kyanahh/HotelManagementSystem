using Group7_GroupProject.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_GroupProject
{
    public partial class UserProfile : Form
    {
        public UserProfile(string username)
        {
            InitializeComponent();
            lblName.Text = username;
        }

        private void AddUserControl(UserControl uc)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

        private void lblRoom_Click_1(object sender, EventArgs e)
        {
            ucRoom ucR = new ucRoom(lblName.Text);
            AddUserControl(ucR);
        }

        private void lblProfile_Click_1(object sender, EventArgs e)
        {
            ucProfile ucP = new ucProfile(lblName.Text);
            AddUserControl(ucP);
        }

        private void lblRate_Click(object sender, EventArgs e)
        {
            Feedback rate = new Feedback();
            AddUserControl(rate);
        }
    }
}
