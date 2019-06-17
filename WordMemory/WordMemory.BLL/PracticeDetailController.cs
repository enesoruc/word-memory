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
    public class PracticeDetailController
    {
        PracticeDetailManagement _practiceDetailManagement;

        public PracticeDetailController()
        {
            _practiceDetailManagement = new PracticeDetailManagement();
        }

        //public bool Add(PracticeDetail practiceDetail, PracticeDetailDTO practiceDetailDto)
        //{
        //    List<PracticeDetail> practicedetail = _practiceDetailManagement.GetAllPracticeDetails();
        //    practiceDetail.PracticeID = practiceDetailDto.PracticeID;
        //    practiceDetail.WordPoolID = practiceDetailDto.WordPoolID;
        //    practiceDetail.WordID = practiceDetailDto.WordID;
        //    return _practiceDetailManagement.Insert(practiceDetail) > 0;
        //}

        public bool Add(PracticeDetail practiceDetail)
        {
            return _practiceDetailManagement.Insert(practiceDetail) > 0;
        }

        public PracticeDetail GetPracticeDetailByPracticeDetailID(int practiceDetailID)
        {
            return _practiceDetailManagement.GetPracticeDetailsByPracticeDetailID(practiceDetailID);
        }

        public List<PracticeDetail> GetPracticeDetailByPracticeID(Guid practiceID)
        {
            List<PracticeDetail> practiceDetail = new List<PracticeDetail>();
            foreach (var item in _practiceDetailManagement.GetAllPracticeDetails())
            {
                if (practiceID==item.PracticeID)
                {
                    practiceDetail.Add(item);
                }
            }
            return practiceDetail;
        }

        public List<PracticeDetail> GetPracticeDetailByWordPoolID(Guid wordPoolID)
        {
            List<PracticeDetail> practiceDetail = new List<PracticeDetail>();
            foreach (var item in _practiceDetailManagement.GetAllPracticeDetails())
            {
                if (wordPoolID == item.WordPoolID)
                {
                    practiceDetail.Add(item);
                }
            }
            return practiceDetail;
        }

        public List<PracticeDetail> GetPracticeDetailByUserID(Guid wordID)
        {
            List<PracticeDetail> practiceDetail = new List<PracticeDetail>();
            foreach (var item in _practiceDetailManagement.GetAllPracticeDetails())
            {
                if (wordID == item.WordID)
                {
                    practiceDetail.Add(item);
                }
            }
            return practiceDetail;
        }

        public List<PracticeDetail> GetAllPracticeDetails()
        {
            return _practiceDetailManagement.GetAllPracticeDetails();
        }


































    }
}
