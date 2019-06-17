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
    public partial class frmUserChangePersonalInfo : Form
    {
        User User;
        UserController _userController;
        public frmUserChangePersonalInfo(User currentUser)
        {
            User = currentUser;
            _userController = new UserController();
            InitializeComponent();
        }
        byte roleID;
        private void btnSave_Click(object sender, EventArgs e)
        {
            User.FirstName = txtName.Text;
            User.LastName = txtSurname.Text;
            User.BirthDate = dtpBirthDate.Value;
            User.RoleID = roleID;
            _userController.Update(User);
        }

        private void frmUserChangePersonalInfo_Load(object sender, EventArgs e)
        {
            User=_userController.GetUserByID(User.UserID);
            txtName.Text = User.FirstName;
            txtSurname.Text = User.LastName;
            txtEmail.Text = User.Email;
            roleID = User.RoleID;
            dtpBirthDate.Value = User.BirthDate;
        }
    }
}
