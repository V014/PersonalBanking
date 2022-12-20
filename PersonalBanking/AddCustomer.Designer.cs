namespace PersonalBanking
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.txt_customerID = new System.Windows.Forms.TextBox();
=======
            this.txt_customerNumber = new System.Windows.Forms.TextBox();
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.txt_nationality = new System.Windows.Forms.ComboBox();
            this.txt_accountType = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txt_fname
            // 
            this.txt_fname.BackColor = System.Drawing.Color.White;
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(18, 120);
            this.txt_fname.Multiline = true;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(198, 29);
            this.txt_fname.TabIndex = 0;
            // 
            // txt_lname
            // 
            this.txt_lname.BackColor = System.Drawing.Color.White;
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(18, 193);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(198, 29);
            this.txt_lname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact";
            // 
            // txt_contact
            // 
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(18, 340);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(198, 29);
            this.txt_contact.TabIndex = 3;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(16, 270);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(200, 20);
            this.txt_dob.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Account Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 319);
            this.label8.Name = "label8";
<<<<<<< HEAD
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Customer ID";
            // 
            // txt_customerID
            // 
            this.txt_customerID.BackColor = System.Drawing.Color.White;
            this.txt_customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerID.Location = new System.Drawing.Point(252, 340);
            this.txt_customerID.Multiline = true;
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(198, 29);
            this.txt_customerID.TabIndex = 7;
            this.txt_customerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accountID_KeyPress);
=======
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Customer Number";
            // 
            // txt_customerNumber
            // 
            this.txt_customerNumber.BackColor = System.Drawing.Color.White;
            this.txt_customerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerNumber.Location = new System.Drawing.Point(252, 340);
            this.txt_customerNumber.Multiline = true;
            this.txt_customerNumber.Name = "txt_customerNumber";
            this.txt_customerNumber.Size = new System.Drawing.Size(198, 29);
            this.txt_customerNumber.TabIndex = 7;
            this.txt_customerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accountID_KeyPress);
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            // 
            // txt_nationality
            // 
            this.txt_nationality.BackColor = System.Drawing.Color.White;
            this.txt_nationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nationality.FormattingEnabled = true;
            this.txt_nationality.Items.AddRange(new object[] {
            "American",
            "Asian",
            "British",
            "Bulgarian",
            "Chinese",
            "Dutch",
            "European",
            "Finish",
            "Ghanaian",
            "Israel",
            "Japanese",
            "Malawian"});
            this.txt_nationality.Location = new System.Drawing.Point(252, 122);
            this.txt_nationality.Name = "txt_nationality";
            this.txt_nationality.Size = new System.Drawing.Size(198, 28);
            this.txt_nationality.TabIndex = 4;
            // 
            // txt_accountType
            // 
            this.txt_accountType.BackColor = System.Drawing.Color.White;
            this.txt_accountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_accountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountType.FormattingEnabled = true;
            this.txt_accountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.txt_accountType.Location = new System.Drawing.Point(252, 195);
            this.txt_accountType.Name = "txt_accountType";
            this.txt_accountType.Size = new System.Drawing.Size(198, 28);
            this.txt_accountType.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(252, 268);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(198, 29);
            this.txt_password.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 407);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(471, 57);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Customer";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(471, 61);
            this.panel_top.TabIndex = 8;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(11, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(306, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Customer Registration";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 464);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_accountType);
            this.Controls.Add(this.txt_nationality);
            this.Controls.Add(this.txt_dob);
<<<<<<< HEAD
            this.Controls.Add(this.txt_customerID);
=======
            this.Controls.Add(this.txt_customerNumber);
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.DateTimePicker txt_dob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txt_customerID;
=======
        private System.Windows.Forms.TextBox txt_customerNumber;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
        private System.Windows.Forms.ComboBox txt_nationality;
        private System.Windows.Forms.ComboBox txt_accountType;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_title;
    }
}