using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalBanking
{
    public partial class Payee : UserControl
    {
        public Payee()
        {
            InitializeComponent();
        }

        private void btn_payee_Click(object sender, EventArgs e)
        {
            AddPayee payee = new AddPayee();
            payee.Show();
        }
    }
}
