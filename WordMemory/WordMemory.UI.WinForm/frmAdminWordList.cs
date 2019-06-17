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
    public partial class frmAdminWordList : Form
    {
        DictionaryController _dictionaryController;
        Dictionary dictionary;
        public frmAdminWordList()
        {
            InitializeComponent();
            _dictionaryController = new DictionaryController();
            dictionary = new Dictionary();
        }

        ListViewItem lvi;
        private void FrmAdminWordList_Load(object sender, EventArgs e)
        {
            FillDictionary();
        }

        public void FillDictionary()
        {
            lstDictionary.Items.Clear();
            foreach (var item in _dictionaryController.GetListOfWords())
            {
                lvi = new ListViewItem(item.Turkish);
                lvi.SubItems.Add(item.English);
                lvi.SubItems.Add(item.AddedDate.ToString());
                lvi.SubItems.Add(item.IsActive.ToString());
                lvi.Tag = item;
                lstDictionary.Items.Add(lvi);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAdminAddNewWord frm = new frmAdminAddNewWord(this);
            frm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dictionary = (Dictionary)lstDictionary.SelectedItems[0].Tag;
            frmAdminChangeWord frm = new frmAdminChangeWord(dictionary,this);
            frm.Show();
        }
    }
}
