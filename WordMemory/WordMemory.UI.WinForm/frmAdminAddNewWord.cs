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
    public partial class frmAdminAddNewWord : Form
    {
        DictionaryController _dictionaryController;
        Dictionary dictionary;
        frmAdminWordList frmWordList;
        public frmAdminAddNewWord(Form frm)
        {
            InitializeComponent();
            _dictionaryController = new DictionaryController();
            frmWordList = (frmAdminWordList)frm;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTurkish.Text) && !String.IsNullOrWhiteSpace(txtTurkish.Text))
            {
                dictionary = new Dictionary();

                dictionary.English = txtEnglish.Text.Trim();
                dictionary.Turkish = txtTurkish.Text.Trim();
                _dictionaryController.Add(dictionary);
                MessageBox.Show("Ekleme işlemi başarılı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen değer giriniz.");
            }

        }

        private void FrmAdminAddNewWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmWordList.FillDictionary();

        }
    }
}
