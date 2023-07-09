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
    public partial class FrmTakingTurns : Form
    {
        public FrmTakingTurns()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.Deposit.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount1.Text = 
                    FrmManagementTruns.managementTruns.Deposit.Count.ToString();
                txtName.Text = "";
            }
        }

        private void FrmTakingTurns_Load(object sender, EventArgs e)
        {
            FrmManagementTruns managementTruns = new FrmManagementTruns();
            managementTruns.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.Withdraw.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount2.Text =
                    FrmManagementTruns.managementTruns.Withdraw.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btnchangecard_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.ChangeCard.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount3.Text =
                    FrmManagementTruns.managementTruns.ChangeCard.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.Loan.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount4.Text =
                    FrmManagementTruns.managementTruns.Loan.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btnloanpayments_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.LoanPayments.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount5.Text =
                    FrmManagementTruns.managementTruns.LoanPayments.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.Check.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount6.Text =
                    FrmManagementTruns.managementTruns.Check.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.OpenAccount.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount7.Text =
                    FrmManagementTruns.managementTruns.OpenAccount.Count.ToString();
                txtName.Text = "";
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Name", "Name a Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmManagementTruns.managementTruns.Management.Enqueue(txtName.Text);
                FrmManagementTruns.managementTruns.QueuesCount8.Text =
                    FrmManagementTruns.managementTruns.Management.Count.ToString();
                txtName.Text = "";
            }
        }
    }
}
