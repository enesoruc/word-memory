using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class User
    {

        public User()
        {

        }

        public Guid UserID { get; set; }
        public byte RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
