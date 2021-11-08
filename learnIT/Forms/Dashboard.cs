using learnIT.ClassForms;
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
        int Id;

        public Dashboard(int id)
        {
            InitializeComponent();
            Id = id;

            var User = GetUserProfile.DashboardLogin(id);
            labelDashbordName.Text = $"Welcome Back, {User.Item1}!!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            GetData GetRole = new GetData();

            var User = GetRole.DashboardLogin(Id);
            string role = User.Item4;
            if(role=="Admin")
            {
                AdminClass form = new AdminClass(Id);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                StudentClass form = new StudentClass(Id);
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
