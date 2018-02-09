using Sentinel.Web.EndToEnd.DataModel.TestDataBuilders;
using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.DataModel
{
    public class UserData
    {
        public AgentProfile AgentProfile { get; set; }
        public Credential Credential { get; set; }
        public SecurityQuestions SecurityQuestions { get; set; }

        public UserData()
        {
            AgentProfile = new AgentProfile();
            Credential = new Credential();
            SecurityQuestions = new SecurityQuestions();
        }

        public UserData(string userEmail, string userPassword)
        {
            AgentProfile = AgentProfileBuilder.OpenUser().WithCompleteProfile().Create();
            Credential = CredentialBuilder.OpenSecurityQuestions().WithEmail(userEmail).WithPassword(userPassword).Create();
        }
    }
}
