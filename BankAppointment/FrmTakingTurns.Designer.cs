namespace BankAppointment
{
    partial class FrmTakingTurns
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnloanpayments = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btnchangecard = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnaccount = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(24, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(434, 31);
            this.txtName.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(259, 111);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(199, 65);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(259, 285);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(199, 65);
            this.btncheck.TabIndex = 7;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnloanpayments
            // 
            this.btnloanpayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloanpayments.Location = new System.Drawing.Point(22, 285);
            this.btnloanpayments.Name = "btnloanpayments";
            this.btnloanpayments.Size = new System.Drawing.Size(199, 65);
            this.btnloanpayments.TabIndex = 8;
            this.btnloanpayments.Text = "Loan Payments";
            this.btnloanpayments.UseVisualStyleBackColor = true;
            this.btnloanpayments.Click += new System.EventHandler(this.btnloanpayments_Click);
            // 
            // btnloan
            // 
            this.btnloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloan.Location = new System.Drawing.Point(259, 195);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(199, 65);
            this.btnloan.TabIndex = 9;
            this.btnloan.Text = "Loan";
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btnchangecard
            // 
            this.btnchangecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangecard.Location = new System.Drawing.Point(22, 195);
            this.btnchangecard.Name = "btnchangecard";
            this.btnchangecard.Size = new System.Drawing.Size(199, 65);
            this.btnchangecard.TabIndex = 10;
            this.btnchangecard.Text = "Change Card";
            this.btnchangecard.UseVisualStyleBackColor = true;
            this.btnchangecard.Click += new System.EventHandler(this.btnchangecard_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(22, 111);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(199, 65);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnaccount
            // 
            this.btnaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccount.Location = new System.Drawing.Point(22, 374);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(199, 65);
            this.btnaccount.TabIndex = 13;
            this.btnaccount.Text = "Open Account";
            this.btnaccount.UseVisualStyleBackColor = true;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Location = new System.Drawing.Point(259, 374);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(199, 65);
            this.btnManagement.TabIndex = 12;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // FrmTakingTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(486, 479);
            this.Controls.Add(this.btnaccount);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnchangecard);
            this.Controls.Add(this.btnloan);
            this.Controls.Add(this.btnloanpayments);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTakingTurns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTakingTurns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnloanpayments;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Button btnchangecard;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnaccount;
        private System.Windows.Forms.Button btnManagement;
    }
}

