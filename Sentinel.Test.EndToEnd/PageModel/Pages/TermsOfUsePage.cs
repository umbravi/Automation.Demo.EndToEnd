using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages
{
    public class TermsOfUsePage
    {
        private User user;

        private BrowserDriver driver;

        private const string MY_URI = "Account/ForgotPassword";

        public TermsOfUsePage(User user, BrowserDriver driver)
        {
            this.user = user;
            this.driver = driver;
        }
    }
}
