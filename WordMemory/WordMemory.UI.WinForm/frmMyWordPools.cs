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
    public partial class frmMyWordPools : Form
    {
        User user;
        WordPool wordPool;
        WordPoolDetailController _wordPoolDetailController;
        WordPoolController _wordPoolController;
        DictionaryController _dictionaryController;

        public frmMyWordPools(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            _wordPoolController = new WordPoolController();
            _wordPoolDetailController = new WordPoolDetailController();
            _dictionaryController = new DictionaryController();
        }

        private void frmMyWordPools_Load(object sender, EventArgs e)
        {
            RefreshAllPoolListBox();
        }

        private void RefreshAllPoolListBox()
        {
            lstBoxAllPools.Items.Clear();
            List<WordPool> allWordPools = _wordPoolController.GetAllMyActiveWordPools(user.UserID);
            //lstViewMyPool.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (WordPool item in allWordPools)
            {
                lstBoxAllPools.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstBoxAllPools.SelectedIndex > -1)
            {
                DialogResult dialogResult = MessageBox.Show("DELETE SELECTED POOL", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    wordPool = (WordPool)lstBoxAllPools.SelectedItem;
                    lblPoolName.Text = wordPool.Name;

                    try
                    {
                        if (_wordPoolController.DeletePool(wordPool))
                        {
                            MessageBox.Show($"{wordPool.Name} Pool has  deleted succesfuly");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    RefreshAllPoolListBox();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }                
            }
            lstViewMyPool.Items.Clear();

        }

        private void lstBoxAllPools_SelectedValueChanged(object sender, EventArgs e)
        {
            lstViewMyPool.Items.Clear();
           
            if (lstBoxAllPools.SelectedIndex>-1)            {
               
                wordPool = (WordPool)lstBoxAllPools.SelectedItem;
                lblPoolName.Text = wordPool.Name;

                RefreshListVİewMyPool(wordPool);
            }
        }

        private void RefreshListVİewMyPool(WordPool wordPool)
        {
            lstViewMyPool.Items.Clear();
            
            ListViewItem lvi;

            List<Dictionary> myActiveWords = _wordPoolDetailController.GetMyActiveWordsByWordPool(wordPool.WordPoolID);

            foreach (Dictionary item in myActiveWords)
            {
                lvi = new ListViewItem(item.English);
                lvi.SubItems.Add(item.Turkish);
                lvi.Tag = item;
                lstViewMyPool.Items.Add(lvi);
            }
        }

        private void btnUpdatePool_Click(object sender, EventArgs e)
        {
            if (lstBoxAllPools.SelectedIndex > -1)
            {
                frmAddWordToPool frmCreateNewWordPool = new frmAddWordToPool(user, wordPool);
                frmCreateNewWordPool.ShowDialog();
                RefreshListVİewMyPool(wordPool);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
