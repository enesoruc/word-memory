using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.CustomException;
using WordMemory.DAL;
using WordMemory.DTO;
using WordMemory.Model;

namespace WordMemory.BLL
{
    public class UserController
    {
        UserManagement _userManagement;
        LoginDTO LoginDTO;
       

        public UserController()
        {
            _userManagement = new UserManagement();
            LoginDTO = new LoginDTO();
           
            
        }

        public bool Add(User user, string txtConPassword)
        {
            user.UserID = Guid.NewGuid();
            ControlEmail(user);
            ControlPassword(user.Password, txtConPassword);
            ControlPasswordLenght(txtConPassword);
            int result = _userManagement.Insert(user);

            return result > 0;
        }
        
        private void ControlEmail(User user)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(user.Email);
            }
            catch
            {
                throw new MailFormatException();
            }

            List<User> users= _userManagement.GetAllUser();
            foreach (User item in users)
            {
                if (item.Email==user.Email)
                {
                    throw new MailAllreadyExistException();
                }
            }
        }

        private void ControlPassword(string password, string txtConPassword)
        {
            if (password!=txtConPassword)
            {
                throw new NotEqualPasswordsException();
            }
        }

        private void ControlPasswordLenght(string password)
        {
            if (password.Length<5)
            {
                throw new PasswordLenghtException();
            }
        }        

        public bool Update(User user)
        {
            int result = _userManagement.Update(user);

            return result > 0;
        } 
        public bool DeleteUser(User user)
        {
            int result = _userManagement.DeleteAccount(user.UserID);
            return result > 0;
        }

        public List<User> GetAllUser()
        {
            return _userManagement.GetAllUser();
        }

        public List<User> GetUsersByRoleID(Guid roleID)
        {
            return _userManagement.GetUsersByRoleID(roleID);
        }

        public int GetPoolCountByUserID(Guid userID)
        {

            return _userManagement.GetPoolCountByUserID(userID);

        }

        public User GetUserByID(Guid userID)
        {
            return _userManagement.GetUserByID(userID);
        }

        public User UserLogin(LoginDTO loginDTO)
        {
            User user = new User();
            try
            {
                user = _userManagement.UserLogin(loginDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return user;
        }

        public List<UserReportDTO> GetReportUserBetweenDate(string d1, string d2)
        {
            return _userManagement.GetUserReportBetweenDateRange(d1, d2);
        }

        public List<UserReportDTO> GetWordUserReportByWeek(string d1)
        {
            return _userManagement.GetWordUserReportByWeek(d1);
        }

        public List<UserReportDTO> GetWordUserReportByMonth(string d1)
        {
            return _userManagement.GetWordUserReportByMonth(d1);
        }


    }
}
