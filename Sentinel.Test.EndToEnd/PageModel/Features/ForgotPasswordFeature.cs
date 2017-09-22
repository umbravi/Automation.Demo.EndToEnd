using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.Test.EndToEnd.PageModel.Pages.ForgotPassword;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Features
{
    public class ForgotPasswordFeature
    {
        public ForgotPasswordPage ForgotPassword;
        public SecurityQuestionPage SecurityQuestion;
        public ResetPasswordPage ResetPassword;

        public ForgotPasswordFeature(User user, BrowserDriver driver)
        {
            ForgotPassword = new ForgotPasswordPage(user, driver);
            SecurityQuestion = new SecurityQuestionPage(user, driver);
            ResetPassword = new ResetPasswordPage(user, driver);
        }
    }
}
