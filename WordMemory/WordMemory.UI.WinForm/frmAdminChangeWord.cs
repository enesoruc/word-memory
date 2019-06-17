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
    public partial class frmAdminChangeWord : Form
    {
        DictionaryController _dictionaryController;
        Dictionary updatedDictionary;
        frmAdminWordList frmWordList;
        public frmAdminChangeWord(Dictionary dictionary, Form frm)
        {
            InitializeComponent();
            txtEnglish.Text = dictionary.English;
            txtTurkish.Text = dictionary.Turkish;
            chkActive.Checked = dictionary.IsActive;
            updatedDictionary = dictionary;
            _dictionaryController = new DictionaryController();
            frmWordList = (frmAdminWordList)frm;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                updatedDictionary.IsActive = true;
            }
            else
            {
                updatedDictionary.IsActive = false;
            }
            updatedDictionary.Turkish = txtTurkish.Text;
            updatedDictionary.English = txtEnglish.Text;
            _dictionaryController.Update(updatedDictionary);
            Close();
        }

        private void FrmAdminChangeWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmWordList.FillDictionary();
        }
    }
}
