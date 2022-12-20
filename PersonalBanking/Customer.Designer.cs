namespace PersonalBanking
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_customers = new System.Windows.Forms.DataGridView();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_link = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_customers)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_customers
            // 
<<<<<<< HEAD
=======
            this.data_customers.AllowUserToAddRows = false;
            this.data_customers.AllowUserToDeleteRows = false;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.data_customers.BackgroundColor = System.Drawing.Color.White;
            this.data_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_customers.Location = new System.Drawing.Point(0, 0);
            this.data_customers.Name = "data_customers";
<<<<<<< HEAD
=======
            this.data_customers.ReadOnly = true;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.data_customers.Size = new System.Drawing.Size(693, 431);
            this.data_customers.TabIndex = 1;
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_buttons);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 431);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(693, 48);
            this.panel_controls.TabIndex = 2;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_close);
            this.panel_buttons.Controls.Add(this.btn_link);
            this.panel_buttons.Controls.Add(this.btn_add);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buttons.Location = new System.Drawing.Point(260, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(433, 48);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(288, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(144, 48);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close Account";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_link
            // 
            this.btn_link.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_link.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_link.FlatAppearance.BorderSize = 0;
            this.btn_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link.ForeColor = System.Drawing.Color.White;
            this.btn_link.Location = new System.Drawing.Point(144, 0);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(144, 48);
            this.btn_link.TabIndex = 3;
            this.btn_link.Text = "Link Accounts";
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(144, 48);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add Customer";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_customers);
            this.Controls.Add(this.panel_controls);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(693, 479);
            ((System.ComponentModel.ISupportInitialize)(this.data_customers)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView data_customers;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Button btn_add;
    }
}
