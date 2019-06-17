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
    public partial class frmUserPractice : Form
    {
        Random rnd;

        User user;
        WordPool wordPool;
        Practice practice;
        PracticeDetail practiceDetail;
        
        WordPoolDetailController _wordPoolDetailController;
        PracticeDetailController _practiceDetailController;
        PracticeController _practiceController;

        List<Dictionary> myWords;

        int TrueScore;
        int FalseScore;
        List<int> alreadyIndexed;
      
        int timerCount;


        public frmUserPractice(User currentUser,WordPool CurrentWordPool,Practice currentPractice)
        {
            
            InitializeComponent();
            this.ControlBox = false;
            _wordPoolDetailController = new WordPoolDetailController();
            _practiceDetailController = new PracticeDetailController();
            _practiceController = new PracticeController();

            user = currentUser;
            practice = currentPractice;
            wordPool = CurrentWordPool;
            alreadyIndexed = new List<int>();
        }
        

        private void frmUserPractice_Load(object sender, EventArgs e)
        {
            
            myWords = _wordPoolDetailController.GetMyActiveWordsByWordPool(wordPool.WordPoolID);

            rnd = new Random();

            TrueScore = 0;
            FalseScore = 0;
            timerCount = 0;
            ChangeWord();
        }

     
        int randomlyWordIndex;
        Dictionary globalWord;

        private void ChangeWord()
        {
            
            if (myWords.Count == alreadyIndexed.Count)
            {
                alreadyIndexed.Clear();
            }
            randomlyWordIndex = rnd.Next(myWords.Count);
            
            while (alreadyIndexed.Contains(randomlyWordIndex))
            {
                randomlyWordIndex = rnd.Next(myWords.Count);
            }
            
            alreadyIndexed.Add(randomlyWordIndex);
            globalWord = myWords[randomlyWordIndex];
            UpdateLabel();
            

        }
        
        private void UpdateLabel()
        {
            switch (practice.PracticeTypeID)
            {
                case 1:
                    TurkishToEnglish();
                    break;
                case 2:
                    EnglishToTurkish();
                    break;
                case 3:
                    MixedEnglish();
                    break;
                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            InsertToPracticeDetail(GetResult(), globalWord);

            ChangeWord();
            txtGuess.Clear();
            txtGuess.Focus();
        }

        private bool GetResult()
        {
            bool isSucces = false;
            switch (practice.PracticeTypeID)
            {
                case 1:
                    isSucces= ResultTurkishToEnglish();
                    break;
                case 2:
                    isSucces = ResultEnglishToTurkish();
                    break;
                case 3:
                    isSucces = ResultMixedEnglish();
                    break;
                default:
                    break;
            }
            return isSucces;
        }

        private bool ResultMixedEnglish()
        {
            if (globalWord.English.ToLower() == txtGuess.Text.ToLower())
            {
                TrueScore++;
                lblScore.Text = TrueScore.ToString();
                return true;

            }
            FalseScore++;
            lblScoreFalse.Text = FalseScore.ToString();
            return false;
        }

        private bool ResultEnglishToTurkish()
        {
            if (globalWord.Turkish.ToLower() == txtGuess.Text.ToLower())
            {
                TrueScore++;
                lblScore.Text = TrueScore.ToString();
                return true;
                
            }
            FalseScore++;
            lblScoreFalse.Text = FalseScore.ToString();
            return false;

        }

        private bool ResultTurkishToEnglish()
        {
            if (globalWord.English.ToLower() == txtGuess.Text.ToLower())
            {
                TrueScore++;
                lblScore.Text = TrueScore.ToString();
                return true;
            }
            FalseScore++;
            lblScoreFalse.Text = FalseScore.ToString();
            return false;
        }

        private void MixedEnglish()
        {
            lblWord.Text = GetMixedWord(globalWord.English).ToLower();
            lblWord.Tag = globalWord;
        }

        private void EnglishToTurkish()
        {
            lblWord.Text = globalWord.English.ToLower();
            lblWord.Tag = globalWord;
            
        }

        private void TurkishToEnglish()
        {
            lblWord.Text = globalWord.Turkish.ToLower();
            lblWord.Tag = globalWord;
            
        }

        private void InsertToPracticeDetail(bool isSucces, Dictionary word)
        {
            practiceDetail = new PracticeDetail()
            {
                IsSuccess = isSucces,
                WordID = word.WordID,
                WordPoolID = wordPool.WordPoolID,
                PracticeID = practice.PracticeID
            };
            _practiceDetailController.Add(practiceDetail);
        }

        private string GetMixedWord(string word)
        {
            string newWord = "";
            int randomIndex = 0;
            int uzunluk = word.Length;
            for (int i = uzunluk; i > 0; i--)
            {
                randomIndex = rnd.Next(0, uzunluk);
                newWord += word[randomIndex];
                word = word.Remove(randomIndex, 1);
                uzunluk = word.Length;
            }
            return newWord;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            practice.TrueAnswer = TrueScore;
            practice.FalseAnswer = FalseScore;
            practice.PracticeTime = timerCount;
            _practiceController.Update(practice);

            timer.Enabled = false;
            MessageBox.Show($"YOUR SCORE : {TrueScore} ON {TrueScore+FalseScore} WORDS IN {timerCount} SECONDS");
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerCount++;
            lblTime.Text = timerCount.ToString();
        }
    }
}
