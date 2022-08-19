using Core.Interface;
using Core.Services;
using DataAccess.DataStore;
using Domain.Models;
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
    public partial class DashBoardN : Form
    {
        private readonly IAccountServices _accountServices;
        private readonly IServiceProvider _serviceProvider;
        public DashBoardN(IServiceProvider serviceProvider, IAccountServices accountServices)
        {
            InitializeComponent();
            _accountServices = accountServices;
            _serviceProvider = serviceProvider;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome welcome = _serviceProvider.GetRequiredService<Welcome>();
            welcome.Show();
            this.Hide();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInitialDeposit.Text, out double initDeposit) && initDeposit >= 1000)
            {
                if (rdbtnSavings.Checked)
                {
                    _accountServices.CreateAccount(initDeposit, 1, Data.currentUser);
                    MessageBox.Show("Account creation successful");
                }

                if (RdBtnCurrent.Checked)
                {
                    _accountServices.CreateAccount(initDeposit, 2, Data.currentUser);
                    MessageBox.Show("Account creation successful");
                }

                this.Close();
                var dash = _serviceProvider.GetRequiredService<DashBoardN>();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Enter a valid amount");
            }
        }

        private void rdbtnSavings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdBtnCurrent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabCreateAcc_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Account account1 = new Account();
            foreach (var acc in Data.Accounts)
            {
                if (cmbSender.Text == acc.AccountNumber)
                {
                    account1 = acc;
                }
            }

            Account account2 = new Account();
            foreach (var acc in Data.Accounts)
            {
                if (txtRecieversAcc.Text == acc.AccountNumber)
                {
                    account2 = acc;
                }
            }

            bool checkTrans = double.TryParse(txtTransferCash.Text, out double amount);
            if (checkTrans && amount > 0 && amount > 0 && account1.Balance - amount > 0)
            {
                _accountServices.Transfer(amount, account1, account2);
                MessageBox.Show($"Successfully tranferred {amount} to {txtRecieversAcc}");
                this.Close();
                var dash = _serviceProvider.GetRequiredService<DashBoardN>();
                dash.Show();
            }
        }

        private void Account_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGVAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabDeposit_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVStatement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAcc(object sender, EventArgs e)
        {

        }

        private void DashBoardN_Load(object sender, EventArgs e)
        {
            DataTable dbt = new DataTable();
            dbt.Columns.Add("S/N", typeof(int));
            dbt.Columns.Add("NAME", typeof(string));
            dbt.Columns.Add("NUMBER", typeof(string));
            dbt.Columns.Add("TYPE", typeof(string));
            dbt.Columns.Add("BALANCE", typeof(string));

            int serialNum = 0;

            foreach (var account in Data.Accounts)
            {
                dbt.Rows.Add(new object[] { ++serialNum, account.AccountName, account.AccountNumber, account.Type, $"{account.Balance,-15:C}" });
            }
            dataGridView1.DataSource = dbt;


            DataTable dbtt = new DataTable();
            dbtt.Columns.Add("DATE", typeof(DateTime));
            dbtt.Columns.Add("DESCRIPTION", typeof(string));
            dbtt.Columns.Add("AMOUNT", typeof(string));
            dbtt.Columns.Add("BALANCE", typeof(string));

            foreach (var transaction in Data.Transactions)
            {
                dbtt.Rows.Add(new object[] { transaction.Date, transaction.Description, transaction.Amount, transaction.Balance });
            }
            dGVStatement.DataSource = dbtt;

            foreach (var account in Data.Accounts)
            {
                comboDepositAcc.Items.Add(account.AccountNumber);
                comboWithdrawAcc.Items.Add(account.AccountNumber);
                comboStatementAcc.Items.Add(account.AccountNumber);
                cmbSender.Items.Add(account.AccountNumber);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //var account = Data.Accounts;
            string accNumber = comboDepositAcc.Text;
            if (double.TryParse(txtCashDeposit.Text, out double cash))
            {
                foreach (var account in Data.Accounts)
                {
                    if (account.AccountNumber == accNumber)
                    {
                        _accountServices.Deposit(cash, account);
                        MessageBox.Show("Deposit successful");
                        this.Close();
                        var dash = _serviceProvider.GetRequiredService<DashBoardN>();
                        dash.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid acccount");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid amount");
            }
        }

        private void txtCashWithdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            string accNumber = comboWithdrawAcc.Text;
            if (double.TryParse(txtWithdrawCash.Text, out double cash))
            {
                foreach (var account in Data.Accounts)
                {
                    if (account.AccountNumber == accNumber)
                    {
                        _accountServices.Withdrawal(cash, account);
                        MessageBox.Show("Withdraw successful");
                        this.Close();
                        var dash = _serviceProvider.GetRequiredService<DashBoardN>();
                        dash.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid acccount");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid amount");
            }
        }

        private void txtRecieversAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransferCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVStatement_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboDepositAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var account in Data.Accounts)
            {
                comboDepositAcc.Items.Add(account);
            }
        }

        private void comboWithdrawAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var account in Data.Accounts)
            {
                comboWithdrawAcc.Items.Add(account);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textWithdraw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
