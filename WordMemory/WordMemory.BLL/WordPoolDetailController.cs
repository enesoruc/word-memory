using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.DAL;
using WordMemory.Model;

namespace WordMemory.BLL
{
    public class WordPoolDetailController
    {
        WordPoolDetailManagement _wordPoolDetailManagement;

        public WordPoolDetailController()
        {
            _wordPoolDetailManagement = new WordPoolDetailManagement();
        }

        public bool Add(WordPoolDetail wordPoolDetail)
        {
            if (_wordPoolDetailManagement.IsPoolContainsAlready(wordPoolDetail))
            {
               
               return Update(wordPoolDetail);
            }
            else
            {
                wordPoolDetail.IsActive = true;
                wordPoolDetail.CreatedDate = DateTime.Now;
                int result = _wordPoolDetailManagement.Insert(wordPoolDetail);
                return result > 0;
            }
        }

        public bool Delete(WordPoolDetail wordPoolDetail)
        {
            wordPoolDetail.IsActive = false;
            int result = _wordPoolDetailManagement.Update(wordPoolDetail);
            return result > 0;
        }
        public bool Update(WordPoolDetail wordPoolDetail)
        {
            wordPoolDetail.IsActive = true;
            wordPoolDetail.CreatedDate = DateTime.Now;

            int result = _wordPoolDetailManagement.Update(wordPoolDetail);
            return result > 0;
        }

        public List<Dictionary> GetMyActiveWordsByWordPool(Guid wordPoolID)
        {
            return _wordPoolDetailManagement.GetActiveWordsByWordPoolID(wordPoolID);
        }

        public List<WordPoolDetail> GetAllWordPoolDetail()//tüm wordpool ları döner
        {
            return _wordPoolDetailManagement.GetAllWordPoolDetail();
        }

        public List<WordPoolDetail> GetAllWordPoolDetailByID(Guid worldPoolID)
        {
            return _wordPoolDetailManagement.GetWordPoolDetailByWordPoolID(worldPoolID);

        }


        public List<WordPoolDetail> GetAllWordPoolDetailsByIsActive(bool IsActive)//aktif olan wordpool lerı döner
        {
            List<WordPoolDetail> wordPoolDetails = new List<WordPoolDetail>();
            foreach (WordPoolDetail item in _wordPoolDetailManagement.GetAllWordPoolDetail())
            {
                if (item.IsActive)
                {
                    wordPoolDetails.Add(item);
                }
            }
            return wordPoolDetails;
        }
    }
}
