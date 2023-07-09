using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppointment
{
    public partial class FrmManagementTruns : Form
    {
        public static FrmManagementTruns managementTruns;
        public Queue<string> Deposit;
        public Queue<string> Withdraw;
        public Queue<string> ChangeCard;
        public Queue<string> Loan;
        public Queue<string> LoanPayments;
        public Queue<string> Check;
        public Queue<string> OpenAccount;
        public Queue<string> Management;
        public Label QueuesCount1;
        public Label QueuesCount2;
        public Label QueuesCount3;
        public Label QueuesCount4;
        public Label QueuesCount5;
        public Label QueuesCount6;
        public Label QueuesCount7;
        public Label QueuesCount8;
        public FrmManagementTruns()
        {
            managementTruns = this;
            InitializeComponent();
            Deposit = _deposit;
            Withdraw=_withdraw;
            ChangeCard = _changeCard;
            Loan = _loan;
            LoanPayments = _loanPayments;
            Check = _check;
            OpenAccount = _openAccount;
            Management = _Management;
            QueuesCount1 = lblQueuesCount1;
            QueuesCount2 = lblQueuesCount2;
            QueuesCount3 = lblQueuesCount3;
            QueuesCount4 = lblQueuesCount4;
            QueuesCount5 = lblQueuesCount5;
            QueuesCount6 = lblQueuesCount6;
            QueuesCount7 = lblQueuesCount7;
            QueuesCount8 = lblQueuesCount8;
        }
        Queue<string> _deposit = new Queue<string>();
        Queue<string> _withdraw = new Queue<string>();
        Queue<string> _changeCard = new Queue<string>();
        Queue<string> _loan = new Queue<string>();
        Queue<string> _loanPayments = new Queue<string>();
        Queue<string> _check = new Queue<string>();
        Queue<string> _openAccount = new Queue<string>();
        Queue<string> _Management = new Queue<string>();

        private void btnnextperson1_Click(object sender, EventArgs e)
        {
            if(Deposit.Count > 0)
            {
                lblname1.Text = Deposit.Dequeue();
                lblQueuesCount1.Text= Deposit.Count.ToString();
            }
        }

        private void btnnextperson2_Click(object sender, EventArgs e)
        {
            if (Withdraw.Count > 0)
            {
                lblname2.Text = Withdraw.Dequeue();
                lblQueuesCount2.Text = Withdraw.Count.ToString();
            }
        }

        private void btnnextperson3_Click(object sender, EventArgs e)
        {
            if (ChangeCard.Count > 0)
            {
                lblname3.Text = ChangeCard.Dequeue();
                lblQueuesCount3.Text = ChangeCard.Count.ToString();
            }
        }

        private void btnnextperson4_Click(object sender, EventArgs e)
        {
            if (Loan.Count > 0)
            {
                lblname4.Text = Loan.Dequeue();
                lblQueuesCount4.Text = Loan.Count.ToString();
            }
        }

        private void btnnextperson5_Click(object sender, EventArgs e)
        {
            if (LoanPayments.Count > 0)
            {
                lblname5.Text = LoanPayments.Dequeue();
                lblQueuesCount5.Text = LoanPayments.Count.ToString();
            }
        }

        private void btnnextperson6_Click(object sender, EventArgs e)
        {
            if (Check.Count > 0)
            {
                lblname6.Text = Check.Dequeue();
                lblQueuesCount6.Text = Check.Count.ToString();
            }
        }

        private void btnnextperson7_Click(object sender, EventArgs e)
        {
            if (OpenAccount.Count > 0)
            {
                lblname7.Text = OpenAccount.Dequeue();
                lblQueuesCount7.Text = OpenAccount.Count.ToString();
            }
        }

        private void btnnextperson8_Click(object sender, EventArgs e)
        {
            if (Management.Count > 0)
            {
                lblname8.Text = Management.Dequeue();
                lblQueuesCount8.Text = Management.Count.ToString();
            }
        }
    }
}
