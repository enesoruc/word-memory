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
    public class PracticeController
    {
        PracticeManagement _practiceManagement;
        public PracticeController()
        {
            _practiceManagement = new PracticeManagement();
        }

        public bool Add(Practice practice)
        {
            practice.PracticeID = Guid.NewGuid();
            practice.PracticeDate = DateTime.Now;
            return _practiceManagement.Insert(practice) > 0;
        }

        public bool Update(Practice practice)
        {
            return _practiceManagement.Update(practice) > 0;
        }


        public Practice GetPratice(Guid practiceID)
        {
            return _practiceManagement.GetPracticeByID(practiceID);
        }

        public List<Practice> GetListOfPractice()
        {
            return _practiceManagement.GetAllPractices();
        }

        public UserScoreDTO GetTotalUserScoreByUserID(Guid userID)
        {
            return _practiceManagement.GetTotalUserScoreByUserID(userID);
        }
    }
}
