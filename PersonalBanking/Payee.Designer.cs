namespace PersonalBanking
{
    partial class Payee
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
            this.data_payee = new System.Windows.Forms.DataGridView();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_payee = new System.Windows.Forms.Button();
            this.panel_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_payee)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_transactions
            // 
            this.panel_transactions.Controls.Add(this.data_payee);
            this.panel_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_transactions.Location = new System.Drawing.Point(0, 0);
            this.panel_transactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(1040, 663);
            this.panel_transactions.TabIndex = 2;
            // 
            // data_payee
            // 
            this.data_payee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_payee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_payee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_payee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_payee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_payee.Location = new System.Drawing.Point(0, 0);
            this.data_payee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_payee.Name = "data_payee";
            this.data_payee.Size = new System.Drawing.Size(1040, 663);
            this.data_payee.TabIndex = 0;
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_buttons);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 663);
            this.panel_controls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(1040, 74);
            this.panel_controls.TabIndex = 3;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_payee);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buttons.Location = new System.Drawing.Point(822, 0);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(218, 74);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_payee
            // 
            this.btn_payee.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_payee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_payee.FlatAppearance.BorderSize = 0;
            this.btn_payee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payee.ForeColor = System.Drawing.Color.White;
            this.btn_payee.Location = new System.Drawing.Point(0, 0);
            this.btn_payee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_payee.Name = "btn_payee";
            this.btn_payee.Size = new System.Drawing.Size(216, 74);
            this.btn_payee.TabIndex = 2;
            this.btn_payee.Text = "Add Payee";
            this.btn_payee.UseVisualStyleBackColor = false;
            this.btn_payee.Click += new System.EventHandler(this.btn_payee_Click);
            // 
            // Payee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_transactions);
            this.Controls.Add(this.panel_controls);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payee";
            this.Size = new System.Drawing.Size(1040, 737);
            this.panel_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_payee)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_transactions;
        public System.Windows.Forms.DataGridView data_payee;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_payee;
    }
}
