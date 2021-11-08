using learnIT.Controller;
using learnIT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.ClassForms
{
    public partial class AdminClass : Form
    {
        int Id;
        GetData GetUser = new GetData();

        public AdminClass(int id)
        {
            InitializeComponent();
            Id = id;
            var User = GetUser.DashboardLogin(id);
        }

        private void buttonProfile_Click_1(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
            CreateClass form = new CreateClass(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}
