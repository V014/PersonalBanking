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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_payee = new System.Windows.Forms.Button();
            this.btn_linked = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_accountType = new System.Windows.Forms.Label();
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
            this.panel_main.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(188, 102);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(693, 479);
            this.panel_main.TabIndex = 2;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel_nav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_nav.BackgroundImage")));
            this.panel_nav.Controls.Add(this.btn_payee);
            this.panel_nav.Controls.Add(this.btn_linked);
            this.panel_nav.Controls.Add(this.btn_transactions);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(188, 581);
            this.panel_nav.TabIndex = 3;
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
            // btn_linked
            // 
            this.btn_linked.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_linked.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_linked.FlatAppearance.BorderSize = 0;
            this.btn_linked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_linked.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_linked.ForeColor = System.Drawing.Color.White;
            this.btn_linked.Location = new System.Drawing.Point(0, 104);
            this.btn_linked.Name = "btn_linked";
            this.btn_linked.Size = new System.Drawing.Size(188, 52);
            this.btn_linked.TabIndex = 2;
            this.btn_linked.Text = "Linked Account";
            this.btn_linked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_linked.UseVisualStyleBackColor = false;
            this.btn_linked.Click += new System.EventHandler(this.btn_linked_Click);
            // 
            // btn_transactions
            // 
            this.btn_transactions.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transactions.FlatAppearance.BorderSize = 0;
            this.btn_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transactions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel_title.Location = new System.Drawing.Point(188, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(693, 102);
            this.panel_title.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_accountType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 102);
            this.panel1.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(12, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(188, 29);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Customer Name";
            // 
            // lbl_accountType
            // 
            this.lbl_accountType.AutoSize = true;
            this.lbl_accountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountType.ForeColor = System.Drawing.Color.White;
            this.lbl_accountType.Location = new System.Drawing.Point(14, 52);
            this.lbl_accountType.Name = "lbl_accountType";
            this.lbl_accountType.Size = new System.Drawing.Size(91, 16);
            this.lbl_accountType.TabIndex = 0;
            this.lbl_accountType.Text = "Account Type";
            // 
            // panel_balance
            // 
            this.panel_balance.Controls.Add(this.lbl_balance);
            this.panel_balance.Controls.Add(this.label1);
            this.panel_balance.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_balance.Location = new System.Drawing.Point(493, 0);
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
            this.lbl_balance.Size = new System.Drawing.Size(97, 29);
            this.lbl_balance.TabIndex = 0;
            this.lbl_balance.Text = "625,000";
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
            this.ClientSize = new System.Drawing.Size(881, 581);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_nav);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(746, 537);
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
        private System.Windows.Forms.Button btn_linked;
        private System.Windows.Forms.Button btn_transactions;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_accountType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_balance;
    }
}