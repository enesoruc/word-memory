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
    public class AdminReportController
    {
        DictionaryManagement _dictionaryManagement;
        PracticeManagement _practiceManagement;
        PracticeDetailManagement _practiceDetailManagement;
        UserManagement _userManagement;
        WordPoolManagement _wordPoolManagement;
        WordPoolDetailManagement _wordPoolDetailManagement;
        PaymentManagement _paymentManagement;
               
        public AdminReportController()
        {
            _dictionaryManagement = new DictionaryManagement();
        }

        public string GetCount(string Entity)
        {
            int result = 0;
            switch (Entity)
            {
                case "Dictionary":
                    _dictionaryManagement = new DictionaryManagement();
                    result = _dictionaryManagement.GetAllWords().Count();
                    break;
                case "Practice":
                    _practiceManagement = new PracticeManagement();
                    result = _practiceManagement.GetAllPractices().Count();
                    break;
                case "PracticeDetail":
                    _practiceDetailManagement = new PracticeDetailManagement();
                    result = _practiceDetailManagement.GetAllPracticeDetails().Count();
                    break;
                case "User":
                    _userManagement = new UserManagement();
                    result = _userManagement.GetAllUser().Count();
                    break;
                case "WordPool":
                    _wordPoolManagement = new WordPoolManagement();
                    result = _wordPoolManagement.GetAllWordPools().Count();
                    break;
                case "WordPoolDetail":
                    _wordPoolDetailManagement = new WordPoolDetailManagement();
                    result = _wordPoolDetailManagement.GetAllWordPoolDetail().Count();
                    break;
                case "Payment":
                    _paymentManagement = new PaymentManagement();
                    result = _paymentManagement.GetAllPayments().Count();
                    break;
                default:
                    break;
            }
            return result.ToString();
        }



    }
}
