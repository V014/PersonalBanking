namespace PersonalBanking
{
    partial class HomeAdmin
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_lastSeen = new System.Windows.Forms.Label();
            this.panel_balance = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_payee = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.btn_signOut = new System.Windows.Forms.Button();
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.panel_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(188, 102);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(693, 479);
            this.panel_main.TabIndex = 5;
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
            this.panel_title.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_lastSeen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 102);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Online";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(12, 23);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(124, 29);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // lbl_lastSeen
            // 
            this.lbl_lastSeen.AutoSize = true;
            this.lbl_lastSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastSeen.ForeColor = System.Drawing.Color.White;
            this.lbl_lastSeen.Location = new System.Drawing.Point(88, 71);
            this.lbl_lastSeen.Name = "lbl_lastSeen";
            this.lbl_lastSeen.Size = new System.Drawing.Size(68, 16);
            this.lbl_lastSeen.TabIndex = 0;
            this.lbl_lastSeen.Text = "Last Seen";
            // 
            // panel_balance
            // 
            this.panel_balance.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_balance.Location = new System.Drawing.Point(690, 0);
            this.panel_balance.Name = "panel_balance";
            this.panel_balance.Size = new System.Drawing.Size(191, 102);
            this.panel_balance.TabIndex = 1;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.Lavender;
<<<<<<< HEAD
=======
            this.panel_nav.Controls.Add(this.btn_signOut);
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.panel_nav.Controls.Add(this.btn_payee);
            this.panel_nav.Controls.Add(this.btn_transactions);
            this.panel_nav.Controls.Add(this.btn_customers);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 102);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(188, 479);
            this.panel_nav.TabIndex = 8;
            // 
            // btn_payee
            // 
            this.btn_payee.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_payee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payee.FlatAppearance.BorderSize = 0;
            this.btn_payee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payee.ForeColor = System.Drawing.Color.White;
            this.btn_payee.Location = new System.Drawing.Point(0, 156);
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
            this.btn_transactions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transactions.ForeColor = System.Drawing.Color.White;
            this.btn_transactions.Location = new System.Drawing.Point(0, 104);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(188, 52);
            this.btn_transactions.TabIndex = 2;
            this.btn_transactions.Text = "Transactions";
            this.btn_transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transactions.UseVisualStyleBackColor = false;
            this.btn_transactions.Click += new System.EventHandler(this.btn_transactions_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Location = new System.Drawing.Point(0, 52);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(188, 52);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
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
<<<<<<< HEAD
=======
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_signOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_signOut.FlatAppearance.BorderSize = 0;
            this.btn_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_signOut.Location = new System.Drawing.Point(0, 427);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(188, 52);
            this.btn_signOut.TabIndex = 5;
            this.btn_signOut.Text = "Sign out";
            this.btn_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(881, 581);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_title);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeAdmin_FormClosed);
            this.panel_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_lastSeen;
        private System.Windows.Forms.Panel panel_balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_payee;
        private System.Windows.Forms.Button btn_transactions;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_home;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button btn_signOut;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
    }
}