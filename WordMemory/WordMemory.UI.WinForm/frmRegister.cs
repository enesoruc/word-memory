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
    public partial class frmRegister : Form
    {
        User user;
        UserController _userController;

        public frmRegister()
        {
            InitializeComponent();
            _userController = new UserController();

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            user = new User()
            {
                FirstName = txtName.Text,
                LastName = txtSurname.Text,
                BirthDate = dtPickerBirthDate.Value,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            try
            {
                _userController.Add(user, txtConPassword.Text);
                MessageBox.Show("Succesfully Registered");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


    }
}
