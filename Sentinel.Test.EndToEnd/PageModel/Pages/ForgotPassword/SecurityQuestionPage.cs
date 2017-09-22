using System.Linq;
using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class SecurityQuestionPage
    {
        internal User User;

        private readonly BrowserDriver driver;

        private const string SECURITY_ANSWER_FIELD_ID = "SecurityAnswer";
        private const string SECURITY_QUESTION_LABEL_TEXT = "Security Question";
        private const string NEXT_BUTTON_TEXT = "Next";

        public SecurityQuestionPage(User user, BrowserDriver driver)
        {
            User = user;
            this.driver = driver;
        }

        public void SendSecurityAnswer()
        {
            var question = driver.Interactions.GetElementTextByLabelText(SECURITY_QUESTION_LABEL_TEXT);
            var answer = User.SecurityQuestions.FirstOrDefault(sq => sq.Question.ToUpper() == question.ToUpper()).Answer;
            driver.Interactions.SendTextById(SECURITY_ANSWER_FIELD_ID, answer);
        }

        public void ClickNextButton()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}
