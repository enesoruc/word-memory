using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.DAL;
using WordMemory.DTO;
using WordMemory.Model;

namespace WordMemory.BLL
{
    public class DictionaryController
    {
        DictionaryManagement _dictionaryManagement;
        public DictionaryController()
        {
            _dictionaryManagement = new DictionaryManagement();
        }

        public bool Add(Dictionary dictionary)
        {
            dictionary.WordID = Guid.NewGuid();
            dictionary.IsActive = true;
            return _dictionaryManagement.Insert(dictionary) > 0;
        }

        public bool Delete(Dictionary dictionary)
        {
            dictionary.IsActive = false;
            return _dictionaryManagement.Update(dictionary) > 0;
        }

        public bool Update(Dictionary dictionary)
        {
            return _dictionaryManagement.Update(dictionary) > 0;
        }

        public Dictionary GetWord(Guid wordID)
        {
            return _dictionaryManagement.GetWordByID(wordID);
        }

        public List<Dictionary> GetListOfWords()
        {
            return _dictionaryManagement.GetAllWords();
        }

        public List<WordReportDTO> GetReportWordBetweenDate(string d1, string d2)
        {
            return _dictionaryManagement.GetReportBetweenDateRange(d1, d2);
        }

        public List<WordReportDTO> GetWordReportByWeek(string d1)
        {
            return _dictionaryManagement.GetWordReportByWeek(d1);
        }

        public List<WordReportDTO> GetWordReportByMonth(string d1)
        {
            return _dictionaryManagement.GetWordReportByMonth(d1);
        }


    }
}
