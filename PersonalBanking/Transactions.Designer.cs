namespace PersonalBanking
{
    partial class Transactions
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
            this.panel_transactions = new System.Windows.Forms.Panel();
            this.data_transactions = new System.Windows.Forms.DataGridView();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.panel_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_transactions
            // 
            this.panel_transactions.Controls.Add(this.data_transactions);
            this.panel_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_transactions.Location = new System.Drawing.Point(0, 0);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(693, 431);
            this.panel_transactions.TabIndex = 0;
            // 
            // data_transactions
            // 
<<<<<<< HEAD
=======
            this.data_transactions.AllowUserToAddRows = false;
            this.data_transactions.AllowUserToDeleteRows = false;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.data_transactions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_transactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_transactions.Location = new System.Drawing.Point(0, 0);
            this.data_transactions.Name = "data_transactions";
<<<<<<< HEAD
=======
            this.data_transactions.ReadOnly = true;
>>>>>>> ea55cebfc6252257567cdd1f590ab73666373841
            this.data_transactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_transactions.Size = new System.Drawing.Size(693, 431);
            this.data_transactions.TabIndex = 0;
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_buttons);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 431);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(693, 48);
            this.panel_controls.TabIndex = 1;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_withdraw);
            this.panel_buttons.Controls.Add(this.btn_deposit);
            this.panel_buttons.Controls.Add(this.btn_transfer);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buttons.Location = new System.Drawing.Point(264, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(429, 48);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_withdraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_withdraw.FlatAppearance.BorderSize = 0;
            this.btn_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_withdraw.Location = new System.Drawing.Point(288, 0);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(144, 48);
            this.btn_withdraw.TabIndex = 4;
            this.btn_withdraw.Text = "Withdraw Money";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_deposit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_deposit.FlatAppearance.BorderSize = 0;
            this.btn_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.ForeColor = System.Drawing.Color.White;
            this.btn_deposit.Location = new System.Drawing.Point(144, 0);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(144, 48);
            this.btn_deposit.TabIndex = 3;
            this.btn_deposit.Text = "Deposit Money";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_transfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_transfer.FlatAppearance.BorderSize = 0;
            this.btn_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.ForeColor = System.Drawing.Color.White;
            this.btn_transfer.Location = new System.Drawing.Point(0, 0);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(144, 48);
            this.btn_transfer.TabIndex = 2;
            this.btn_transfer.Text = "Transfer Money";
            this.btn_transfer.UseVisualStyleBackColor = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_transactions);
            this.Controls.Add(this.panel_controls);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(693, 479);
            this.panel_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_transactions)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_transactions;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_transfer;
        public System.Windows.Forms.DataGridView data_transactions;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_deposit;
    }
}
