namespace PersonalBanking
{
    partial class Deposit
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
            this.btn_link = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_link
            // 
            this.btn_link.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_link.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_link.FlatAppearance.BorderSize = 0;
            this.btn_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link.ForeColor = System.Drawing.Color.White;
            this.btn_link.Location = new System.Drawing.Point(0, 291);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(286, 58);
            this.btn_link.TabIndex = 13;
            this.btn_link.Text = "Deposit";
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(17, 209);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(250, 40);
            this.txt_amount.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(11, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(209, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Deposit Money";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Account Number";
            // 
            // txt_account
            // 
            this.txt_account.BackColor = System.Drawing.Color.White;
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account.Location = new System.Drawing.Point(17, 112);
            this.txt_account.Multiline = true;
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(250, 40);
            this.txt_account.TabIndex = 11;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 349);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_account;
    }
}