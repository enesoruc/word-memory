using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordMemory.Model;
using WordMemory.BLL;
using WordMemory.DTO;

namespace WordMemory.UI.WinForm
{
    public partial class frmAdmin : Form
    {
        User user;
        AdminReportController adminController;
        PaymentController _paymentController;
        frmLogin frmLogin;
        UserController UserController;
        

        public frmAdmin(User currentUser,Form frm)
        {
            InitializeComponent();
            user = currentUser;
            _paymentController = new PaymentController();
            frmLogin = (frmLogin)frm;
            UserController = new UserController();
        }

        private void userStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminViewUsers frmAdminViewUsers = new frmAdminViewUsers();
            frmAdminViewUsers.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserChangePassword frmUserChangePassword = new frmUserChangePassword(user);
            frmUserChangePassword.ShowDialog();
        }

        private void DictionarySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminWordList frmDictionary = new frmAdminWordList();
            frmDictionary.ShowDialog();
            RefreshLabelValues();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            RefreshLabelValues();
            
            //ListViewItem lvi;
            //foreach (var item in adminController.GetReportBetweenDateRange("1900.01.01", "2019.05.06"))
            //{
            //    lvi = new ListViewItem(item.English.ToString());
            //    lvi.SubItems.Add(item.Turkish.ToString());
            //    lvi.SubItems.Add(item.WordCount.ToString());
            //    lstWordBased.Items.Add(lvi);
            //}
        }

        private void RefreshLabelValues()
        {
            int LimitedCount = 0;
            List<User> userList = UserController.GetAllUser();
            foreach (User item in userList)
            {
                if (item.RoleID == 3)
                {
                    LimitedCount++;
                }
            }

            adminController = new AdminReportController();
            lblUserCount.Text = adminController.GetCount("User");
            lblWordCount.Text = adminController.GetCount("Dictionary");
            lblPayments.Text = adminController.GetCount("Payment");
            lblLimitedUsers.Text = LimitedCount.ToString();
            lblPayments.Text = _paymentController.GetTotalPrice().ToString() + " $";

        }

        private void KelimaBazlıRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msWordStatistics_Click(object sender, EventArgs e)
        {
            frmWordStatistics frm = new frmWordStatistics();
            frm.ShowDialog();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.ChangeVisible();
        }

        private void MsUserStatistics_Click(object sender, EventArgs e)
        {
            frmUserStatistics frm = new frmUserStatistics();
            frm.ShowDialog();
        }
    }
}
