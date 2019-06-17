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
using WordMemory.Model;

namespace WordMemory.UI.WinForm
{
    public partial class frmUserChangePassword : Form
    {
        User user;
        UserController _userController;
        public frmUserChangePassword(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            _userController = new UserController();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLastPassword.Text==user.Password)
            {
                if (txtNewPassword.Text==txtNewPasswordAgain.Text)
                {
                    user.Password = txtNewPassword.Text;
                    _userController.Update(user);
                }
                else
                {
                    MessageBox.Show("Girilen Şifreler Aynı Olmalıdır!!!");
                }
            }
            else
            {
                MessageBox.Show("Girilen Şifre En Son Şifre ile Aynı Olmalıdır!!!");
            }
        }
    }
}
