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
using WordMemory.CustomException;
using WordMemory.DTO;
using WordMemory.Model;
// ENES BU SENIN ICIN
namespace WordMemory.UI.WinForm
{
    public partial class frmLogin : Form
    {
        UserController _userController;

        LoginDTO loginDTO;
        User user;
        public frmLogin()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();

        }
        public void ChangeVisible()
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void btnSıgnIn_Click(object sender, EventArgs e)
        {
            user = new User();
            loginDTO = new LoginDTO();
            loginDTO.Email = txtEmail.Text;
            loginDTO.Password = txtPassword.Text;
            try
            {
                user = _userController.UserLogin(loginDTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (user.RoleID == 1)
            {
                frmAdmin frmAdmin = new frmAdmin(user,this);
                ChangeVisible();
                frmAdmin.Show();
            }
            else
            {
                frmUser frmUser = new frmUser(user,this);
                ChangeVisible();
                frmUser.Show();
            }
        }
    }

}