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
    public partial class Home : Form
    {
        Connection con = new Connection();
        public Home()
        {
            InitializeComponent();
            loadHome();
        }
        
        void loadHome()
        {
            this.panel_main.Controls.Clear();
            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.AutoSize = true;
            welcome.Show();
        }
        private string loadBalance()
        {
            string queryBalance = "SELECT Balance FROM customer";
            string result = con.ReadString(queryBalance);
            return result;
        }
        // button transaction
        private void btn_transactions_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Transactions transactions = new Transactions();
            this.panel_main.Controls.Add(transactions);
            transactions.Dock = DockStyle.Fill;
            transactions.Show();
            string queryRecords = "SELECT * FROM transactions";
            con.LoadData(queryRecords, transactions.data_transactions);
            transactions.data_transactions.Columns[0].Visible = false;
            //styleDarkDataGridView(records.dataGrid);
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
            this.panel_main.Controls.Clear();
            Payee payee = new Payee();
            this.panel_main.Controls.Add(payee);
            payee.Dock = DockStyle.Fill;
            payee.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "UPDATE customer SET status = 'offline'";
            con.ExecuteQuery(query);
            Application.Exit();
        }
    }
}
