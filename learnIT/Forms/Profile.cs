using learnIT.ChatForms;
using learnIT.ClassForms;
using learnIT.Controller;
using learnIT.TasksForms;
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
    public partial class Profile : Form
    {
        GetData GetUserProfile = new GetData();
        int Id;
        public Profile(int id)
        {
            InitializeComponent();
            Id = id;

            var User = GetUserProfile.DashboardLogin(id);
            //item1 = first name
            //item2 = last name
            //item3 = email
            //item4 = user role

            var UserProfile = GetUserProfile.GetProfile(id);
            //item1 = year level
            //item2 = birthday
            //item3 = gender
            //item4 = phone
            
            var Address = GetUserProfile.GetAddress(id);
            //item1 = street
            //item2 = town
            //item3 = province
            //item4 = zip_code


            labelUserName.Text = $"{User.Item1}, {User.Item2}";


            //Top Descriptions
            labelMainName.Text = $"{User.Item1} {User.Item2}";
            labelYearRole.Text = $"{UserProfile.Item1} - {User.Item4}";
            labelId.Text = $"UserID: {id}";

            //Panel Information
            labelInfo.Text = $"{User.Item4}'s Information";

            labelFullNameText.Text = $"{User.Item1} {User.Item2}";
            labelAddressText.Text = $"{Address.Item1}, {Address.Item2}, {Address.Item3} {Address.Item4}";
            labelYearLevelText.Text = $"{UserProfile.Item1}";
            labelBirthdayText.Text = $"{UserProfile.Item2}";
            labelGenderText.Text = $"{UserProfile.Item3}";
            labelPhoneText.Text = $"0{UserProfile.Item4}";
            labelEmailText.Text = $"{User.Item3}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile form = new EditProfile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            GetData GetRole = new GetData();

            var User = GetRole.DashboardLogin(Id);
            string role = User.Item4;
            if (role == "Admin")
            {
                AdminClasses form = new AdminClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                StudentClasses form = new StudentClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {

            TaskForm form = new TaskForm(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            Chatbox form = new Chatbox(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}
