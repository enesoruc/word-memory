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
    public partial class frmCreateNewWordPool : Form
    {
        User user;
        WordPoolController _wordPoolController;

        public frmCreateNewWordPool(User CurrentUser)
        {
            InitializeComponent();
            user = CurrentUser;
            _wordPoolController = new WordPoolController();
        }

        private void frmCreateNewWordPool_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewPool_Click(object sender, EventArgs e)
        {
            WordPool wordPool = new WordPool()
            {
                Name = txtPoolName.Text,
                UserID = user.UserID
            };

            try
            {
                _wordPoolController.Add(wordPool);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Pool has succesfully created.");
            this.Close();

        }
    }
}
