using System.Collections.Generic;

namespace Sentinel.Test.EndToEnd.PageModel.DataModel.Types
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        public string Username => Email;
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string CellPhoneNumber { get; set; }
        public IList<SecurityQuestion> SecurityQuestions { get; set; } 

        public User(string firstName, string middleInitial, string lastName, string email, string password, string cellPhoneNumber)
        {
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
            Email = email;
            Password = password;
            PasswordConfirm = password;
            CellPhoneNumber = cellPhoneNumber;
            SecurityQuestions = new List<SecurityQuestion>();
        }
    }
}
