namespace PersonalBanking
{
    partial class CloseAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseAccount));
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_closeAccount = new System.Windows.Forms.Button();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(286, 61);
            this.panel_top.TabIndex = 14;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(11, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(266, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Deactivate Account";
            // 
            // btn_closeAccount
            // 
            this.btn_closeAccount.BackColor = System.Drawing.Color.Crimson;
            this.btn_closeAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_closeAccount.FlatAppearance.BorderSize = 0;
            this.btn_closeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAccount.ForeColor = System.Drawing.Color.White;
            this.btn_closeAccount.Location = new System.Drawing.Point(0, 189);
            this.btn_closeAccount.Name = "btn_closeAccount";
            this.btn_closeAccount.Size = new System.Drawing.Size(286, 58);
            this.btn_closeAccount.TabIndex = 13;
            this.btn_closeAccount.Text = "Close Account";
            this.btn_closeAccount.UseVisualStyleBackColor = false;
            this.btn_closeAccount.Click += new System.EventHandler(this.btn_closeAccount_Click);
            // 
            // txt_accountID
            // 
            this.txt_accountID.BackColor = System.Drawing.Color.White;
            this.txt_accountID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_accountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountID.Location = new System.Drawing.Point(17, 122);
            this.txt_accountID.Multiline = true;
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.Size = new System.Drawing.Size(250, 40);
            this.txt_accountID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Accoount Number";
            // 
            // CloseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 247);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_closeAccount);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_closeAccount;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label label8;
    }
}