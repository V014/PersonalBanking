using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class HomeAdmin : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        public HomeAdmin()
        {
            InitializeComponent();
            loadHome();
            lbl_username.Text = loadUsername();
            lbl_lastSeen.Text = loadLastSeen();
        }
        void loadHome()
        {
            this.panel_main.Controls.Clear();
            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
        }
        public void loadCustomers()
        {
            this.panel_main.Controls.Clear();
            Customer customer = new Customer();
            string queryRecords = "SELECT * FROM Customer";
            con.LoadData(queryRecords, customer.data_customers);
            this.panel_main.Controls.Add(customer);
            customer.Dock = DockStyle.Fill;
            customer.data_customers.Columns[0].Visible = false;
            customer.Show();
            styleDb(customer.data_customers);
        }
        public void loadTransactions()
        {
            this.panel_main.Controls.Clear();
            Transactions transactions = new Transactions();
            this.panel_main.Controls.Add(transactions);
            transactions.Dock = DockStyle.Fill;
            transactions.Show();
            string queryRecords = "SELECT id, firstAccount, secondAccount, Amount, Date FROM transactions";
            con.LoadData(queryRecords, transactions.data_transactions);
            transactions.data_transactions.Columns[0].Visible = false;
            styleDb(transactions.data_transactions);
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
            string queryPayees = "SELECT p.payee_account, p.name, p.customer_account, p.dateCreated FROM payee AS p INNER JOIN transactions AS t ON t.secondAccount = p.payee_account";
            con.LoadData(queryPayees, payee.data_payee);
            styleDb(payee.data_payee);
        }
        private string loadUsername()
        {
            string queryBalance = "SELECT Username FROM admin WHERE status = 'online'";
            string result = con.ReadString(queryBalance);
            return result;
        }
        private string loadLastSeen()
        {
            string queryBalance = "SELECT LastSeen FROM admin WHERE status = 'online'";
            string result = con.ReadString(queryBalance);
            return result;
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
        private void HomeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "UPDATE admin SET status = 'offline'";
            con.ExecuteQuery(query);
            string log = $"UPDATE admin SET LastSeen = '{date}'";
            con.ExecuteQuery(log);
            Application.Exit();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            loadHome();
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            loadTransactions();
        }

        private void btn_payee_Click(object sender, EventArgs e)
        {
            loadPayees();
        }
    }
}
