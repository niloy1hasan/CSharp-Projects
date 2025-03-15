namespace ATMManagementSystem
{
    partial class MainForm
    {
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2Panel pnlAccountMenu;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPIN;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnViewBalance;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnTransactionHistory;

        private void InitializeComponent()
        {
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAccountMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnViewBalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactionHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlLogin.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlAccountMenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.guna2Panel1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(650, 443);
            this.pnlLogin.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtAccountNumber);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.txtPIN);
            this.guna2Panel1.Controls.Add(this.viewBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(127, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(364, 409);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "PIN:";
            // 
            // viewBtn
            // 
            this.viewBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Image = global::ATMManagementSystem.Properties.Resources.hidden;
            this.viewBtn.Location = new System.Drawing.Point(271, 183);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(51, 41);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtAccountNumber.BorderRadius = 3;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(52, 146);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAccountNumber.PlaceholderText = "Account Number";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(269, 36);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(54, 263);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.DisabledState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.btnLogin.Enabled = false;
            this.btnLogin.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(52, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.BorderColor = System.Drawing.Color.Silver;
            this.txtPIN.BorderRadius = 3;
            this.txtPIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPIN.DefaultText = "";
            this.txtPIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPIN.ForeColor = System.Drawing.Color.Black;
            this.txtPIN.Location = new System.Drawing.Point(52, 217);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPIN.PlaceholderText = "PIN";
            this.txtPIN.SelectedText = "";
            this.txtPIN.Size = new System.Drawing.Size(269, 36);
            this.txtPIN.TabIndex = 2;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // pnlAccountMenu
            // 
            this.pnlAccountMenu.Controls.Add(this.guna2Panel2);
            this.pnlAccountMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountMenu.Name = "pnlAccountMenu";
            this.pnlAccountMenu.Size = new System.Drawing.Size(650, 443);
            this.pnlAccountMenu.TabIndex = 1;
            this.pnlAccountMenu.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnViewBalance);
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.btnTransactionHistory);
            this.guna2Panel2.Controls.Add(this.btnWithdraw);
            this.guna2Panel2.Controls.Add(this.btnDeposit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(650, 443);
            this.guna2Panel2.TabIndex = 6;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.Animated = true;
            this.btnViewBalance.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewBalance.ForeColor = System.Drawing.Color.White;
            this.btnViewBalance.Location = new System.Drawing.Point(164, 117);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(300, 36);
            this.btnViewBalance.TabIndex = 1;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(164, 298);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 36);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Animated = true;
            this.btnTransactionHistory.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.btnTransactionHistory.Location = new System.Drawing.Point(164, 256);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(300, 36);
            this.btnTransactionHistory.TabIndex = 4;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(164, 210);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(300, 36);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Animated = true;
            this.btnDeposit.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(164, 163);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(300, 36);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(236, 265);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 443);
            this.Controls.Add(this.pnlAccountMenu);
            this.Controls.Add(this.pnlLogin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Management System";
            this.pnlLogin.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlAccountMenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
