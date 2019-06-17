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
    public partial class frmAdminViewUsers : Form
    {
        UserController _userController;
        User user;
        public frmAdminViewUsers()
        {
            InitializeComponent();
            _userController = new UserController();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            user = (User)lstUsers.SelectedItems[0].Tag;
            if (user.IsActive == true)
            {
                MessageBox.Show("Aktif kullanıcı , güncelleyemezsiniz.");
            }
            else
            {
                user.IsActive = true;
                _userController.Update(user);
                RefreshList();
                MessageBox.Show("Kullanıcı aktifleştirildi.");
            }
        }

        ListViewItem lvi;
        private void FrmAdminViewUsers_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            lstUsers.Items.Clear();
            foreach (var item in _userController.GetAllUser())
            {
                lvi = new ListViewItem(item.IsActive.ToString());
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.CreatedDate.ToString());
                lvi.Tag = item;
                lstUsers.Items.Add(lvi);
            }
        }
    }
}
