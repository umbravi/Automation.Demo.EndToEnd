using Libraries.WebDriver;
using Sentinel.EndToEnd.PageModel.DataModel;

namespace Sentinel.EndToEnd.PageModel.Pages
{
    public class ForgotPasswordPage
    {
        internal User User;

        private Interactions _interactions;

        private string MyUri = "Account/ForgotPassword";
    }
}
