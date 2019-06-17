using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.CustomException;
using WordMemory.DAL;
using WordMemory.Model;

namespace WordMemory.BLL
{
    public class WordPoolController
    {
        WordPoolManagement _wordPoolManagement;
        public WordPoolController()
        {
            _wordPoolManagement = new WordPoolManagement();
        }

        public bool Add(WordPool wordPool)
        {
            try
            {
                ControlPoolName(wordPool.Name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            wordPool.WordPoolID = Guid.NewGuid();
            wordPool.IsActive = true;
            wordPool.CreatedDate = DateTime.Now;            
            return _wordPoolManagement.Insert(wordPool) > 0;
        }

        private void ControlPoolName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new NullOrWhiteSpaceException("(Pool name)");
            }
        }

        public bool UpdateName(WordPool wordPool)
        {
            return _wordPoolManagement.Update(wordPool) > 0;
        }
        public bool DeletePool(WordPool wordPool)
        {
            wordPool.IsActive = false;
            return _wordPoolManagement.Update(wordPool) > 0;
        }

        public WordPool GetWordPoolByID(Guid wordPoolID)
        {
            return _wordPoolManagement.GetWordPoolByWordPoolID(wordPoolID);
        }
        
        public List<WordPool> GetAllMyActiveWordPools(Guid userID)
        {
            return _wordPoolManagement.GetAllMyActiveWordPools(userID);
        }

        public List<WordPool> GetAllWordPool()//admin tüm listeyi çekmesi için
        {
            return _wordPoolManagement.GetAllWordPools();
        }
        public List<WordPool> GetAllWordPoolByUserID(Guid userID)//user'ın kendine ait Pool ların listesini çekmesi için
        {
            return _wordPoolManagement.GetAllWordPoolsByUserID(userID);
        }
    }
}
