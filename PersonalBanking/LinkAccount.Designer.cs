namespace PersonalBanking
{
    partial class LinkAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkAccount));
            this.label8 = new System.Windows.Forms.Label();
            this.txt_firstAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_secondAccount = new System.Windows.Forms.TextBox();
            this.btn_link = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "1st Accoount Number";
            // 
            // txt_firstAccount
            // 
            this.txt_firstAccount.BackColor = System.Drawing.Color.White;
            this.txt_firstAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstAccount.Location = new System.Drawing.Point(17, 122);
            this.txt_firstAccount.Multiline = true;
            this.txt_firstAccount.Name = "txt_firstAccount";
            this.txt_firstAccount.Size = new System.Drawing.Size(250, 40);
            this.txt_firstAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "2nd Accoount Number";
            // 
            // txt_secondAccount
            // 
            this.txt_secondAccount.BackColor = System.Drawing.Color.White;
            this.txt_secondAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_secondAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secondAccount.Location = new System.Drawing.Point(12, 207);
            this.txt_secondAccount.Multiline = true;
            this.txt_secondAccount.Name = "txt_secondAccount";
            this.txt_secondAccount.Size = new System.Drawing.Size(250, 40);
            this.txt_secondAccount.TabIndex = 1;
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
            this.btn_link.TabIndex = 2;
            this.btn_link.Text = "Link Accounts";
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(11, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(182, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Link Account";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(286, 61);
            this.panel_top.TabIndex = 9;
            // 
            // LinkAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 349);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.txt_secondAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_firstAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LinkAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_firstAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_secondAccount;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_top;
    }
}