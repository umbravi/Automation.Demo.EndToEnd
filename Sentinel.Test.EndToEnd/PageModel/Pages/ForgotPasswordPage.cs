using Sentinel.Test.EndToEnd.PageModel.DataModel;
using Sentinel.Test.EndToEnd.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages
{
    public class ForgotPasswordPage
    {
        internal User User;

        private Interactions _interactions;

        private string MyUri = "Account/ForgotPassword";
    }
}
