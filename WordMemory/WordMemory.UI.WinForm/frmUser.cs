using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordMemory.BLL;
using WordMemory.DTO;
using WordMemory.Model;

namespace WordMemory.UI.WinForm
{
    public partial class frmUser : Form
    {
        UserController _userController;
        PracticeController _practiceController;
        User user;
        frmLogin frmLogin;
        public frmUser(User currentUser, Form frm)
        {
            InitializeComponent();
            user = currentUser;
            _userController = new UserController();
            _practiceController = new PracticeController();
            frmLogin = (frmLogin)frm;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Welcome : " + user.FirstName + " " + user.LastName;
            ChangeRole();
            menuStrip1.ForeColor = Color.White;

            GetTotalScoreDatas();
        }
        private void GetTotalScoreDatas()
        {
            UserScoreDTO userScoreDTO = _practiceController.GetTotalUserScoreByUserID(user.UserID);
            if (userScoreDTO.FalseAnswer == 0 & userScoreDTO.FalseAnswer == 0 & userScoreDTO.FalseAnswer == 0)
            {
               // MessageBox.Show("GET PREMIUM FOR MORE WORDS");
            }
            else
            {
                decimal total = userScoreDTO.TrueAnswer + userScoreDTO.FalseAnswer;
                decimal divide = Decimal.Round((userScoreDTO.TrueAnswer / total), 2);

                lblTrueScore.Text = userScoreDTO.TrueAnswer.ToString();
                lblFalseScore.Text = userScoreDTO.FalseAnswer.ToString();
                lblTotalTıme.Text = Decimal.Round(((userScoreDTO.PracticeTime / (decimal)60)), 0).ToString() + " min.";
                lblSuccesRate.Text = "% " + (divide * 100).ToString();
            }

            //    lblTrueScore.Text = userScoreDTO.TrueAnswer.ToString();
            //    lblFalseScore.Text = userScoreDTO.FalseAnswer.ToString();
            //    lblTotalTıme.Text = Decimal.Round(((userScoreDTO.PracticeTime / (decimal)60)), 0).ToString() + " min.";
            //    lblSuccesRate.Text = "% " + (divide * 100).ToString();
            //}

        }

        public void ChangeRole()
        {
            lblRoleType.Text = (user.RoleID == 2) ? "NORMAL" : "LIMITED";
            if (user.RoleID == 3)
            {
                grpBoxGetPremium.Visible = true;
            }
            else
            {
                grpBoxGetPremium.Visible = false;
            }
        }

        private void btnGetPremium_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment(user, this);
            frmPayment.ShowDialog();
        }

        private void msViewMyWordPools_Click(object sender, EventArgs e)
        {
            frmMyWordPools myWordPools = new frmMyWordPools(user);
            myWordPools.ShowDialog();
        }

        private void msCreateNewWordPool_Click(object sender, EventArgs e)
        {
            if (user.RoleID == 3 && _userController.GetPoolCountByUserID(user.UserID) > 0)
            {
                MessageBox.Show("Get Premium For More WordPools");
            }
            else
            {
                frmCreateNewWordPool frm = new frmCreateNewWordPool(user);
                frm.ShowDialog();
            }
        }

        private void msPractice_Click(object sender, EventArgs e)
        {
            frmPractice frmPractice = new frmPractice(user);
            frmPractice.ShowDialog();
            GetTotalScoreDatas();
        }

        private void msUpdatePersonalInfo_Click(object sender, EventArgs e)
        {
            frmUserChangePersonalInfo frmUserChangePersonalInfo = new frmUserChangePersonalInfo(user);
            frmUserChangePersonalInfo.ShowDialog();
        }

        private void msChangePassword_Click(object sender, EventArgs e)
        {
            frmUserChangePassword frmUserChangePassword = new frmUserChangePassword(user);
            frmUserChangePassword.ShowDialog();
        }

        private void hesabımıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDeleteAccount frmUserDeleteAccount = new frmUserDeleteAccount(user);
            frmUserDeleteAccount.ShowDialog();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.ChangeVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserPage frmUserPage = new frmUserPage();
            frmUserPage.ShowDialog();
        }
    }
}
