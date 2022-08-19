using Core.Interface;
using Core.Services;
using Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JirehBankUI
{
    public partial class Registration : Form
    {
        private readonly ICustomerServices _customerServices;
        private readonly IValidate _validate;
        private readonly IAuthentification _authentification;
        private readonly IServiceProvider _serviceProvider;
        public Registration(ICustomerServices customerServices, IValidate validate, IAuthentification authentification, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerServices = customerServices;
            _validate = validate;
            _authentification = authentification;
            _serviceProvider = serviceProvider;
        }

        private void lblEmailReg_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLNameReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPasswordReg_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneReg_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginBtn_Click(object sender, EventArgs e)
        {
            string FirstName = txtFNameReg.Text;
            string LastName = txtLNameReg.Text;
            string Email = txtEmailReg.Text;
            string Password = txtPasswordReg.Text;
            string Phone = txtPhoneReg.Text;

            if (!_validate.NameChecker(txtFNameReg.Text) || !_validate.NameChecker(txtLNameReg.Text))
            {
                MessageBox.Show("Enter a valid Name strating with capital letter");
            }
            if (!_validate.EmailChecker(Email))
            {
                MessageBox.Show("Enter a valid name");
            }
            if (!_validate.PasswordChecker(Password))
            {
                MessageBox.Show("Password must contain Captital, special character and six character minimum");
            }
            if (!_validate.PhoneChecker(Phone))
            {
                MessageBox.Show("Enter a valid phone number");
            }

            if (_validate.NameChecker(txtLNameReg.Text)
                && _validate.NameChecker(txtFNameReg.Text)
                && _validate.EmailChecker(Email)
                && _validate.PasswordChecker(Password)
                && _validate.PhoneChecker(Phone))
            {
                _customerServices.RegisterUser(FirstName, LastName, Email, Password, Phone);
                MessageBox.Show("Regisration successful");
                this.Hide();
                DashBoardN dashBoardN = _serviceProvider.GetRequiredService<DashBoardN>();
                dashBoardN.Show();
            }
        }

        private void btnBackReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = _serviceProvider.GetRequiredService<Welcome>();
            welcome.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
