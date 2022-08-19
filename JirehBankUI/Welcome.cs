using Core.Interface;
using Core.Services;
using Domain.Models;
using Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace JirehBankUI
{
    public partial class Welcome : Form
    {
        private readonly IValidate _validate;
        private readonly IAuthentification _authentification;
        private readonly IServiceProvider _serviceProvider;
        public Welcome(IServiceProvider serviceProvider, IValidate validate, IAuthentification authentification)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _authentification = authentification;
            _validate = validate;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (!_validate.EmailChecker(email))
            {
                MessageBox.Show("Enter a correct email format");
            }
            if (!_validate.PasswordChecker(password))
            {
                MessageBox.Show("Enter a correct password");
            }

            if (_validate.PasswordChecker(password) && _validate.EmailChecker(email))
            {
                var result = _authentification.CustomerLogin(email, password);
                if (result)
                {
                    this.Hide();
                    DashBoardN dashBoardN = _serviceProvider.GetRequiredService<DashBoardN>();
                    dashBoardN.Show();
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = _serviceProvider.GetRequiredService<Registration>();
            registration.Show();
        }
    }
}