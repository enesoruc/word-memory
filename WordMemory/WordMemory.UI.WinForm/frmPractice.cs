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
    public partial class frmPractice : Form
    {
        User user;
        Practice practice;
        WordPool wordPool;
        WordPoolController _WordPoolController;
        WordPoolDetailController _wordPoolDetailController;
      
        PracticeController _practiceController;
        
        public frmPractice(User Currentuser)
        {
            InitializeComponent();
            user = Currentuser;
            _WordPoolController = new WordPoolController();
            _wordPoolDetailController = new WordPoolDetailController();
            _practiceController = new PracticeController();
        }

        private void frmPractice_Load(object sender, EventArgs e)
        {
            List<WordPool> allWordPools = _WordPoolController.GetAllMyActiveWordPools(user.UserID);

            foreach (WordPool item in allWordPools)
            {
                lstMyPools.Items.Add(item);
            }
            if (user.RoleID == 3)
            {
                btnRandom.Enabled = false;
            }
            else
            {
                btnRandom.Enabled = true;
            }
        }
 
        private void button1_Click_1(object sender, EventArgs e)
        {
            StartNewPractice(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartNewPractice(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartNewPractice(3);            
        }

        void StartNewPractice(byte practiceTypeID)
        {
            practice = new Practice()
            {
                PracticeTypeID= practiceTypeID,
                PracticeID = Guid.NewGuid(),
                FalseAnswer =0,
                TrueAnswer = 0,
                PracticeTime =0

            };

            _practiceController.Add(practice);


            if (lstMyPools.SelectedIndex>-1)
            {
                frmUserPractice frmUserPractice = new frmUserPractice(user, wordPool, practice);
                frmUserPractice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a Pool first.");
            }


        }

        private void lstMyPools_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshMyWords();
        }

        void RefreshMyWords()
        {

            lstInWords.Items.Clear();
            if (lstMyPools.SelectedIndex > -1)
            {
                ListViewItem lvi;

                wordPool = (WordPool)lstMyPools.SelectedItem;

                List<Dictionary> activeWords = _wordPoolDetailController.GetMyActiveWordsByWordPool(wordPool.WordPoolID);

                foreach (Dictionary item in activeWords)
                {
                    lvi = new ListViewItem(item.English);
                    lvi.SubItems.Add(item.Turkish);
                    lvi.Tag = item;
                    lstInWords.Items.Add(lvi);
                }
            }
        }
    }
}
