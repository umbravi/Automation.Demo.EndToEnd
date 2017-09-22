using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;

namespace Sentinel.Test.EndToEnd.PageModel.DataModel.TestDataFactory
{
    internal static class DataGenerator
    {
        internal static User GenerateUser()
        {
            // TODO: Add Random Generation
            return new User("View", "LI", "Agent", "vagent@agency.gov", "imanagent007", "006-005-0001");
        }

        internal static string GenerateNewPassword(User user)
        {
            var newPassword = user.Password + "1";
            return newPassword;
        }
    }
}
