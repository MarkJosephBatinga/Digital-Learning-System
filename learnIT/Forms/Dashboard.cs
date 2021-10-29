using learnIT.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.Forms
{
    public partial class Dashboard : Form
    {
        GetData GetUserProfile = new GetData();

        public Dashboard(int id)
        {
            InitializeComponent();
            var User = GetUserProfile.DashboardLogin(id);
            labelDashbordName.Text = $"Welcome Back, {User.Item1}!!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
