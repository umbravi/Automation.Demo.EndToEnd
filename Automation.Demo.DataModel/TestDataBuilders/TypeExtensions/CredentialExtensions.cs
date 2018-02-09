using Automation.Demo.DataModel.Types;

namespace Automation.Demo.DataModel.TestDataBuilders.TypeExtensions
{
    public static class CredentialExtensions
    {
        public static Credential WithNewPassword(this Credential userProfile, string password)
        {
            return CredentialBuilder.OpenCredential(userProfile).WithPassword(password).Create();
        }
    }
}
