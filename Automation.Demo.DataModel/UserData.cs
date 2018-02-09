using Automation.Demo.DataModel.TestDataBuilders;
using Automation.Demo.DataModel.Types;

namespace Automation.Demo.DataModel
{
    public class UserData
    {
        public Credential Credential { get; set; }

        public UserData()
        {
            Credential = new Credential();
        }

        public UserData(string userEmail, string userPassword)
        {
            Credential = CredentialBuilder.OpenCredential().WithEmail(userEmail).WithPassword(userPassword).Create();
        }
    }
}
