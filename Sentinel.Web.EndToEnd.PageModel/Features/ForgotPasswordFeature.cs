using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.Web.EndToEnd.PageModel.Pages.ForgotPassword;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Features
{
    public class ForgotPasswordFeature
    {
        public ForgotPasswordPage ForgotPassword;
        public SecurityQuestionPage SecurityQuestion;
        public ResetPasswordPage ResetPassword;

        public ForgotPasswordFeature(BrowserDriver driver, UserData userData)
        {
            ForgotPassword = new ForgotPasswordPage(userData, driver);
            SecurityQuestion = new SecurityQuestionPage(userData, driver);
            ResetPassword = new ResetPasswordPage(userData, driver);
        }
    }
}
