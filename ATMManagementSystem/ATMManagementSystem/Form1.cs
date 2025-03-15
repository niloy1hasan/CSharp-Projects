using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ATMManagementSystem
{
    public partial class MainForm : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account loggedInAccount = null;

        public MainForm()
        {
            InitializeComponent();

            accounts.Add(new Account("123456", "Niloy", "1234", 5000.0));
            accounts.Add(new Account("654321", "Mukta", "4321", 3000.0));

            CustomizeUI();
            txtAccountNumber.TextChanged += txtAccountNumber_TextChanged;
            txtPIN.TextChanged += txtPIN_TextChanged;
        }


        public static string ShowInputDialog(string title, string promptText)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label label = new Label() { Left = 50, Top = 20, Text = promptText };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return textBox.Text;
        }


        private void CustomizeUI()
        {
            txtAccountNumber.PlaceholderText = "Enter Account Number";
            txtPIN.PlaceholderText = "Enter PIN";
            txtPIN.PasswordChar = '*';

            btnLogin.FillColor = System.Drawing.Color.FromArgb(72, 133, 237);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            btnLogout.FillColor = System.Drawing.Color.FromArgb(219, 68, 55);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accNumber = txtAccountNumber.Text;
            string pin = txtPIN.Text;

            loggedInAccount = accounts.Find(a => a.AccountNumber == accNumber && a.PIN == pin);

            if (loggedInAccount != null)
            {
                ShowAccountMenu();
            }
            else
            {
                lblStatus.Text = "Invalid Account Number or PIN!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ShowAccountMenu()
        {
            pnlLogin.Visible = false;
            pnlAccountMenu.Visible = true;
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your Balance: {loggedInAccount.Balance:C}", "Balance");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string input = ShowInputDialog("Deposit", "Enter amount to deposit:");

            if (double.TryParse(input, out double amount) && amount > 0)
            {
                loggedInAccount.Balance += amount;
                loggedInAccount.TransactionHistory.Add($"Deposited: {amount:C}");
                MessageBox.Show("Deposit successful!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid amount!", "Error");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string input = ShowInputDialog("Withdraw", "Enter amount to withdraw:");
            if (double.TryParse(input, out double amount) && amount > 0 && amount <= loggedInAccount.Balance)
            {
                loggedInAccount.Balance -= amount;
                loggedInAccount.TransactionHistory.Add($"Withdrew: {amount:C}");
                MessageBox.Show("Withdrawal successful!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid amount or insufficient balance!", "Error");
            }
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            string history = string.Join(Environment.NewLine, loggedInAccount.TransactionHistory);
            MessageBox.Show(string.IsNullOrWhiteSpace(history) ? "No transactions yet." : history, "Transaction History");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = string.Empty;
            txtPIN.Text = string.Empty;
            loggedInAccount = null;
            pnlAccountMenu.Visible = false;
            pnlLogin.Visible = true;
            lblStatus.Text = string.Empty;
            MessageBox.Show("Logged out successfully");
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            logInButtonDisable();
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            logInButtonDisable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInButtonDisable()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text) || string.IsNullOrWhiteSpace(txtPIN.Text))
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (viewBtn.Tag as string == "hidden")
            {
                viewBtn.Image = Properties.Resources.eye;
                viewBtn.Tag = "eye";
                txtPIN.PasswordChar = '\0';
                txtPIN.Focus();
            }
            else
            {
                viewBtn.Image = Properties.Resources.hidden; 
                viewBtn.Tag = "hidden";
                txtPIN.PasswordChar = '*';
                txtPIN.Focus();
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string PIN { get; set; }
        public double Balance { get; set; }
        public List<string> TransactionHistory { get; set; } = new List<string>();

        public Account(string accountNumber, string name, string pin, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            PIN = pin;
            Balance = balance;
        }
    }
}
