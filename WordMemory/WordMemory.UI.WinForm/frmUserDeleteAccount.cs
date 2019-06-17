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
    public partial class frmUserDeleteAccount : Form
    {
        User User;
        UserController _userController;
        public frmUserDeleteAccount(User currentUser)
        {
            InitializeComponent();
            User = currentUser;
            _userController = new UserController();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text==User.Email)
            {
                if (txtPassword.Text==User.Password)
                {
                    if (txtPassword.Text == txtPasswordAgain.Text)
                    {
                        User.IsActive = false;
                        _userController.DeleteUser(User);
                    }
                    else
                    {
                        MessageBox.Show("Girilen Şifreler Aynı Olmalıdır");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Şifre Yanlış");
                }
                
            }
        }
    }
}
