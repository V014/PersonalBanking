using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Home : Form
    {
        Connection con = new Connection();
        public Home()
        {
            InitializeComponent();
            loadHome();
            lbl_balance.Text = loadBalance();
            lbl_name.Text = loadName();
            lbl_type.Text = loadAccountType();
            lbl_number.Text = loadAccountNumber();
        }
        
        public void loadHome()
        {
            this.panel_main.Controls.Clear();
            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
        }
        public void refresh()
        {
            lbl_balance.Text = loadBalance();
            lbl_name.Text = loadName();
            lbl_type.Text = loadAccountType();
            lbl_number.Text = loadAccountNumber();
        }
        public string loadBalance()
        {
            string queryBalance = "SELECT balance FROM account WHERE status = 'online'";
            string result = con.ReadString(queryBalance);
            return result;
        }
        public string loadName()
        {
            string queryCustomer = $"SELECT customerID FROM account WHERE status = 'online'";
            string result = con.ReadString(queryCustomer);
            string queryName = $"SELECT FirstName FROM customer WHERE ID = {result}";
            string name = con.ReadString(queryName);
            return name;
            
        }
        public string loadAccountType()
        {
            string queryAccountType = $"SELECT AccountType FROM account WHERE status = 'online'";
            string result = con.ReadString(queryAccountType);
            return result;
        }
        public string loadAccountNumber()
        {
            string queryAccountNumber = $"SELECT AccountNumber FROM account WHERE status = 'online'";
            string result = con.ReadString(queryAccountNumber);
            return result;
        }
        public void loadPayees()
        {
            this.panel_main.Controls.Clear();
            Payee payee = new Payee();
            this.panel_main.Controls.Add(payee);
            payee.Dock = DockStyle.Fill;
            payee.Show();
            string queryCustomer = $"SELECT accountNumber FROM account WHERE status = 'online'";
            string accountNumber = con.ReadString(queryCustomer);
            string queryPayees = $"SELECT name, payeeAccount, date FROM payee WHERE customerAccount =  '{accountNumber}'";
            con.LoadData(queryPayees, payee.data_payee);
            styleDb(payee.data_payee);
        }
        public void loadTransactions()
        {
            this.panel_main.Controls.Clear();
            Transactions transactions = new Transactions();
            this.panel_main.Controls.Add(transactions);
            transactions.Dock = DockStyle.Fill;
            transactions.Show();
            string queryRecords = "SELECT t.id, t.firstAccount, t.secondAccount, t.Amount, t.Date, t.type, a.accountNumber, a.accountType FROM transactions AS t INNER JOIN account AS a ON t.firstAccount = a.accountNumber WHERE a.status = 'online'";
            con.LoadData(queryRecords, transactions.data_transactions);
            transactions.data_transactions.Columns[0].Visible = false;
            styleDb(transactions.data_transactions);
        }
        // styling the data grid views
        void styleDb(DataGridView dataGrid)
        {
            dataGrid.BorderStyle = BorderStyle.None;
            
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGrid.RowHeadersVisible = false;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.AllowDrop = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(37, 37, 39);

            dataGrid.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(37, 37, 39);

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Calibri", 11);
            dataGrid.DefaultCellStyle.Font = new Font("Calibri", 11);
        }
        // button transaction
        private void btn_transactions_Click(object sender, EventArgs e)
        {
            loadTransactions();
            //transactions.data_transactions.Columns[0].Visible = false;
        }
        // button home
        private void btn_home_Click(object sender, EventArgs e)
        {
            loadHome();
        }
        // button linked accounts
        private void btn_linked_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            LinkedAccounts linkedAccount = new LinkedAccounts();
            this.panel_main.Controls.Add(linkedAccount);
            linkedAccount.Dock = DockStyle.Fill;
            linkedAccount.Show();
        }
        // button payee
        private void btn_payee_Click(object sender, EventArgs e)
        {
            loadPayees();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "UPDATE account SET status = 'offline'";
            con.ExecuteQuery(query);
            Application.Exit();
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            string query = "UPDATE account SET status = 'offline'";
            con.ExecuteQuery(query);
            this.Hide();
        }
    }
}
