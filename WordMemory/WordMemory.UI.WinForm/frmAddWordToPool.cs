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
    public partial class frmAddWordToPool : Form
    {
        WordPool wordPool;
        User user;
        Dictionary dic;
        DictionaryController _dictionaryController;
        WordPoolController _wordPoolController;
        WordPoolDetailController _wordPoolDetailController;
   
        public frmAddWordToPool(User currentUser,WordPool currentPool)
        {
            InitializeComponent();
            _dictionaryController = new DictionaryController();
            _wordPoolController = new WordPoolController();
            _wordPoolDetailController = new WordPoolDetailController();
            user=currentUser ;
            wordPool = currentPool;     
        }


        private void frmCreateNewWordPool_Load(object sender, EventArgs e)
        {
            lblPoolName.Text = wordPool.Name + " Pool";

            ListViewItem lvi;
            List<Dictionary> dictionaries= _dictionaryController.GetListOfWords();
            foreach (Dictionary item in dictionaries)
            {
                lvi = new ListViewItem(item.English);
                lvi.SubItems.Add(item.Turkish);
                lvi.Tag = item;
                lstDictionary.Items.Add(lvi);
            }

            RefreshListVİewMyPool(wordPool);
        }
                
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WordPoolDetail wordPoolDetail;

            if (lstDictionary.SelectedIndices[0]>-1)
            {
                if (_wordPoolDetailController.GetMyActiveWordsByWordPool(wordPool.WordPoolID).Count > 9 && user.RoleID==3)
                {
                  
                }
                else
                {
                    dic = (Dictionary)lstDictionary.SelectedItems[0].Tag;

                    wordPoolDetail = new WordPoolDetail()
                    {
                        WordID = dic.WordID,
                        WordPoolID = wordPool.WordPoolID
                    };

                    _wordPoolDetailController.Add(wordPoolDetail);

                    RefreshListVİewMyPool(wordPool);
                }
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            WordPoolDetail wordPoolDetail;
            if (lstMyDictionary.SelectedIndices.Count>0)
            { 
                dic = (Dictionary)lstMyDictionary.SelectedItems[0].Tag;
            
                wordPoolDetail = new WordPoolDetail()
                {
                    WordID = dic.WordID,
                    WordPoolID = wordPool.WordPoolID                    
                };
                _wordPoolDetailController.Delete(wordPoolDetail);
                RefreshListVİewMyPool(wordPool);
            }
        }

        private void RefreshListVİewMyPool(WordPool wordPool)
        {
            lstMyDictionary.Items.Clear();
            ListViewItem lvi;

            List<Dictionary> myActiveWords = _wordPoolDetailController.GetMyActiveWordsByWordPool(wordPool.WordPoolID);
            
            foreach (Dictionary item in myActiveWords)
            {
                lvi = new ListViewItem(item.English);
                lvi.SubItems.Add(item.Turkish);
                lvi.Tag = item;
                lstMyDictionary.Items.Add(lvi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
