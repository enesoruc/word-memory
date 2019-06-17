using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordMemory.DAL;
using WordMemory.Model;

namespace WordMemory.UI.WinForm
{
    public partial class frmAdminDictionary : Form
    {
        DictionaryManagement _dictionaryManagement;
        Dictionary dictionary;
        public frmAdminDictionary()
        {
            InitializeComponent();
            _dictionaryManagement = new DictionaryManagement();
        }

        private void FrmAdminDictionary_Load(object sender, EventArgs e)
        {
            dgvDictionary.DataSource = _dictionaryManagement.GetAllWords();
        }
    }
}
