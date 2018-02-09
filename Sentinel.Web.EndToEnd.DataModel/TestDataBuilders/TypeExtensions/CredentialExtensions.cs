using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.DataModel.TestDataBuilders.TypeExtensions
{
    public static class CredentialExtensions
    {
        public static Credential WithNewPassword(this Credential userProfile, string password)
        {
            return CredentialBuilder.OpenSecurityQuestions(userProfile).WithPassword(password).Create();
        }
    }
}
