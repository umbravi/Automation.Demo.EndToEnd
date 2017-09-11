namespace Sentinel.Test.EndToEnd.PageModel.DataModel
{
    public class User
    {
        public string FirstName;
        public string LastName;
        public string MiddleInitial;
        public string Email;
        public string Password;
        public string CellPhoneNumber;

        public User(string firstName, string middleInitial, string lastName, string email, string password, string cellPhoneNumber)
        {
            this.FirstName = firstName;
            this.MiddleInitial = middleInitial;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.CellPhoneNumber = cellPhoneNumber;
        }
    }
}
