namespace PersonalBanking
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.btn_payee = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_accountNumber = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.panel_balance = new System.Windows.Forms.Panel();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_nav.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_balance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(188, 102);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(693, 385);
            this.panel_main.TabIndex = 2;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.Lavender;
            this.panel_nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_nav.Controls.Add(this.btn_signOut);
            this.panel_nav.Controls.Add(this.btn_payee);
            this.panel_nav.Controls.Add(this.btn_transactions);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 102);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(188, 385);
            this.panel_nav.TabIndex = 3;
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_signOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_signOut.FlatAppearance.BorderSize = 0;
            this.btn_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_signOut.Location = new System.Drawing.Point(0, 333);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(188, 52);
            this.btn_signOut.TabIndex = 4;
            this.btn_signOut.Text = "Sign out";
            this.btn_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // btn_payee
            // 
            this.btn_payee.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_payee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payee.FlatAppearance.BorderSize = 0;
            this.btn_payee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payee.ForeColor = System.Drawing.Color.White;
            this.btn_payee.Location = new System.Drawing.Point(0, 104);
            this.btn_payee.Name = "btn_payee";
            this.btn_payee.Size = new System.Drawing.Size(188, 52);
            this.btn_payee.TabIndex = 3;
            this.btn_payee.Text = "Payee\'s";
            this.btn_payee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payee.UseVisualStyleBackColor = false;
            this.btn_payee.Click += new System.EventHandler(this.btn_payee_Click);
            // 
            // btn_transactions
            // 
            this.btn_transactions.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transactions.FlatAppearance.BorderSize = 0;
            this.btn_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transactions.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_transactions.ForeColor = System.Drawing.Color.White;
            this.btn_transactions.Location = new System.Drawing.Point(0, 52);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(188, 52);
            this.btn_transactions.TabIndex = 1;
            this.btn_transactions.Text = "Transactions";
            this.btn_transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transactions.UseVisualStyleBackColor = false;
            this.btn_transactions.Click += new System.EventHandler(this.btn_transactions_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(188, 52);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_title.Controls.Add(this.panel1);
            this.panel_title.Controls.Add(this.panel_balance);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(881, 102);
            this.panel_title.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_number);
            this.panel1.Controls.Add(this.lbl_accountNumber);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 102);
            this.panel1.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(9, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(188, 29);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Customer Name";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.ForeColor = System.Drawing.Color.White;
            this.lbl_number.Location = new System.Drawing.Point(121, 73);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(107, 16);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Account Number";
            // 
            // lbl_accountNumber
            // 
            this.lbl_accountNumber.AutoSize = true;
            this.lbl_accountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_accountNumber.Location = new System.Drawing.Point(10, 73);
            this.lbl_accountNumber.Name = "lbl_accountNumber";
            this.lbl_accountNumber.Size = new System.Drawing.Size(107, 16);
            this.lbl_accountNumber.TabIndex = 0;
            this.lbl_accountNumber.Text = "Account Number";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.White;
            this.lbl_type.Location = new System.Drawing.Point(10, 46);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(91, 16);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Account Type";
            // 
            // panel_balance
            // 
            this.panel_balance.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_balance.Controls.Add(this.lbl_balance);
            this.panel_balance.Controls.Add(this.label1);
            this.panel_balance.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_balance.Location = new System.Drawing.Point(681, 0);
            this.panel_balance.Name = "panel_balance";
            this.panel_balance.Size = new System.Drawing.Size(200, 102);
            this.panel_balance.TabIndex = 1;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.White;
            this.lbl_balance.Location = new System.Drawing.Point(59, 38);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(84, 29);
            this.lbl_balance.TabIndex = 0;
            this.lbl_balance.Text = "20,000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "£";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_title);
            this.MinimumSize = new System.Drawing.Size(744, 486);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Banking | Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.panel_nav.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_balance.ResumeLayout(false);
            this.panel_balance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_payee;
        private System.Windows.Forms.Button btn_transactions;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_balance;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_accountNumber;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_signOut;
        public System.Windows.Forms.Label lbl_balance;
    }
}